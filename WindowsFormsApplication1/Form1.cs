using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DevComponents.DotNetBar;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Globalization;





namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        private Historique fm_Historique;
        private Favoris fm_Favoris;


#region Public Main
        public Main()
        {
            InitializeComponent();

            fm_Historique = new Historique();
            fm_Favoris = new Favoris();

//Initialisation du menu Haut
            PanelHaut.Dock = DockStyle.Left;
            PanelHaut.Visible = true;
            PanelHaut.Width = 5;
            PanelHaut.BackColor = Color.Black;

//Initialisation du menu Bas
            PanelBas.Dock = DockStyle.Bottom;
            PanelBas.Visible = true;
            PanelBas.Height = 5;
            PanelBas.BackColor = Color.Black;
        }
#endregion



#region WebBrowser (browser)
        WebBrowser browser = new WebBrowser();
        int i = 0;
#endregion


#region Form1 Load
        private void Form1_Load(object sender, EventArgs e)
        {
            browser = new WebBrowser();
            browser.ScriptErrorsSuppressed = true;
            browser.Dock = DockStyle.Fill;
            browser.Visible = true;
            browser.Navigate("http://www.Bing.fr");

            //superTabControl1.Tabs.Add("Nouvel Onglet");
        }
#endregion


#region Onglet
        // Initialisation du menu des onglets

        private void NouvelOnglet()
        {
            SuperTabItem newTab = new SuperTabItem();
            superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] { newTab });
            

            //superTabControl1.CreateTab("Nouvel Onglet");
            browser.Dock = DockStyle.Fill;
            browser.Url = new Uri("http://www.google.com");
            superTabControl1.Controls.Add(browser);    
        }

        // Ajouter Un Onglet à partir du bouton (+)
        private void AjouterOnglet_Click(object sender, EventArgs e)
        {
            NouvelOnglet();
        }

        // Ajouter Onglet à partir du Bouton Onglet
        private void IconeAjouterOnglet_Click(object sender, EventArgs e)
        {
            NouvelOnglet();
        }

        // Suprimer l'Onglet à partir du Bouton (-)
        private void SupprimerOnglet_Click(object sender, EventArgs e)
        {
            if (superTabControl1.Tabs.Count - 1 > 0)
            {
                superTabControl1.Tabs.RemoveAt(superTabControl1.SelectedTabIndex);
                i -= 1;
            }
        }
#endregion


#region Barre de Recherche 1

        private void Recherche_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(BarreRecherche.Text);
            BarreRecherche.Items.Add(BarreRecherche.Text);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            BarreRecherche.Text = webBrowser1.Url.AbsoluteUri;
        }

        private void BarreRecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            BarreRecherche.Text = webBrowser1.Url.AbsoluteUri;
        }

        // Activer la touche Entrer dans la barre de recherche du navigateur internet 
        private void BarreRecherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(BarreRecherche.Text);
                BarreRecherche.Text = "";
                BarreRecherche.Text = webBrowser1.Url.AbsoluteUri;
                BarreRecherche.Items.Add(BarreRecherche.Text);
            }
        }
#endregion


#region Barre de Recherche 2

        private void BarreRecherche2_Click(object sender, EventArgs e)
        {
            // webBrowser1.Navigate(BarreRecherche2.Text);
        }

        private void Recherche2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.fr/#q=" + (BarreRecherche2.Text));
        }

        // Activer la touche Entrer dans la barre de recherche du navigateur internet 
        private void BarreRecherche2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(("https://www.google.fr/#q=" + BarreRecherche2.Text));
                BarreRecherche2.Text = "";
            }
        }
#endregion


#region Icone Navigateur
        private void Precedent_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Suivant_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void Rafraichir_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void Accueil_Click(object sender, EventArgs e)
        {
            navigerVers("http://www.msn.com");
        }

        private void Google_Click_1(object sender, EventArgs e)
        {
            navigerVers("http://www.google.com");
        }

        private void Youtube_Click(object sender, EventArgs e)
        {
            navigerVers("http://www.youtube.com");
        }

        private void Facebook_Click(object sender, EventArgs e)
        {
            navigerVers("http://www.facebook.com");
        }

        private void Twitter_Click(object sender, EventArgs e)
        {
            navigerVers("http://www.twitter.com");
        }

        private void Devlog_Click(object sender, EventArgs e)
        {
            navigerVers("http://devlog.amorce.org/");
        }
#endregion


#region Label
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
// LABEL
            label1.Text = webBrowser1.Document.Url.AbsoluteUri;
            //label1.Visible = true;
        }
#endregion


#region Barre de Progression
        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            BarreProgression.Minimum = 0;
            BarreProgression.Maximum = (int)e.MaximumProgress;
            if ((int)e.CurrentProgress >= 0)
            {
                BarreProgression.Visible = true;
                label1.Visible = true;
                BarreProgression.Value = (int)e.CurrentProgress;
            }

            if ((int)e.CurrentProgress <= 0)
            {
                BarreProgression.Visible = false;
                label1.Visible = false;
            }
        }
#endregion


#region NaviguerVers
        private void navigerVers(string url)
        {
            int index = fm_Historique.ListeHistorique.FindString(url);
            //MessageBox.Show(index.ToString());

            if (index >= 0)
            {
                fm_Historique.ListeHistorique.Items.Remove(url);
            }
            webBrowser1.Navigate(url);
            BarreRecherche.Items.Add(url);
            fm_Historique.ListeHistorique.Items.Add(url);
        }
#endregion


#region Historique
        private void Historique_Click(object sender, EventArgs e)
        {
            fm_Historique.ShowDialog();
        }
#endregion


#region Favoris
        private void Favoris_Click(object sender, EventArgs e)
        {
            fm_Favoris.ShowDialog();
        }
        
        private void AjouterFavoris_Click(object sender, EventArgs e)
        {
       // TODO A CHANGER
            fm_Favoris.ListeFavoris.Items.Add(BarreRecherche.Text);
        }
#endregion


#region Gestion Apparition Panel Haut
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.PanelHaut.Size.Width >= 180) this.timer1.Enabled = false;
            else this.PanelHaut.Width += 40;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.PanelHaut.Size.Width <= 5) this.timer2.Enabled = false;
            else this.PanelHaut.Width -= 40;
        }

        private void PanelHaut_MouseHover(object sender, EventArgs e)
        {
            this.timer2.Enabled = false;
            this.timer1.Enabled = true;
            PanelHaut.BackColor = Color.Brown;
        }

        private void PanelHaut_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X >= 180)
            {
                this.timer1.Enabled = false;
                this.timer2.Enabled = true;
                PanelHaut.BackColor = Color.Black;
            }
        }
#endregion


#region  Gestion Apparition Panel du Bas
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (this.PanelBas.Size.Height >= 80) this.timer3.Enabled = false;
            else this.PanelBas.Height += 20;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (this.PanelBas.Size.Height <= 5) this.timer4.Enabled = false;
            else this.PanelBas.Height -= 20;
        }

        private void PanelBas_MouseHover(object sender, EventArgs e)
        {
            this.timer4.Enabled = false;
            this.timer3.Enabled = true;
            PanelBas.BackColor = Color.Brown;
        }

        private void PanelBas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y >= 80)
            {
                this.timer3.Enabled = false;
                this.timer4.Enabled = true;
                PanelBas.BackColor = Color.Black;
            }
        }
#endregion


#region Code Source
        private void button1_Click(object sender, EventArgs e)
        {
            string source = ("source.txt");
            StreamWriter writer = File.CreateText(source);
            writer.Write(webBrowser1.DocumentText);
            //webBrowser1.DocumentText += "<h1>Christopher</h2>";
            Process.Start("C:\\Users\\CARLIER\\Documents\\Notepadpp.6.6.7.bin\\Notepad++.exe", source);
            writer.Close();
        }
#endregion

        /*private void radialMenu1_ItemClick(object sender, EventArgs e)
        {
            
        }*/

        private void FacebookMenu_Click(object sender, EventArgs e)
        {
            navigerVers("http://www.Facebook.com");
        }

        private void TwitterMenu_Click(object sender, EventArgs e)
        {
            navigerVers("Http://www.twitter.com");
        }

        private void WikipediaMenu_Click(object sender, EventArgs e)
        {
            navigerVers("https://fr.wikipedia.org/wiki/Wikip%C3%A9dia:Accueil_principal");
        }

        /*private void FacebookMenu_ItemClick(object sender, EventArgs e)
        {
           
                navigerVers("http://www.google.com");
            
        }*/




    }
}

        

