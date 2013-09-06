using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = System.Drawing.Font;
using itextfont = iTextSharp.text.Font;

namespace BackOfTheBookIndexing
{
    public sealed  partial class MainForm : KryptonForm
    {
        private string[] _wordsfromtxtfile;
        private List<UniqueWords> uniqueWordList;
        private List<UniqueWords> domain_finalwords;
        private BackgroundWorker Rn;
        private BackgroundWorker Dn;
        
        private string fn;

        public MainForm()
        {
            InitializeComponent();
            uniqueWordList = new List<UniqueWords>();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }







        private void BrowseBtn_Click(object sender, EventArgs e)
        {


            FileDialog fd = new OpenFileDialog();
            fd.Title = "Select your Document";
            fd.Filter =
                "Portable Document Format(*.pdf)|*.pdf|Word 97-2003 Document(*.doc)|*.doc|Open Document Text(*.odt)|*.odt|Microsoft word Document(*.docx)|*.docx";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                
               
                DocumentSlctTxtBox.Text = fd.FileName;

            }

        }

        private void DocumentSlctTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (DocumentSlctTxtBox.Text != string.Empty)
            {
                
                DocumentInfo.SetProperties(DocumentSlctTxtBox.Text);

                string info = "File: " + DocumentInfo.Filename + "\n" + "Document Type: " + DocumentInfo.DocumentType +
                              "\n" + "Size: "
                              + DocumentInfo.Size + " MB" + "\n" + "Total no of Pages: " + DocumentInfo.TotalPages +
                              "\n" + "Total no of Words: " +
                              DocumentInfo.NoOfWords;


                FileInfoLabel.Text = info;
                
            }

        }

        private void MachineGenerateBtn_Click(object sender, EventArgs e)
        {
            if (DocumentSlctTxtBox.Text.Length > 0)
            {
                
                
               
                Rn = new BackgroundWorker();
                Rn.WorkerSupportsCancellation = true;
                Rn.DoWork += Rn_DoWork;

                myProgressBar.Visible = true;
             
                
                Rn.RunWorkerCompleted += Rn_RunWorkerCompleted;
                Rn.RunWorkerAsync();
                




            }
            else
            {
                MessageBox.Show("Enter a valid file path");
            }
        }


        void Rn_DoWork(object sender, DoWorkEventArgs e)
        {
            
            
                DocumentProcessor dp = new DocumentProcessor();
                uniqueWordList = dp.ReadFileContent();

        }

       

        private void Rn_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            myProgressBar.Text = "Completing";
            myProgressBar.Visible = false;
       
            Rn.Dispose();
            UserWordsEditor uw = new UserWordsEditor(uniqueWordList);
            uw.Show();
        }

        private void SelectDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectDropdown.SelectedItem.ToString() == "Custom")
            {
                DomainFileSelectTxtbox.Visible = true;
                DomainFileSelectBtn.Visible = true;
            }

            else
            {
                DomainFileSelectTxtbox.Visible = false;
                DomainFileSelectBtn.Visible = false;
            }
        }

        private void FileBrowseForDomainBtn_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            fd.Title = "Select your Document";
            fd.Filter =
                "Portable Document Format(*.pdf)|*.pdf|Word 97-2003 Document(*.doc)|*.doc|Open Document Text(*.odt)|*.odt|Microsoft word Document(*.docx)|*.docx";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                FileBrowseDomainTxtbox.Text = fd.FileName;

            }
        }

        private void DomainFileSelectBtn_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            fd.Title = "Select your Text file containing Domain Words";
            fd.Filter = "Text File(*.txt)|*.txt";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                DomainFileSelectTxtbox.Text = fd.FileName;

            }

        }

        private void GenerateIndexBtn_Click(object sender, EventArgs e)   //submitbtn
        {

            if (FileBrowseDomainTxtbox.Text != String.Empty)
            {
                if (!DomainFileSelectTxtbox.Visible && (SelectDropdown.SelectedIndex != -1))
                {
                    switch (SelectDropdown.SelectedItem.ToString())
                    {
                        case "Machine Learning":
                            {
                                _wordsfromtxtfile = File.ReadAllLines("Samples/ML.txt");
                                break;
                            }

                        case "Economics":
                            {
                                _wordsfromtxtfile = File.ReadAllLines("Samples/economics.txt");
                                break;
                            }

                        case "Geography":
                            {
                                _wordsfromtxtfile = File.ReadAllLines("Samples/geography.txt");
                                break;

                            }

                        case "Psychology":
                            {
                                _wordsfromtxtfile = File.ReadAllLines("Samples/psychology.txt");
                                break;
                            }

                        case "Management":
                            {
                                _wordsfromtxtfile = File.ReadAllLines("Samples/management.txt");
                                break;

                            }

                        case "Football":
                            {
                                _wordsfromtxtfile = File.ReadAllLines("Samples/football.txt");
                                break;

                            }

                        default:
                            {
                                //a human user would never reach here
                                break;
                            }
                           
                    }
                }

                else
                {
                    if (DomainFileSelectTxtbox.Text != String.Empty)
                    {
                        _wordsfromtxtfile = File.ReadAllLines(DomainFileSelectTxtbox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Select Your custom domain file or select one of the preloaded Domain");
                        return;
                    }

                }
                // input file lai uniquewordlist conversion gara

                Dn=new BackgroundWorker();
                Dn.DoWork += Dn_DoWork;
                Dn.RunWorkerCompleted += Dn_RunWorkerCompleted;
                Dn.RunWorkerAsync();
                myProgressBarDomain.Visible = true;

            }

            else
            {
                MessageBox.Show("Select Document");
            }


        }

        void Dn_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            domain_finalwords = new List<UniqueWords>();


            foreach (string w in _wordsfromtxtfile)
            {
                domain_finalwords.AddRange((uniqueWordList.FindAll(x => x.Term == w)));
            }


            myProgressBarDomain.Visible = false;    //setting progressbar invisible

            FileDialog fd = new SaveFileDialog();
            fd.Title = "Save your index";
            fd.Filter = "HTML(*.html)|*.html";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                fn = fd.FileName;
                var bg = new BackgroundWorker();
                bg.DoWork += bg_DoWork;
                bg.RunWorkerCompleted += bg_RunWorkerCompleted;
                bg.RunWorkerAsync();


            }

        }

        void bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            System.Diagnostics.Process.Start(fn);
        }


        //Dowork of Domain tab uniquewordlist generation
        void Dn_DoWork(object sender, DoWorkEventArgs e)
        {
            var dp = new DocumentProcessor();

            uniqueWordList = dp.ReadFileContent();
        }

        //Dowork of index generation
        void bg_DoWork(object sender, DoWorkEventArgs e)
        {
            var idg = new IndexDocumentGenerator();
            idg.wordstoprint = domain_finalwords;
            idg.Generate(fn);
            
        }


        

        private void FileBrowseDomainTxtbox_TextChanged(object sender, EventArgs e)
        {

            DocumentInfo.SetProperties(FileBrowseDomainTxtbox.Text);

            string info = "File: " + DocumentInfo.Filename + "\n" + "Document Type: " + DocumentInfo.DocumentType +
                           "\n" + "Size: "
                           + DocumentInfo.Size + " MB" + "\n" + "Total no of Pages: " + DocumentInfo.TotalPages +
                           "\n" + "Total no of Words: " +
                           DocumentInfo.NoOfWords;

            FileInfoLabelDomain.Text = info;

        }

        

       
          
           
       

       

        private void myLinkLabel_LinkClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(myLinkLabel.Text);
        }

        private void office10BlueChbox_CheckedChanged(object sender, EventArgs e)
        {
            if(office10BlueChbox.Checked)
            {
                office10SilverChbox.Checked = false;
                office10BlackChbox.Checked = false;
                office07BlackChbox.Checked = false;
                office07SilverChbox.Checked = false;
                sparkleBlueChbox.Checked = false;
                myKryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
            }
        }

        private void office10SilverChbox_CheckedChanged(object sender, EventArgs e)
        {
            if(office10SilverChbox.Checked)
            {
                office10BlueChbox.Checked = false;
                office10BlackChbox.Checked = false;
                office07BlackChbox.Checked = false;
                office07SilverChbox.Checked = false;
                sparkleBlueChbox.Checked = false;
                myKryptonManager.GlobalPaletteMode=PaletteModeManager.Office2010Silver;
            }

           
        }

        private void office10BlackChbox_CheckedChanged(object sender, EventArgs e)
        {
            if(office10BlackChbox.Checked)
            {
                office10SilverChbox.Checked = false;
                office10BlueChbox.Checked = false;
                office07BlackChbox.Checked = false;
                office07SilverChbox.Checked = false;
                sparkleBlueChbox.Checked = false;
                myKryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
                
            }

            


        }

        private void office07SilverChbox_CheckedChanged(object sender, EventArgs e)
        {
            if(office07SilverChbox.Checked)
            {
                office10SilverChbox.Checked = false;
                office10BlackChbox.Checked = false;
                office07BlackChbox.Checked = false;
                office10BlueChbox.Checked = false;
                sparkleBlueChbox.Checked = false;
                myKryptonManager.GlobalPaletteMode=PaletteModeManager.Office2007Silver;
            }
        }

        private void office07BlackChbox_CheckedChanged(object sender, EventArgs e)
        {
            if(office07BlackChbox.Checked)
            {
                office10SilverChbox.Checked = false;
                office10BlackChbox.Checked = false;
                office10BlueChbox.Checked = false;
                office07SilverChbox.Checked = false;
                sparkleBlueChbox.Checked = false;
                myKryptonManager.GlobalPaletteMode=PaletteModeManager.Office2007Black;
            }

        }

        private void sparkleBlueChbox_CheckedChanged(object sender, EventArgs e)
        {
            if(sparkleBlueChbox.Checked)
            {
                office10SilverChbox.Checked = false;
                office10BlackChbox.Checked = false;
                office07BlackChbox.Checked = false;
                office07SilverChbox.Checked = false;
                office10BlueChbox.Checked = false;
                myKryptonManager.GlobalPaletteMode=PaletteModeManager.SparkleBlue;
            }
        }

       

    }


}
    
      

        
    
        
        

       

       

        

        

        


