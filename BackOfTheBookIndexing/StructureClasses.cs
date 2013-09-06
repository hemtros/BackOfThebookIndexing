using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackOfTheBookIndexing
{
    sealed class Words
    {
        public string Word { get; set; }
        public int TermFrequency { get; set; }
        public int Pageno { get; set; }
        public int CorpusFrequency { get; set; }
        public Dictionary<int, int> SentencenoWithFrequency { get; set; }

    }

    public sealed class UniqueWords
    {
        public string Term { get; set; }
        public Dictionary<int, int> PagenoWithFrequency { get; set; }              //stores the term frequency
        public int CorpusFrequency { get; set; }
        public Dictionary<int, int> SentencenoWithFrequency { get; set; }
        public int DocFrequency { get; set; }   //number of documents in the corpus that contains the term t
       
               
    }

    sealed class Sentences
    {
        public int SentenceNumber { get; set; }
        public string SentenceString { get; set; }
    }
}
