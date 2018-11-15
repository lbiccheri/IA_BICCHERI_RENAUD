namespace Partie1
{
	partial class formPresentation
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
            this.lbPresentation = new System.Windows.Forms.Label();
            this.btContinuer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPresentation
            // 
            this.lbPresentation.BackColor = System.Drawing.Color.Transparent;
            this.lbPresentation.Font = new System.Drawing.Font("Georgia", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPresentation.ForeColor = System.Drawing.Color.Red;
            this.lbPresentation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbPresentation.Location = new System.Drawing.Point(13, 47);
            this.lbPresentation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPresentation.Name = "lbPresentation";
            this.lbPresentation.Size = new System.Drawing.Size(952, 110);
            this.lbPresentation.TabIndex = 0;
            this.lbPresentation.Text = "Label\r\n";
            // 
            // btContinuer
            // 
            this.btContinuer.Location = new System.Drawing.Point(489, 507);
            this.btContinuer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btContinuer.Name = "btContinuer";
            this.btContinuer.Size = new System.Drawing.Size(269, 118);
            this.btContinuer.TabIndex = 1;
            this.btContinuer.Text = "C\'est parti!";
            this.btContinuer.UseVisualStyleBackColor = true;
            this.btContinuer.Click += new System.EventHandler(this.btContinuer_Click);
            // 
            // formPresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Partie1.Properties.Resources.pere_fouras;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btContinuer);
            this.Controls.Add(this.lbPresentation);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1226, 752);
            this.MinimumSize = new System.Drawing.Size(1226, 752);
            this.Name = "formPresentation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Label lbPresentation;
        private System.Windows.Forms.Button btContinuer;
    }
}

