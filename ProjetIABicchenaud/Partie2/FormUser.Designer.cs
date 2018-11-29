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
			this.LNoeuInit = new System.Windows.Forms.Label();
			this.BImportFichier = new System.Windows.Forms.Button();
			this.LNoeuFin = new System.Windows.Forms.Label();
			this.LBArcs = new System.Windows.Forms.ListBox();
			this.LAperGra = new System.Windows.Forms.Label();
			this.LConsigne1 = new System.Windows.Forms.Label();
			this.DGVOuvFerm = new System.Windows.Forms.DataGridView();
			this.Fermes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ouverts = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BAjoutEtape = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.LConsigne2 = new System.Windows.Forms.Label();
			this.BVerifEtape = new System.Windows.Forms.Button();
			this.BNoeuds = new System.Windows.Forms.Button();
			this.LErrNode = new System.Windows.Forms.Label();
			this.LInitNode = new System.Windows.Forms.Label();
			this.CBNodeInit = new System.Windows.Forms.ComboBox();
			this.CBNodeFin = new System.Windows.Forms.ComboBox();
			this.gpEtape1 = new System.Windows.Forms.GroupBox();
			this.gpEtape2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.bValiderTV = new System.Windows.Forms.Button();
			this.tvArbre = new System.Windows.Forms.TreeView();
			((System.ComponentModel.ISupportInitialize)(this.DGVOuvFerm)).BeginInit();
			this.gpEtape1.SuspendLayout();
			this.gpEtape2.SuspendLayout();
			this.SuspendLayout();
			// 
			// LNoeuInit
			// 
			this.LNoeuInit.AutoSize = true;
			this.LNoeuInit.Location = new System.Drawing.Point(253, 121);
			this.LNoeuInit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LNoeuInit.Name = "LNoeuInit";
			this.LNoeuInit.Size = new System.Drawing.Size(86, 17);
			this.LNoeuInit.TabIndex = 9;
			this.LNoeuInit.Text = "Noeud initial";
			// 
			// BImportFichier
			// 
			this.BImportFichier.Location = new System.Drawing.Point(71, 32);
			this.BImportFichier.Name = "BImportFichier";
			this.BImportFichier.Size = new System.Drawing.Size(120, 67);
			this.BImportFichier.TabIndex = 10;
			this.BImportFichier.Text = "Sélection d\'un fichier de graphe";
			this.BImportFichier.UseVisualStyleBackColor = true;
			this.BImportFichier.Click += new System.EventHandler(this.BImportFichier_Click);
			// 
			// LNoeuFin
			// 
			this.LNoeuFin.AutoSize = true;
			this.LNoeuFin.Location = new System.Drawing.Point(253, 176);
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
			this.LBArcs.Location = new System.Drawing.Point(71, 141);
			this.LBArcs.Name = "LBArcs";
			this.LBArcs.Size = new System.Drawing.Size(120, 212);
			this.LBArcs.TabIndex = 14;
			// 
			// LAperGra
			// 
			this.LAperGra.AutoSize = true;
			this.LAperGra.Location = new System.Drawing.Point(69, 121);
			this.LAperGra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LAperGra.Name = "LAperGra";
			this.LAperGra.Size = new System.Drawing.Size(122, 17);
			this.LAperGra.TabIndex = 15;
			this.LAperGra.Text = "Aperçu du graphe";
			// 
			// LConsigne1
			// 
			this.LConsigne1.AutoSize = true;
			this.LConsigne1.Location = new System.Drawing.Point(11, 38);
			this.LConsigne1.MaximumSize = new System.Drawing.Size(400, 0);
			this.LConsigne1.Name = "LConsigne1";
			this.LConsigne1.Size = new System.Drawing.Size(344, 16);
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
			this.DGVOuvFerm.Location = new System.Drawing.Point(14, 108);
			this.DGVOuvFerm.Name = "DGVOuvFerm";
			this.DGVOuvFerm.RowTemplate.Height = 24;
			this.DGVOuvFerm.Size = new System.Drawing.Size(248, 342);
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
			this.BAjoutEtape.Enabled = false;
			this.BAjoutEtape.Location = new System.Drawing.Point(285, 241);
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
			this.label1.Location = new System.Drawing.Point(282, 129);
			this.label1.MaximumSize = new System.Drawing.Size(110, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 16);
			this.label1.TabIndex = 19;
			this.label1.Text = "label1";
			// 
			// LConsigne2
			// 
			this.LConsigne2.AutoSize = true;
			this.LConsigne2.Location = new System.Drawing.Point(11, 58);
			this.LConsigne2.MaximumSize = new System.Drawing.Size(400, 0);
			this.LConsigne2.Name = "LConsigne2";
			this.LConsigne2.Size = new System.Drawing.Size(359, 32);
			this.LConsigne2.TabIndex = 21;
			this.LConsigne2.Text = "Ecrivez directement le numéro des noeud séparés par des espaces ou virgule";
			// 
			// BVerifEtape
			// 
			this.BVerifEtape.Location = new System.Drawing.Point(285, 173);
			this.BVerifEtape.Name = "BVerifEtape";
			this.BVerifEtape.Size = new System.Drawing.Size(94, 44);
			this.BVerifEtape.TabIndex = 22;
			this.BVerifEtape.Text = "Vérifier l\'étape";
			this.BVerifEtape.UseVisualStyleBackColor = true;
			this.BVerifEtape.Click += new System.EventHandler(this.BVerifEtape_Click);
			// 
			// BNoeuds
			// 
			this.BNoeuds.Location = new System.Drawing.Point(256, 252);
			this.BNoeuds.Name = "BNoeuds";
			this.BNoeuds.Size = new System.Drawing.Size(94, 53);
			this.BNoeuds.TabIndex = 23;
			this.BNoeuds.Text = "Valider les noeuds";
			this.BNoeuds.UseVisualStyleBackColor = true;
			this.BNoeuds.Click += new System.EventHandler(this.BNoeuds_Click);
			// 
			// LErrNode
			// 
			this.LErrNode.AutoSize = true;
			this.LErrNode.Location = new System.Drawing.Point(212, 319);
			this.LErrNode.MaximumSize = new System.Drawing.Size(180, 0);
			this.LErrNode.Name = "LErrNode";
			this.LErrNode.Size = new System.Drawing.Size(0, 17);
			this.LErrNode.TabIndex = 24;
			// 
			// LInitNode
			// 
			this.LInitNode.AutoSize = true;
			this.LInitNode.Location = new System.Drawing.Point(232, 70);
			this.LInitNode.MaximumSize = new System.Drawing.Size(180, 0);
			this.LInitNode.Name = "LInitNode";
			this.LInitNode.Size = new System.Drawing.Size(164, 34);
			this.LInitNode.TabIndex = 25;
			this.LInitNode.Text = "Veuillez sélectionner les noeuds initial et final";
			// 
			// CBNodeInit
			// 
			this.CBNodeInit.FormattingEnabled = true;
			this.CBNodeInit.Location = new System.Drawing.Point(256, 141);
			this.CBNodeInit.Name = "CBNodeInit";
			this.CBNodeInit.Size = new System.Drawing.Size(51, 24);
			this.CBNodeInit.TabIndex = 26;
			// 
			// CBNodeFin
			// 
			this.CBNodeFin.FormattingEnabled = true;
			this.CBNodeFin.Location = new System.Drawing.Point(256, 196);
			this.CBNodeFin.Name = "CBNodeFin";
			this.CBNodeFin.Size = new System.Drawing.Size(51, 24);
			this.CBNodeFin.TabIndex = 27;
			// 
			// gpEtape1
			// 
			this.gpEtape1.Controls.Add(this.BVerifEtape);
			this.gpEtape1.Controls.Add(this.LConsigne2);
			this.gpEtape1.Controls.Add(this.label1);
			this.gpEtape1.Controls.Add(this.BAjoutEtape);
			this.gpEtape1.Controls.Add(this.DGVOuvFerm);
			this.gpEtape1.Controls.Add(this.LConsigne1);
			this.gpEtape1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpEtape1.Location = new System.Drawing.Point(465, 12);
			this.gpEtape1.Name = "gpEtape1";
			this.gpEtape1.Size = new System.Drawing.Size(403, 456);
			this.gpEtape1.TabIndex = 28;
			this.gpEtape1.TabStop = false;
			this.gpEtape1.Text = "Première étape";
			// 
			// gpEtape2
			// 
			this.gpEtape2.Controls.Add(this.label2);
			this.gpEtape2.Controls.Add(this.bValiderTV);
			this.gpEtape2.Controls.Add(this.tvArbre);
			this.gpEtape2.Location = new System.Drawing.Point(933, 13);
			this.gpEtape2.Name = "gpEtape2";
			this.gpEtape2.Size = new System.Drawing.Size(336, 455);
			this.gpEtape2.TabIndex = 29;
			this.gpEtape2.TabStop = false;
			this.gpEtape2.Text = "Deuxième étape";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 396);
			this.label2.MaximumSize = new System.Drawing.Size(289, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "label2";
			// 
			// bValiderTV
			// 
			this.bValiderTV.Enabled = false;
			this.bValiderTV.Location = new System.Drawing.Point(25, 306);
			this.bValiderTV.Name = "bValiderTV";
			this.bValiderTV.Size = new System.Drawing.Size(289, 83);
			this.bValiderTV.TabIndex = 3;
			this.bValiderTV.Text = "Valider l\'arbre";
			this.bValiderTV.UseVisualStyleBackColor = true;
			this.bValiderTV.Click += new System.EventHandler(this.bValiderTV_Click);
			// 
			// tvArbre
			// 
			this.tvArbre.LabelEdit = true;
			this.tvArbre.Location = new System.Drawing.Point(25, 37);
			this.tvArbre.Name = "tvArbre";
			this.tvArbre.Size = new System.Drawing.Size(289, 255);
			this.tvArbre.TabIndex = 0;
			this.tvArbre.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvArbre_NodeMouseDoubleClick);
			// 
			// FormUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1289, 480);
			this.Controls.Add(this.gpEtape2);
			this.Controls.Add(this.gpEtape1);
			this.Controls.Add(this.CBNodeFin);
			this.Controls.Add(this.CBNodeInit);
			this.Controls.Add(this.LInitNode);
			this.Controls.Add(this.LErrNode);
			this.Controls.Add(this.BNoeuds);
			this.Controls.Add(this.LAperGra);
			this.Controls.Add(this.LBArcs);
			this.Controls.Add(this.LNoeuFin);
			this.Controls.Add(this.BImportFichier);
			this.Controls.Add(this.LNoeuInit);
			this.Name = "FormUser";
			this.Text = "FormUser";
			((System.ComponentModel.ISupportInitialize)(this.DGVOuvFerm)).EndInit();
			this.gpEtape1.ResumeLayout(false);
			this.gpEtape1.PerformLayout();
			this.gpEtape2.ResumeLayout(false);
			this.gpEtape2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label LNoeuInit;
		private System.Windows.Forms.Button BImportFichier;
		private System.Windows.Forms.Label LNoeuFin;
		private System.Windows.Forms.ListBox LBArcs;
		private System.Windows.Forms.Label LAperGra;
		private System.Windows.Forms.Label LConsigne1;
		private System.Windows.Forms.DataGridView DGVOuvFerm;
		private System.Windows.Forms.Button BAjoutEtape;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fermes;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ouverts;
        private System.Windows.Forms.Label LConsigne2;
		private System.Windows.Forms.Button BVerifEtape;
		private System.Windows.Forms.Button BNoeuds;
		private System.Windows.Forms.Label LErrNode;
		private System.Windows.Forms.Label LInitNode;
		private System.Windows.Forms.ComboBox CBNodeInit;
		private System.Windows.Forms.ComboBox CBNodeFin;
		private System.Windows.Forms.GroupBox gpEtape1;
		private System.Windows.Forms.GroupBox gpEtape2;
		private System.Windows.Forms.TreeView tvArbre;
		private System.Windows.Forms.Button bValiderTV;
		private System.Windows.Forms.Label label2;
	}
}