using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadTP3
{
    public partial class FormProgression : Form
    {
        private ManagerListe managerListe;


        public FormProgression(ManagerListe managerListe)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.managerListe = managerListe;
        }

        private void FormProgression_Load(object sender, EventArgs e)
        {
            this.backgroundWorkerTrie.RunWorkerAsync();
        }

        private void backgroundWorkerTrie_DoWork(object sender, DoWorkEventArgs e)
        {
            
             this.managerListe.TrierListe(this.backgroundWorkerTrie);
             if (this.managerListe.Cancel)
                 e.Cancel = true;
            // e.Cancel = false;

        }

        private void backgroundWorkerTrie_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorkerTrie_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
         if(e.Cancelled)
         {
             MessageBox.Show("Cancelled.");
             this.buttonOk.Enabled = true;
         }
         else
         {
             this.progressBar1.Value = 100;
             this.buttonOk.Enabled = true;
         }
         this.managerListe.ValoriserListeTrier();
         
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            
            this.backgroundWorkerTrie.CancelAsync();
            
           
        }
    }
}
