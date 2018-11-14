namespace Partie2
{
	partial class FormUser
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
            this.TBNoeuInit = new System.Windows.Forms.TextBox();
            this.LNoeuInit = new System.Windows.Forms.Label();
            this.BInit1 = new System.Windows.Forms.Button();
            this.TBNoeuFin = new System.Windows.Forms.TextBox();
            this.LNoeuFin = new System.Windows.Forms.Label();
            this.LBArcs = new System.Windows.Forms.ListBox();
            this.LAperGra = new System.Windows.Forms.Label();
            this.LConsigne1 = new System.Windows.Forms.Label();
            this.DGVOuvFerm = new System.Windows.Forms.DataGridView();
            this.Fermes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ouverts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAjoutEtape = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LBSol = new System.Windows.Forms.ListBox();
            this.LConsigne2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOuvFerm)).BeginInit();
            this.SuspendLayout();
            // 
            // TBNoeuInit
            // 
            this.TBNoeuInit.Location = new System.Drawing.Point(161, 44);
            this.TBNoeuInit.Name = "TBNoeuInit";
            this.TBNoeuInit.Size = new System.Drawing.Size(83, 22);
            this.TBNoeuInit.TabIndex = 8;
            // 
            // LNoeuInit
            // 
            this.LNoeuInit.AutoSize = true;
            this.LNoeuInit.Location = new System.Drawing.Point(158, 24);
            this.LNoeuInit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNoeuInit.Name = "LNoeuInit";
            this.LNoeuInit.Size = new System.Drawing.Size(86, 17);
            this.LNoeuInit.TabIndex = 9;
            this.LNoeuInit.Text = "Noeud initial";
            // 
            // BInit1
            // 
            this.BInit1.Location = new System.Drawing.Point(36, 69);
            this.BInit1.Name = "BInit1";
            this.BInit1.Size = new System.Drawing.Size(75, 23);
            this.BInit1.TabIndex = 10;
            this.BInit1.Text = "Init 1";
            this.BInit1.UseVisualStyleBackColor = true;
            this.BInit1.Click += new System.EventHandler(this.BInit1_Click);
            // 
            // TBNoeuFin
            // 
            this.TBNoeuFin.Location = new System.Drawing.Point(311, 44);
            this.TBNoeuFin.Name = "TBNoeuFin";
            this.TBNoeuFin.Size = new System.Drawing.Size(83, 22);
            this.TBNoeuFin.TabIndex = 13;
            // 
            // LNoeuFin
            // 
            this.LNoeuFin.AutoSize = true;
            this.LNoeuFin.Location = new System.Drawing.Point(308, 24);
            this.LNoeuFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNoeuFin.Name = "LNoeuFin";
            this.LNoeuFin.Size = new System.Drawing.Size(80, 17);
            this.LNoeuFin.TabIndex = 12;
            this.LNoeuFin.Text = "Noeud final";
            // 
            // LBArcs
            // 
            this.LBArcs.FormattingEnabled = true;
            this.LBArcs.ItemHeight = 16;
            this.LBArcs.Location = new System.Drawing.Point(161, 131);
            this.LBArcs.Name = "LBArcs";
            this.LBArcs.Size = new System.Drawing.Size(120, 164);
            this.LBArcs.TabIndex = 14;
            // 
            // LAperGra
            // 
            this.LAperGra.AutoSize = true;
            this.LAperGra.Location = new System.Drawing.Point(159, 111);
            this.LAperGra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAperGra.Name = "LAperGra";
            this.LAperGra.Size = new System.Drawing.Size(122, 17);
            this.LAperGra.TabIndex = 15;
            this.LAperGra.Text = "Aperçu du graphe";
            // 
            // LConsigne1
            // 
            this.LConsigne1.AutoSize = true;
            this.LConsigne1.Location = new System.Drawing.Point(400, 91);
            this.LConsigne1.Name = "LConsigne1";
            this.LConsigne1.Size = new System.Drawing.Size(368, 17);
            this.LConsigne1.TabIndex = 16;
            this.LConsigne1.Text = "Remplissez les ouverts (O) et fermés (F) étape par étape";
            // 
            // DGVOuvFerm
            // 
            this.DGVOuvFerm.AllowUserToAddRows = false;
            this.DGVOuvFerm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOuvFerm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fermes,
            this.Ouverts});
            this.DGVOuvFerm.Location = new System.Drawing.Point(403, 145);
            this.DGVOuvFerm.Name = "DGVOuvFerm";
            this.DGVOuvFerm.RowTemplate.Height = 24;
            this.DGVOuvFerm.Size = new System.Drawing.Size(248, 280);
            this.DGVOuvFerm.TabIndex = 17;
            // 
            // Fermes
            // 
            this.Fermes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fermes.HeaderText = "F";
            this.Fermes.Name = "Fermes";
            // 
            // Ouverts
            // 
            this.Ouverts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ouverts.HeaderText = "O";
            this.Ouverts.Name = "Ouverts";
            // 
            // BAjoutEtape
            // 
            this.BAjoutEtape.Location = new System.Drawing.Point(674, 251);
            this.BAjoutEtape.Name = "BAjoutEtape";
            this.BAjoutEtape.Size = new System.Drawing.Size(94, 44);
            this.BAjoutEtape.TabIndex = 18;
            this.BAjoutEtape.Text = "Ajouter une étape";
            this.BAjoutEtape.UseVisualStyleBackColor = true;
            this.BAjoutEtape.Click += new System.EventHandler(this.BAjoutEtape_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 19;
            // 
            // LBSol
            // 
            this.LBSol.FormattingEnabled = true;
            this.LBSol.ItemHeight = 16;
            this.LBSol.Location = new System.Drawing.Point(13, 225);
            this.LBSol.Name = "LBSol";
            this.LBSol.Size = new System.Drawing.Size(120, 180);
            this.LBSol.TabIndex = 20;
            // 
            // LConsigne2
            // 
            this.LConsigne2.AutoSize = true;
            this.LConsigne2.Location = new System.Drawing.Point(403, 111);
            this.LConsigne2.Name = "LConsigne2";
            this.LConsigne2.Size = new System.Drawing.Size(401, 17);
            this.LConsigne2.TabIndex = 21;
            this.LConsigne2.Text = "De la forme _,_,_ en remplaçant les _ par le numéro du noeud";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.LConsigne2);
            this.Controls.Add(this.LBSol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BAjoutEtape);
            this.Controls.Add(this.DGVOuvFerm);
            this.Controls.Add(this.LConsigne1);
            this.Controls.Add(this.LAperGra);
            this.Controls.Add(this.LBArcs);
            this.Controls.Add(this.TBNoeuFin);
            this.Controls.Add(this.LNoeuFin);
            this.Controls.Add(this.BInit1);
            this.Controls.Add(this.LNoeuInit);
            this.Controls.Add(this.TBNoeuInit);
            this.Name = "FormUser";
            this.Text = "FormUser";
            ((System.ComponentModel.ISupportInitialize)(this.DGVOuvFerm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TBNoeuInit;
		private System.Windows.Forms.Label LNoeuInit;
		private System.Windows.Forms.Button BInit1;
		private System.Windows.Forms.TextBox TBNoeuFin;
		private System.Windows.Forms.Label LNoeuFin;
		private System.Windows.Forms.ListBox LBArcs;
		private System.Windows.Forms.Label LAperGra;
		private System.Windows.Forms.Label LConsigne1;
		private System.Windows.Forms.DataGridView DGVOuvFerm;
		private System.Windows.Forms.Button BAjoutEtape;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fermes;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ouverts;
        private System.Windows.Forms.ListBox LBSol;
        private System.Windows.Forms.Label LConsigne2;
    }
}