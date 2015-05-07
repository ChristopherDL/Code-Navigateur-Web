namespace WindowsFormsApplication1
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.PanelHaut = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SupprimerOnglet = new System.Windows.Forms.Button();
            this.AjouterOnglet = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.BarreProgression = new System.Windows.Forms.ProgressBar();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Devlog = new System.Windows.Forms.Button();
            this.Google = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.PanelBas = new System.Windows.Forms.Panel();
            this.radialMenu1 = new DevComponents.DotNetBar.RadialMenu();
            this.FacebookMenu = new DevComponents.DotNetBar.RadialMenuItem();
            this.WikipediaMenu = new DevComponents.DotNetBar.RadialMenuItem();
            this.Facebook2 = new DevComponents.DotNetBar.RadialMenuItem();
            this.TwitterMenu = new DevComponents.DotNetBar.RadialMenuItem();
            this.button13 = new System.Windows.Forms.Button();
            this.BarreRecherche = new System.Windows.Forms.ComboBox();
            this.BarreRecherche2 = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.OngletRecherche = new DevComponents.DotNetBar.SuperTabItem();
            this.OngletHistorique = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.OngletFavoris = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.IconeAjouterOnglet = new DevComponents.DotNetBar.ButtonItem();
            this.PanelHaut.SuspendLayout();
            this.PanelBas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Favoris1.png");
            this.imageList1.Images.SetKeyName(1, "History1.png");
            this.imageList1.Images.SetKeyName(2, "Google1.jpg");
            this.imageList1.Images.SetKeyName(3, "Ajouter1.jpg");
            this.imageList1.Images.SetKeyName(4, "Navigateur1.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(679, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // PanelHaut
            // 
            this.PanelHaut.Controls.Add(this.button1);
            this.PanelHaut.Controls.Add(this.SupprimerOnglet);
            this.PanelHaut.Controls.Add(this.AjouterOnglet);
            this.PanelHaut.Controls.Add(this.button12);
            this.PanelHaut.Controls.Add(this.button11);
            this.PanelHaut.Controls.Add(this.button10);
            this.PanelHaut.Controls.Add(this.BarreProgression);
            this.PanelHaut.Controls.Add(this.button9);
            this.PanelHaut.Controls.Add(this.button8);
            this.PanelHaut.Controls.Add(this.button7);
            this.PanelHaut.Controls.Add(this.button6);
            this.PanelHaut.Controls.Add(this.button5);
            this.PanelHaut.Controls.Add(this.button4);
            this.PanelHaut.Controls.Add(this.button3);
            this.PanelHaut.Controls.Add(this.Devlog);
            this.PanelHaut.Controls.Add(this.Google);
            this.PanelHaut.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelHaut.Location = new System.Drawing.Point(0, 0);
            this.PanelHaut.Name = "PanelHaut";
            this.PanelHaut.Size = new System.Drawing.Size(172, 532);
            this.PanelHaut.TabIndex = 1;
            this.PanelHaut.MouseHover += new System.EventHandler(this.PanelHaut_MouseHover);
            this.PanelHaut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHaut_MouseMove);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SupprimerOnglet
            // 
            this.SupprimerOnglet.Image = ((System.Drawing.Image)(resources.GetObject("SupprimerOnglet.Image")));
            this.SupprimerOnglet.Location = new System.Drawing.Point(54, 357);
            this.SupprimerOnglet.Name = "SupprimerOnglet";
            this.SupprimerOnglet.Size = new System.Drawing.Size(35, 35);
            this.SupprimerOnglet.TabIndex = 17;
            this.SupprimerOnglet.UseVisualStyleBackColor = true;
            this.SupprimerOnglet.Click += new System.EventHandler(this.SupprimerOnglet_Click);
            // 
            // AjouterOnglet
            // 
            this.AjouterOnglet.Image = ((System.Drawing.Image)(resources.GetObject("AjouterOnglet.Image")));
            this.AjouterOnglet.Location = new System.Drawing.Point(13, 357);
            this.AjouterOnglet.Name = "AjouterOnglet";
            this.AjouterOnglet.Size = new System.Drawing.Size(35, 35);
            this.AjouterOnglet.TabIndex = 16;
            this.AjouterOnglet.UseVisualStyleBackColor = true;
            this.AjouterOnglet.Click += new System.EventHandler(this.AjouterOnglet_Click);
            // 
            // button12
            // 
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.Location = new System.Drawing.Point(54, 280);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(35, 35);
            this.button12.TabIndex = 11;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.AjouterFavoris_Click);
            // 
            // button11
            // 
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(13, 280);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(35, 35);
            this.button11.TabIndex = 10;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Accueil_Click);
            // 
            // button10
            // 
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(95, 191);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(35, 35);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Rafraichir_Click);
            // 
            // BarreProgression
            // 
            this.BarreProgression.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BarreProgression.Location = new System.Drawing.Point(30, 437);
            this.BarreProgression.Name = "BarreProgression";
            this.BarreProgression.Size = new System.Drawing.Size(100, 13);
            this.BarreProgression.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(54, 191);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(35, 35);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Suivant_Click);
            // 
            // button8
            // 
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(13, 191);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 35);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Precedent_Click);
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(54, 129);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 35);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Historique_Click);
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(13, 129);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 35);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Favoris_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(54, 53);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 35);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Twitter_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(95, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Facebook_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(54, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Youtube_Click);
            // 
            // Devlog
            // 
            this.Devlog.Image = ((System.Drawing.Image)(resources.GetObject("Devlog.Image")));
            this.Devlog.Location = new System.Drawing.Point(13, 53);
            this.Devlog.Name = "Devlog";
            this.Devlog.Size = new System.Drawing.Size(35, 35);
            this.Devlog.TabIndex = 1;
            this.Devlog.UseVisualStyleBackColor = true;
            this.Devlog.Click += new System.EventHandler(this.Devlog_Click);
            // 
            // Google
            // 
            this.Google.Image = ((System.Drawing.Image)(resources.GetObject("Google.Image")));
            this.Google.Location = new System.Drawing.Point(13, 12);
            this.Google.Name = "Google";
            this.Google.Size = new System.Drawing.Size(35, 35);
            this.Google.TabIndex = 0;
            this.Google.UseVisualStyleBackColor = true;
            this.Google.Click += new System.EventHandler(this.Google_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // PanelBas
            // 
            this.PanelBas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelBas.Controls.Add(this.radialMenu1);
            this.PanelBas.Controls.Add(this.button13);
            this.PanelBas.Controls.Add(this.BarreRecherche);
            this.PanelBas.Controls.Add(this.label1);
            this.PanelBas.Controls.Add(this.BarreRecherche2);
            this.PanelBas.Controls.Add(this.button14);
            this.PanelBas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBas.Location = new System.Drawing.Point(0, 532);
            this.PanelBas.Name = "PanelBas";
            this.PanelBas.Size = new System.Drawing.Size(1030, 78);
            this.PanelBas.TabIndex = 24;
            this.PanelBas.MouseHover += new System.EventHandler(this.PanelBas_MouseHover);
            this.PanelBas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelBas_MouseMove);
            // 
            // radialMenu1
            // 
            this.radialMenu1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.FacebookMenu,
            this.TwitterMenu});
            this.radialMenu1.Location = new System.Drawing.Point(813, 21);
            this.radialMenu1.Name = "radialMenu1";
            this.radialMenu1.Size = new System.Drawing.Size(28, 28);
            this.radialMenu1.Symbol = "";
            this.radialMenu1.SymbolSize = 10F;
            this.radialMenu1.TabIndex = 24;
            this.radialMenu1.Text = "radialMenu1";
            // 
            // FacebookMenu
            // 
            this.FacebookMenu.Name = "FacebookMenu";
            this.FacebookMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.WikipediaMenu,
            this.Facebook2});
            this.FacebookMenu.Text = "Facebook";
            this.FacebookMenu.Click += new System.EventHandler(this.FacebookMenu_Click);
            // 
            // WikipediaMenu
            // 
            this.WikipediaMenu.Name = "WikipediaMenu";
            this.WikipediaMenu.Text = "Wiki";
            this.WikipediaMenu.Click += new System.EventHandler(this.WikipediaMenu_Click);
            // 
            // Facebook2
            // 
            this.Facebook2.Name = "Facebook2";
            this.Facebook2.Text = "Facebook2";
            // 
            // TwitterMenu
            // 
            this.TwitterMenu.Name = "TwitterMenu";
            this.TwitterMenu.Text = "Twitter";
            this.TwitterMenu.Click += new System.EventHandler(this.TwitterMenu_Click);
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.Location = new System.Drawing.Point(176, 21);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(35, 35);
            this.button13.TabIndex = 12;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Recherche_Click);
            // 
            // BarreRecherche
            // 
            this.BarreRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BarreRecherche.FormattingEnabled = true;
            this.BarreRecherche.Location = new System.Drawing.Point(16, 29);
            this.BarreRecherche.Name = "BarreRecherche";
            this.BarreRecherche.Size = new System.Drawing.Size(154, 21);
            this.BarreRecherche.TabIndex = 14;
            this.BarreRecherche.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarreRecherche_KeyDown);
            // 
            // BarreRecherche2
            // 
            this.BarreRecherche2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BarreRecherche2.Location = new System.Drawing.Point(314, 30);
            this.BarreRecherche2.Name = "BarreRecherche2";
            this.BarreRecherche2.Size = new System.Drawing.Size(153, 20);
            this.BarreRecherche2.TabIndex = 15;
            this.BarreRecherche2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarreRecherche2_KeyDown);
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.Location = new System.Drawing.Point(473, 21);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(35, 35);
            this.button14.TabIndex = 13;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Recherche2_Click);
            // 
            // superTabControl1
            // 
            this.superTabControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.superTabControl1.CloseButtonOnTabsVisible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Controls.Add(this.OngletHistorique);
            this.superTabControl1.Controls.Add(this.OngletFavoris);
            this.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl1.ImageList = this.imageList1;
            this.superTabControl1.Location = new System.Drawing.Point(172, 0);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(858, 532);
            this.superTabControl1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl1.TabIndex = 1;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.OngletRecherche,
            this.superTabItem1,
            this.superTabItem2,
            this.IconeAjouterOnglet});
            this.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.OfficeMobile2014;
            this.superTabControl1.TabVerticalSpacing = 2;
            this.superTabControl1.Text = "superTabControl1";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.webBrowser1);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 31);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(858, 501);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.OngletRecherche;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(858, 501);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // OngletRecherche
            // 
            this.OngletRecherche.AttachedControl = this.superTabControlPanel2;
            this.OngletRecherche.CloseButtonVisible = false;
            this.OngletRecherche.GlobalItem = false;
            this.OngletRecherche.ImageIndex = 2;
            this.OngletRecherche.Name = "OngletRecherche";
            this.OngletRecherche.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.OfficeMobile2014Blue;
            this.OngletRecherche.Text = "Google";
            // 
            // OngletHistorique
            // 
            this.OngletHistorique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OngletHistorique.Location = new System.Drawing.Point(0, 31);
            this.OngletHistorique.Name = "OngletHistorique";
            this.OngletHistorique.Size = new System.Drawing.Size(858, 501);
            this.OngletHistorique.TabIndex = 0;
            this.OngletHistorique.TabItem = this.superTabItem2;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.OngletHistorique;
            this.superTabItem2.CloseButtonVisible = false;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.ImageIndex = 1;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Silver;
            this.superTabItem2.Text = "Historique";
            // 
            // OngletFavoris
            // 
            this.OngletFavoris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OngletFavoris.Location = new System.Drawing.Point(0, 31);
            this.OngletFavoris.Name = "OngletFavoris";
            this.OngletFavoris.Size = new System.Drawing.Size(858, 501);
            this.OngletFavoris.TabIndex = 1;
            this.OngletFavoris.TabItem = this.superTabItem1;
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.OngletFavoris;
            this.superTabItem1.CloseButtonVisible = false;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.ImageIndex = 0;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Yellow;
            this.superTabItem1.Text = "Favoris";
            // 
            // IconeAjouterOnglet
            // 
            this.IconeAjouterOnglet.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.IconeAjouterOnglet.ImagePaddingHorizontal = 10;
            this.IconeAjouterOnglet.ImagePaddingVertical = 10;
            this.IconeAjouterOnglet.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.IconeAjouterOnglet.Name = "IconeAjouterOnglet";
            this.IconeAjouterOnglet.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.IconeAjouterOnglet.Click += new System.EventHandler(this.IconeAjouterOnglet_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1030, 610);
            this.Controls.Add(this.superTabControl1);
            this.Controls.Add(this.PanelHaut);
            this.Controls.Add(this.PanelBas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 200);
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "NavigateurTest01";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelHaut.ResumeLayout(false);
            this.PanelBas.ResumeLayout(false);
            this.PanelBas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelHaut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Button Google;
        private System.Windows.Forms.Button Devlog;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button SupprimerOnglet;
        private System.Windows.Forms.Button AjouterOnglet;
        private System.Windows.Forms.Panel PanelBas;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.ComboBox BarreRecherche;
        private System.Windows.Forms.TextBox BarreRecherche2;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.ProgressBar BarreProgression;
        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel OngletFavoris;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.SuperTabControlPanel OngletHistorique;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private DevComponents.DotNetBar.SuperTabItem OngletRecherche;
        private DevComponents.DotNetBar.ButtonItem IconeAjouterOnglet;
        private System.Windows.Forms.Button button1;
        private DevComponents.DotNetBar.RadialMenu radialMenu1;
        private DevComponents.DotNetBar.RadialMenuItem FacebookMenu;
        private DevComponents.DotNetBar.RadialMenuItem WikipediaMenu;
        private DevComponents.DotNetBar.RadialMenuItem Facebook2;
        private DevComponents.DotNetBar.RadialMenuItem TwitterMenu;
    }
}

