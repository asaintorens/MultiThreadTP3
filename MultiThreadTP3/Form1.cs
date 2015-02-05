using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadTP3
{
    public partial class Form1 : Form
    {
        private ManagerListe managerListe;
        public Form1()
        {
            InitializeComponent();
            this.managerListe = new ManagerListe(this.listViewNonTrier,this.listViewTrier);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void buttonValoriser_Click(object sender, EventArgs e)
        {
            this.managerListe.ValoriserListeNonTrier(int.Parse(this.textBox1.Text));
        }

        private void buttonTrier_Click(object sender, EventArgs e)
        {
            this.managerListe.AfficherProgressBar();
        }
    }
}
