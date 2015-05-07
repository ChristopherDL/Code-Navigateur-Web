using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Historique : Form
    {
        public Historique()
        {
            InitializeComponent();
        }

        private void ListeHistorique_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (ListeHistorique.SelectedIndex != null)
            {
                ListeHistorique.Items.RemoveAt(ListeHistorique.SelectedIndex);
            }
        }

        private void SupprimerTout_Click(object sender, EventArgs e)
        {
            ListeHistorique.Items.Clear();
        }

    }
}
