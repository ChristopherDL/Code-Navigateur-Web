namespace WindowsFormsApplication1
{
    partial class Historique
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Supprimer = new System.Windows.Forms.Button();
            this.ListeHistorique = new System.Windows.Forms.ListBox();
            this.SupprimerTout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Supprimer
            // 
            this.Supprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Supprimer.Location = new System.Drawing.Point(12, 308);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(119, 23);
            this.Supprimer.TabIndex = 1;
            this.Supprimer.Text = "Supprimer Selection";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // ListeHistorique
            // 
            this.ListeHistorique.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListeHistorique.FormattingEnabled = true;
            this.ListeHistorique.Location = new System.Drawing.Point(0, -1);
            this.ListeHistorique.Name = "ListeHistorique";
            this.ListeHistorique.Size = new System.Drawing.Size(615, 303);
            this.ListeHistorique.TabIndex = 2;
            // 
            // SupprimerTout
            // 
            this.SupprimerTout.Location = new System.Drawing.Point(155, 308);
            this.SupprimerTout.Name = "SupprimerTout";
            this.SupprimerTout.Size = new System.Drawing.Size(100, 23);
            this.SupprimerTout.TabIndex = 3;
            this.SupprimerTout.Text = "Supprimer Tout";
            this.SupprimerTout.UseVisualStyleBackColor = true;
            this.SupprimerTout.Click += new System.EventHandler(this.SupprimerTout_Click);
            // 
            // Historique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 338);
            this.Controls.Add(this.SupprimerTout);
            this.Controls.Add(this.ListeHistorique);
            this.Controls.Add(this.Supprimer);
            this.Name = "Historique";
            this.Text = "Historique";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Supprimer;
        public System.Windows.Forms.ListBox ListeHistorique;
        private System.Windows.Forms.Button SupprimerTout;
    }
}