namespace WindowsFormsApplication1
{
    partial class Favoris
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
            this.ListeFavoris = new System.Windows.Forms.ListBox();
            this.SupprimerSelection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListeFavoris
            // 
            this.ListeFavoris.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListeFavoris.FormattingEnabled = true;
            this.ListeFavoris.Location = new System.Drawing.Point(0, 0);
            this.ListeFavoris.Name = "ListeFavoris";
            this.ListeFavoris.Size = new System.Drawing.Size(538, 277);
            this.ListeFavoris.TabIndex = 0;
            this.ListeFavoris.SelectedIndexChanged += new System.EventHandler(this.ListeFavoris_SelectedIndexChanged);
            // 
            // SupprimerSelection
            // 
            this.SupprimerSelection.Location = new System.Drawing.Point(12, 283);
            this.SupprimerSelection.Name = "SupprimerSelection";
            this.SupprimerSelection.Size = new System.Drawing.Size(117, 23);
            this.SupprimerSelection.TabIndex = 1;
            this.SupprimerSelection.Text = "Supprimer Selection";
            this.SupprimerSelection.UseVisualStyleBackColor = true;
            this.SupprimerSelection.Click += new System.EventHandler(this.SupprimerSelection_Click);
            // 
            // Favoris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 317);
            this.Controls.Add(this.SupprimerSelection);
            this.Controls.Add(this.ListeFavoris);
            this.Name = "Favoris";
            this.Text = "Favoris";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SupprimerSelection;
        public System.Windows.Forms.ListBox ListeFavoris;
    }
}