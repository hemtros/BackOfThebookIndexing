using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace BackOfTheBookIndexing
{
    public partial class UserWordsEditor : KryptonForm
    {
        private BindingList<UniqueWords> _uniquewordlist;
        private BindingList<UniqueWords> _selectedwords;
        private BindingList<UniqueWords> _finalwords;
        private string fn;


        public UserWordsEditor(List<UniqueWords> uniqueWordses)
        {
            InitializeComponent();
            _uniquewordlist=new BindingList<UniqueWords>(uniqueWordses);
            _selectedwords=new BindingList<UniqueWords>();
            _finalwords=new BindingList<UniqueWords>();

            MGWListbox.DataSource = _uniquewordlist;
            UFWListbox.DataSource = _selectedwords;
            
            MGWListbox.DisplayMember = "Term";

            UFWListbox.DisplayMember = "Term";
            FGWListbox.DisplayMember = "Term";


            // MGWListbox.ValueMember = "Term";
            //foreach (uniquewords u in uniquewordses)
            //{
            //    mgwlistbox.items.add(u.term);
            //}



        }

       

        private void DeleteWordBtn_Click_1(object sender, EventArgs e)
        {


           // MessageBox.Show(MGWListbox.SelectedItem.ToString());
            
            UniqueWords temp = (UniqueWords) MGWListbox.SelectedItem;
            bool containsItem = _selectedwords.Any(x => x.Term == temp.Term);
            //MessageBox.Show(containsItem.ToString());
            if (!containsItem)
                _selectedwords.Add((UniqueWords)MGWListbox.SelectedItem);

            try
            {
                MGWListbox.SelectedIndex = MGWListbox.SelectedIndex + 1;
            }

            catch(ArgumentOutOfRangeException aore)
            {
                return;
            }




        }

        private void UnDeleteWordBtn_Click(object sender, EventArgs e)
        {
            _selectedwords.Remove((UniqueWords)UFWListbox.SelectedItem);
        }

        private void AfterDeleteListWordBtn_Click(object sender, EventArgs e)
        {
            List<UniqueWords> selected = new List<UniqueWords>(_selectedwords);
            List<UniqueWords> unique = new List<UniqueWords>(_uniquewordlist);
            unique.RemoveAll(m => selected.Contains(m));

            _finalwords = new BindingList<UniqueWords>(unique);
            FGWListbox.DataSource = _finalwords;
             
        }


       
        
        
        
        private void UWEProceedBtn_Click(object sender, EventArgs e)
        {
           
                FileDialog fd=new SaveFileDialog();
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

        void bg_DoWork(object sender, DoWorkEventArgs e)
        {
            var idg = new IndexDocumentGenerator();
            idg.wordstoprint = new List<UniqueWords>(_finalwords);
            idg.Generate(fn);
        }


    }


}
