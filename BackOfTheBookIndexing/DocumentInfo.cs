using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Word=Microsoft.Office.Interop.Word;
using System.Text;
using System.IO;

namespace BackOfTheBookIndexing
{
     static class DocumentInfo
    {
        public static string Filename { get; set; }
        public static double Size { get; set; }
        public static string DocumentType { get; set; }
        public static int TotalPages { get; set; }
        public static int NoOfWords { get; set; }
        public static string Extension { get; set; }
       

        public static void SetProperties(string filename)
        {
            Filename = filename;
            FileInfo fi = new FileInfo(Filename);
            Size = Math.Round(Convert.ToDouble(fi.Length)/(1048576), 2);    //1048576=1024*1024
            Extension = fi.Extension;

            if (Extension == ".pdf")
            {
                DocumentType = "Portable Document Format(.pdf)";
       
               
                PdfReader pdfr = new PdfReader(Filename);
                StringBuilder pdfText = new StringBuilder();

                TotalPages = pdfr.NumberOfPages;
                 
                //loop to read pdf page by page

                for (int page = 1; page <= pdfr.NumberOfPages; page++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string currentText = PdfTextExtractor.GetTextFromPage(pdfr, page, strategy);



                    currentText =
                        Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8,
                                                                      Encoding.Default.GetBytes(currentText)));

                    pdfText.Append(currentText);
                }

                pdfr.Close();

                string completetext=pdfText.ToString();
               // NoOfWords=completetext.Split(' ').Length;

                NoOfWords=Regex.Matches(completetext, @"[A-Za-z0-9]+").Count;

            }

            else if (Extension == ".odt")
            {
                DocumentType = "Open Document Format(.odt)";
                ComputeStatistics();

            }

            else if (Extension == ".docx")
            {
                DocumentType = "Microsoft Word Document(.docx)";
                ComputeStatistics();
            }

            else
            {
                DocumentType = "Word 97-2003 document(.doc)";
                ComputeStatistics();

            }
        }

       private static void ComputeStatistics()
        {
            int pagecount = 0;
            int wordcount = 0;

            object fileName = Filename;
            object readOnly = false;
            object isVisible = false;
            object objDNS = Word.WdSaveOptions.wdPromptToSaveChanges;
            object missing = System.Reflection.Missing.Value;

            Word._Application WordApp = new Word.ApplicationClass();

            Word._Document aDoc = null;

            try
            {
                aDoc = WordApp.Documents.Open
                    (
                        ref fileName, ref missing, ref readOnly,
                        ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref isVisible,
                        ref missing, ref missing, ref missing,
                        ref missing
                    );

                Word.WdStatistic pagestat = Word.WdStatistic.wdStatisticPages;
                Word.WdStatistic wordstat = Word.WdStatistic.wdStatisticWords;
                
                pagecount = aDoc.ComputeStatistics(pagestat, ref missing);
                wordcount = aDoc.ComputeStatistics(wordstat, ref missing);



            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (aDoc != null)
                {
                    aDoc.Close(ref objDNS, ref missing, ref missing);
                    Marshal.ReleaseComObject(aDoc);
                    aDoc = null;
                }
                if (WordApp != null)
                {
                    WordApp.Quit(ref objDNS, ref missing, ref missing);
                    Marshal.ReleaseComObject(WordApp);
                    WordApp = null;
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            TotalPages = pagecount;
            NoOfWords = wordcount;
        }
    }


}   
