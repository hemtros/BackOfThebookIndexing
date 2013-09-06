using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.ComponentModel;


namespace BackOfTheBookIndexing
{
  
   sealed class IndexDocumentGenerator
   {
       

      public List<UniqueWords> wordstoprint { get; set; }

     


     
       

       public void Generate(string fn)
        {

           //MessageBox.Show(fn);
            
            //List<UniqueWords> wordstoiterate = new List<UniqueWords>(wordstoprint);
            //sorting words of list in alphabetical order
           
            


            wordstoprint.Sort((x, y) => string.Compare(x.Term, y.Term));
            
            List<string> lines = new List<string>();
            lines.Add("<html>");
            lines.Add("<head>");
            lines.Add("<style>");
            lines.Add(".divleft{width:50%;float:left;}");
            lines.Add(".divright{width:50%;float:right;}");

            lines.Add("</style>");
            lines.Add("</head>");
            lines.Add("<body>");

            int n = wordstoprint.Count;
           // int incr = (n/2) - 1;
            int count = 0;
            while (count<n)
            {
                lines.Add("<hr />");
                lines.Add("<div class=\"divleft\">");
                
                int end = count + 25;

                
                for (; count <= end;count++ )
                {



                    try
                    {
                        lines.Add(wordstoprint[count].Term);
                    }
                    catch (ArgumentOutOfRangeException aore)
                    {

                        break;
                    }
                        int[] pagenos = wordstoprint[count].PagenoWithFrequency.Keys.ToArray();
                        List<int> pagenostosort = new List<int>();

                        foreach (var pno in pagenos)
                        {

                            pagenostosort.Add(pno);

                        }

                        //sorting page nos
                        pagenostosort.Sort();

                        foreach (var i in pagenostosort)
                        {
                            lines.Add("(" + i.ToString() + ")" + "&nbsp");
                        }

                     

                   
                    lines.Add("<br />");
                }
                lines.Add("</div>");



                lines.Add("<div class=\"divright\">");

                int end1 = count + 25;
                for (; count <= end1; count++)
                {

                    try
                    {
                        lines.Add(wordstoprint[count].Term);
                    }
                    catch (ArgumentOutOfRangeException aore)
                    {

                        break;
                    }

                    int[] pagenos = wordstoprint[count].PagenoWithFrequency.Keys.ToArray();
                    List<int> pagenostosort = new List<int>();

                    foreach (var pno in pagenos)
                    {

                        pagenostosort.Add(pno);

                    }

                    //sorting page nos
                    pagenostosort.Sort();

                    foreach (var i in pagenostosort)
                    {
                        lines.Add("(" + i.ToString() + ")" + "&nbsp");
                    }




                    lines.Add("<br />");
                   
                }
                lines.Add("</div>");
                
            }

           
            lines.Add("</body>");
            lines.Add("</html>");
           // File.Create("F:\\myfile.html");




            if (File.Exists(fn))
            {
                {
                    File.Delete(fn);
                }

                foreach (var line in lines)
                {
                   
                    File.AppendAllText(fn, line);
                }


            }

            else
            {
                foreach (var line in lines)
                {
                   
                    File.AppendAllText(fn, line);
                }
                
            }



        }
    }

   
}
