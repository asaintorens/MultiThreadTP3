using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadTP3
{
    public class ManagerListe
    {
        public  int NOMBRE_DE_RANDOM;
        private System.Windows.Forms.ListView listViewNonTrier;
        private System.Windows.Forms.ListView listViewTrier;
        private int[] tableauNonTrier;
        public int[] tableauTrier;
        public int progression;
        public bool Cancel;
    
        public ManagerListe(System.Windows.Forms.ListView listViewNonTrier, System.Windows.Forms.ListView listViewTrier)
        {
            // TODO: Complete member initialization
            this.listViewNonTrier = listViewNonTrier;
            this.listViewTrier = listViewTrier;
            this.NOMBRE_DE_RANDOM=0;
            this.progression = 0;
            this.Cancel = false;
        }


        public void ValoriserListeNonTrier(int nombreEntree)
        {
            this.listViewNonTrier.Items.Clear();
            this.NOMBRE_DE_RANDOM = nombreEntree;
            Random rand = new Random();
            this.tableauNonTrier= new int [NOMBRE_DE_RANDOM];
            for (int compteurNombre = 0; compteurNombre < NOMBRE_DE_RANDOM; compteurNombre++)
            {
                this.tableauNonTrier[compteurNombre] = rand.Next(NOMBRE_DE_RANDOM);
            }

            for (int compteurNombre = 0; compteurNombre < this.tableauNonTrier.Length - 1; compteurNombre++)
            {
                this.listViewNonTrier.Items.Add(this.tableauNonTrier[compteurNombre].ToString());
            }

        }



        public void AfficherProgressBar()
        {
            FormProgression formProgressBar = new FormProgression(this);
            formProgressBar.Show();
        }

        public void TrierListe(BackgroundWorker backgroundWorker)
        {
            
            int i, iRech, iMin;
            int N = this.tableauNonTrier.Length - 1;
             this.progression = 0;
            int tmp;

            for (i = 0; i < N; i++)
            {
                if (backgroundWorker.CancellationPending)
                {
                    this.Cancel = true;
                    break;
                }
                    for (iRech = iMin = i; iRech < N; iRech++)
                    if (this.tableauNonTrier[iRech] < this.tableauNonTrier[iMin])
                        iMin = iRech;

                if (iMin != i)
                {

                    tmp = this.tableauNonTrier[iMin];

                    this.tableauNonTrier[iMin] = this.tableauNonTrier[i];

                    this.tableauNonTrier[i] = tmp;

                }

                try
                {

                    double report = (i *100) / N;
                    double round = Math.Round(report);
                    this.progression = (int)round;
                }
                catch (Exception)
                {

                     this.progression  = 0;
                }
                backgroundWorker.ReportProgress(this.progression);



            }

           
        }

        public void ValoriserListeTrier()
        {
            for (int compteurNombre = 0; compteurNombre < this.tableauNonTrier.Length - 1; compteurNombre++)
            {
                this.listViewTrier.Items.Add(this.tableauNonTrier[compteurNombre].ToString());
            }
        }







      
    }
}
