using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra.Double.Factorization;
using MathNet.Numerics.LinearAlgebra.Generic;

namespace BackOfTheBookIndexing
{
    class MatrixProcessor
    {
        private DenseMatrix tfidfDocMatrix;

        public void GenerateMatrix(List<UniqueWords> UniqueWordList)
        {
            double sum = 0;
            tfidfDocMatrix = new DenseMatrix(UniqueWordList.Count, DocumentInfo.TotalPages);
            //builds tf-idf document matrix
            for (int i = 0; i < UniqueWordList.Count; i++)
            {
                for (int j = 0; j < DocumentInfo.TotalPages; j++)
                {
                    if (UniqueWordList[i].PagenoWithFrequency.ContainsKey(j + 1))      //insert into matrix only if the key is present in the dictionary or else 0 is already initialised
                    {
                        int tf = UniqueWordList[i].PagenoWithFrequency[j + 1];

                        //calculating IDF
                        double idf = Math.Log10(Convert.ToDouble(DocumentInfo.TotalPages) / UniqueWordList[i].DocFrequency);
                        tfidfDocMatrix[i, j] = tf * idf;
                        //tfidfDocMatrix[i, j] = tfidfDocMatrix[i, j]/_eachPageWordCount[j];  //normalised TF.IDF matrix
                        tfidfDocMatrix[i, j] = Math.Round(tfidfDocMatrix[i, j], 2);

                    }

                }

            }


  //          WordnFrequencyTxtBox.AppendText(tfidfDocMatrix.ToMatrixString(UniqueWordList.Count, DocumentInfo.TotalPages));
            //for(int i=0;i<UniqueWordList.Count;i++)
            //{
            //    for (int j = 3; j < 4; j++)
            //    {
            //        sum += tfidfDocMatrix[i, j];
            //    }
            //}

            //WordnFrequencyTxtBox.AppendText(sum.ToString());
            // DenseMatrix dm=new DenseMatrix(tfidfDocMatrix);
            // Svd svd=new DenseSvd(dm,true);


            Svd svd = new DenseSvd(tfidfDocMatrix, true);
            //Matrix<double> s = svd.W();
            //Matrix<double> t = svd.U();
            //Matrix<double> d = svd.VT();
            //Matrix<double> tsd = t*s*d;
            //WordnFrequencyTxtBox.AppendText("\n" + "\n" + tfidfDocMatrix.ToString());
            //WordnFrequencyTxtBox.AppendText("\n"+"\n"+tsd.ToString());
            // WordnFrequencyTxtBox.AppendText("\n" + "\n" +s.ToString());



            Matrix<double> f = svd.U();

            Matrix<double> s = svd.W();

            Matrix<double> t = svd.VT();
            Matrix<double> tc1 = t.Column(0).ToColumnMatrix();
            Matrix<double> tc2 = t.Column(1).ToColumnMatrix();
            //tc1.SetSubMatrix(); 

            Matrix<double> rorigi = f * s * t;
            // WordnFrequencyTxtBox.Clear();
            for (int i = 0; i < rorigi.RowCount; i++)
            {
                for (int j = 0; j < rorigi.ColumnCount; j++)
                {
                    int r;
                    if (rorigi[i, j].ToString().Contains("E"))      //insert into matrix only if the key is present in the dictionary or else 0 is already initialised
                    {

                        rorigi[i, j] = 0;


                    }

                }

            }
 //           WordnFrequencyTxtBox.AppendText("\n" + rorigi.ToString());
 //           WordnFrequencyTxtBox.AppendText("\n" + tfidfDocMatrix.ToString());
        }
    }
}
