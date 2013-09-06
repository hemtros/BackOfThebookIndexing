using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LemmaSharp;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;


namespace BackOfTheBookIndexing
{
    

   
//sealed so so to decrease the overhead of inheritance preparation by .NET

   sealed class DocumentProcessor
    {
        
        private int _tUniqueWordsinPage;
       
        private List<Words> wordList;
        private List<string> nrSplittedWords;
        private List<string> splittedWords;
        private List<int> countList;
        private List<Sentences> sentenceList;
       
        private int currentcountofsentences;
        private List<UniqueWords> UniqueWordList;
       
        private List<string> UniqueWordsinCorpus=new List<string>();


        private string[] _stopWords;
        private List<int> _eachPageWordCount;
       
        //private MatrixProcessor matrixpro=new MatrixProcessor();
        static ILemmatizer lmtz = new LemmatizerPrebuiltCompact(LanguagePrebuilt.English);
       
        public DocumentProcessor()
        {
            wordList=new List<Words>();
            nrSplittedWords=new List<string>();
            splittedWords=new List<string>();
            countList=new List<int>();
            sentenceList=new List<Sentences>();
            currentcountofsentences = 0;
            UniqueWordList=new List<UniqueWords>();
            _tUniqueWordsinPage = 0;
            UniqueWordsinCorpus=new List<string>();
           _eachPageWordCount=new List<int>();
           _stopWords = File.ReadAllLines("stopwords.txt");

        }
       
        public List<UniqueWords> ReadFileContent()
        {
            
            if (DocumentInfo.Extension == ".doc")
            {

                try
                {


                    Word2pdf w2p = new Word2pdf();
                    string pathToPdf = w2p.ConvertToPdf(DocumentInfo.Filename);
                    ReadPdf(pathToPdf);
                    

                }

                catch (COMException)
                {
                    MessageBox.Show("Unable to read this document.  It may be corrupt.");

                }
            }

            else if(DocumentInfo.Extension==".docx")
            {
                try
                {


                    var w2p = new Word2pdf();
                    string pathToPdf = w2p.ConvertToPdf(DocumentInfo.Filename);
                    ReadPdf(pathToPdf);


                }

                catch (COMException)
                {
                    MessageBox.Show("Unable to read this document.  It may be corrupt.");

                }
                
            }

            else if(DocumentInfo.Extension == ".odt")
            {
                try
                {


                    var w2p = new Word2pdf();
                    string pathToPdf = w2p.ConvertToPdf(DocumentInfo.Filename);
                    ReadPdf(pathToPdf);


                }

                catch (COMException)
                {
                    MessageBox.Show("Unable to read this document.  It may be corrupt.");

                }
            }


            else
            {
                ReadPdf(DocumentInfo.Filename);
            }
            return UniqueWordList;
        }

        //Read stop word list from text file called stopwords.txt

        //public string[] StopWords()
        //{
        //    string[] stopText = File.ReadAllLines("stopwords.txt");
        //    return stopText;

        //}

      
        public void ReadPdf(string pdfpath)
        {
            try
            {

                PdfReader pdfr = new PdfReader(pdfpath);
                StringBuilder pdfText = new StringBuilder();

                int tp = DocumentInfo.TotalPages;
                //loop to read pdf page by page

                for (int page = 1; page <= tp; page++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string currentText = PdfTextExtractor.GetTextFromPage(pdfr, page, strategy);



                    currentText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentText)));

                    //currentText = currentText.ToLower();


                    POSTagger.mModelPath = "Models\\";
                    string[] tSplittedWords = GetWords(currentText);

                    string[] sentences = POSTagger.SplitSentences(currentText);

                    Sentences[] sentencearray = new Sentences[sentences.Count()];

                    int sc = sentences.Count();
                    for (int i = 0; i < sc; i++)
                    {
                        sentencearray[i] = new Sentences();

                        sentencearray[i].SentenceNumber = i + 1 + currentcountofsentences;

                        sentencearray[i].SentenceString = sentences[i].ToLower();
                        sentenceList.Add(sentencearray[i]);
                    }

                    currentcountofsentences += sentences.Count();

                    string[] POS = POSTagger.PosTagTokens(tSplittedWords);

                    splittedWords.Clear();
                    nrSplittedWords.Clear();
                    countList.Clear();

                    int poslength = POS.Length;
                    for (int i = 0; i < poslength; i++)
                    {
                        //NN Noun, singular or mass
                        //NNS Noun, plural
                        //NNP Proper noun, singular
                        //NNPS Proper noun, plural

                        if (POS[i] == "NN" || POS[i] == "NNS" || POS[i] == "NNP" || POS[i] == "NNPS")
                        {
                        tSplittedWords[i] = tSplittedWords[i].ToLower();
                        splittedWords.Add(tSplittedWords[i]);
                        }



                    }


                    //removing stop words from splittedwords list
                    List<string> t1SplittedWords = new List<string>();
                    foreach (string sw in splittedWords)
                    {

                        if (!Array.Exists(_stopWords, element => element == sw))
                        {

                            t1SplittedWords.Add(sw);

                        }

                        //this also works
                        //if (!_stopWords.Contains(sw))
                        //{
                        //    t1SplittedWords.Add(sw);
                        //}

                    }
                    splittedWords.Clear();
                    splittedWords = t1SplittedWords.ToList();

                    nrSplittedWords = splittedWords.Distinct().ToList();


                    int nrswcount = nrSplittedWords.Count;

                    _eachPageWordCount.Add(nrswcount);
                    _tUniqueWordsinPage = nrswcount;

                    //calculating frequency of words in each page i.e. Term Frequency
                    
                    for (int i = 0; i < nrswcount; i++)
                    {
                        string searchItem = nrSplittedWords[i];


                        int count = 0;
                        for (int j = 0; j < splittedWords.Count(); j++)
                        {
                            if (searchItem == splittedWords[j])
                                count++;

                        }

                        countList.Add(count);

                    }
                    Words[] wordarray = new Words[nrSplittedWords.Count()];

                    for (int i = 0; i < nrswcount; i++)
                    {
                        wordarray[i] = new Words();
                        wordarray[i].Word = nrSplittedWords[i];
                        wordarray[i].TermFrequency = countList[i];
                        wordarray[i].Pageno = page;
                        wordList.Add(wordarray[i]);

                    }

                    //foreach (string s in nrSplittedWords)
                    //{
                    //    UniqueWordsinCorpus.Add(s);
                    //}
                    UniqueWordsinCorpus.AddRange(nrSplittedWords);

                    pdfText.Append(currentText);

                }                  //end of page loop

                pdfr.Close();

                //UniqueWordsinCorpus is a list of string of unique words
                UniqueWordsinCorpus = UniqueWordsinCorpus.Distinct().ToList();

                UniqueWordsinCorpus.Sort();



                foreach (Words w in wordList)
                {
                    int corf = 0;
                    foreach (Words w1 in wordList)
                    {
                        if (w.Word == w1.Word)
                            corf = corf + w1.TermFrequency;


                    }

                    w.CorpusFrequency = corf;
                }


                foreach (Words w in wordList)
                {
                    w.SentencenoWithFrequency = new Dictionary<int, int>();
                    foreach (Sentences s in sentenceList)
                    {
                        int sentfreq = 0;
                        string[] splittedwordsofsentence = GetWords(s.SentenceString);

                        int swoscount = splittedwordsofsentence.Count();
                        for (int i = 0; i < swoscount; i++)
                        {
                            if (w.Word == splittedwordsofsentence[i])
                                sentfreq++;
                        }
                        w.SentencenoWithFrequency.Add(s.SentenceNumber, sentfreq);
                    }
                }



                //wordList.Sort(delegate(Words w1, Words w2) { return w1.Word.CompareTo(w2.Word); });

                wordList.Sort((w1, w2) => w1.Word.CompareTo(w2.Word));


 //copying words from wordList of Words to uniquewordlist of uniquewords while removing the redundant entry

                UniqueWords[] uniquewordarray = new UniqueWords[UniqueWordsinCorpus.Count];

                int uwiccount = UniqueWordsinCorpus.Count;
                for (int i = 0; i < uwiccount; i++)
                {


                    uniquewordarray[i] = new UniqueWords();
                    uniquewordarray[i].SentencenoWithFrequency = new Dictionary<int, int>();
                    uniquewordarray[i].PagenoWithFrequency = new Dictionary<int, int>();
                    foreach (Words w in wordList)
                    {
                        if (UniqueWordsinCorpus[i] == w.Word)
                        {
                            if (uniquewordarray[i].Term == null)
                                uniquewordarray[i].Term = w.Word;


                            uniquewordarray[i].CorpusFrequency = w.CorpusFrequency;

                            uniquewordarray[i].SentencenoWithFrequency = w.SentencenoWithFrequency;

                            uniquewordarray[i].PagenoWithFrequency.Add(w.Pageno, w.TermFrequency);

                        }
                    }

                    UniqueWordList.Add(uniquewordarray[i]);

                }

 //computing document frequency of unique words

                foreach (UniqueWords uw in UniqueWordList)
                {
                    uw.DocFrequency = uw.PagenoWithFrequency.Count;
                }


               

                //Displaying uniquewords with their attribute values

                //foreach (UniqueWords uw in UniqueWordList)
                //{
                //    DocText.AppendText(uw.Term + "........");
                //    DocText.AppendText(uw.CorpusFrequency.ToString() + "\n");
                //    DocText.AppendText("Sentence no with frequency \n");
                //    List<KeyValuePair<int, int>> list = uw.SentencenoWithFrequency.ToList();
                //    foreach (KeyValuePair<int, int> pair in list)
                //    {
                //        if (pair.Value > 0)
                //        {
                //            DocText.AppendText(pair.Key.ToString() + ".......");
                //            DocText.AppendText(pair.Value.ToString() + Environment.NewLine);
                //        }

                //    }
                //    DocText.AppendText("Page no with freqency \n");
                //    List<KeyValuePair<int, int>> list1 = uw.PagenoWithFrequency.ToList();
                //    foreach (KeyValuePair<int, int> pair in list1)
                //    {
                //        if (pair.Value > 0)
                //        {
                //            DocText.AppendText(pair.Key.ToString() + ".......");
                //            DocText.AppendText(pair.Value.ToString() + Environment.NewLine);
                //        }

                //    }
                //}

                //foreach (Words w in wordList)
                //{
                //    DocText.AppendText(w.Word + Environment.NewLine);
                //    List<KeyValuePair<int, int>> list = w.SentencenoWithFrequency.ToList();
                //    foreach (KeyValuePair<int, int> pair in list)
                //    {
                //        if (pair.Value > 0)
                //        {
                //            DocText.AppendText(pair.Key.ToString() + ".......");
                //            DocText.AppendText(pair.Value.ToString() + Environment.NewLine);
                //        }

                //    }

                //}



                // matrixpro.GenerateMatrix(UniqueWordList);


                //UserWordsEditor uwe=new UserWordsEditor(UniqueWordList);
                //uwe.Show();



            }
            catch (Exception se)
            {

                MessageBox.Show(se.Message);
            }

        }

        static string[] GetWords(string input)
        {
            MatchCollection matches = Regex.Matches(input, @"\b[\w']*\b");
            int i;
            
            var words = from m in matches.Cast<Match>()
                        where
                            !string.IsNullOrEmpty(m.Value) && !int.TryParse(m.Value, out i) && m.Value.Length > 4 && 
                            m.Value.All(char.IsLetter)
                        select LemmatizeOne(lmtz,TrimSuffix(m.Value));


            //string[] wordsArray = words.ToArray();
            

            //List<string> lemmatizedWordList = new List<string>();

            //foreach (string wa in wordsArray)
            //{
              //  string lemma = LemmatizeOne(lmtz, wa);
              //  lemmatizedWordList.Add(lemma);
            //}

            //;
            //return (words.ToArray());
            //string[] wordsArrayFinal = lemmatizedWordList.ToArray();
            
            // return wordsArray.Select(ai => LemmatizeOne(lmtz, ai)).ToArray();
            //return wordsArrayFinal;
            return words.ToArray();
        }

       public static string TrimSuffix(string word)
        {
            int apostrapheLocation = word.IndexOf('\'');
            if (apostrapheLocation != -1)
            {
                word = word.Substring(0, apostrapheLocation);
            }

          
            return word;
        }

       private static string LemmatizeOne(LemmaSharp.ILemmatizer lmtz, string word)
       {
           string wordLower = word.ToLower();
           string lemma = lmtz.Lemmatize(wordLower);
           return lemma;

       }

    }

}
