namespace Partie2
{
	partial class Dijkstra
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
			this.BInit1 = new System.Windows.Forms.Button();
			this.BInit2 = new System.Windows.Forms.Button();
			this.BAEtoile = new System.Windows.Forms.Button();
			this.LNoeuFin = new System.Windows.Forms.Label();
			this.LNoeuInit = new System.Windows.Forms.Label();
			this.TBNoeuInit = new System.Windows.Forms.TextBox();
			this.TBNoeuFin = new System.Windows.Forms.TextBox();
			this.LBArcs = new System.Windows.Forms.ListBox();
			this.LBDist = new System.Windows.Forms.ListBox();
			this.TVArbre = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// BInit1
			// 
			this.BInit1.Location = new System.Drawing.Point(55, 40);
			this.BInit1.Name = "BInit1";
			this.BInit1.Size = new System.Drawing.Size(75, 23);
			this.BInit1.TabIndex = 0;
			this.BInit1.Text = "Init 1";
			this.BInit1.UseVisualStyleBackColor = true;
			this.BInit1.Click += new System.EventHandler(this.BInit1_Click);
			// 
			// BInit2
			// 
			this.BInit2.Location = new System.Drawing.Point(55, 102);
			this.BInit2.Name = "BInit2";
			this.BInit2.Size = new System.Drawing.Size(75, 23);
			this.BInit2.TabIndex = 1;
			this.BInit2.Text = "Init 2";
			this.BInit2.UseVisualStyleBackColor = true;
			this.BInit2.Click += new System.EventHandler(this.BInit2_Click);
			// 
			// BAEtoile
			// 
			this.BAEtoile.Location = new System.Drawing.Point(573, 40);
			this.BAEtoile.Name = "BAEtoile";
			this.BAEtoile.Size = new System.Drawing.Size(75, 23);
			this.BAEtoile.TabIndex = 2;
			this.BAEtoile.Text = "A*";
			this.BAEtoile.UseVisualStyleBackColor = true;
			this.BAEtoile.Click += new System.EventHandler(this.BAEtoile_Click);
			// 
			// LNoeuFin
			// 
			this.LNoeuFin.AutoSize = true;
			this.LNoeuFin.Location = new System.Drawing.Point(397, 19);
			this.LNoeuFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LNoeuFin.Name = "LNoeuFin";
			this.LNoeuFin.Size = new System.Drawing.Size(80, 17);
			this.LNoeuFin.TabIndex = 5;
			this.LNoeuFin.Text = "Noeud final";
			// 
			// LNoeuInit
			// 
			this.LNoeuInit.AutoSize = true;
			this.LNoeuInit.Location = new System.Drawing.Point(211, 19);
			this.LNoeuInit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LNoeuInit.Name = "LNoeuInit";
			this.LNoeuInit.Size = new System.Drawing.Size(86, 17);
			this.LNoeuInit.TabIndex = 6;
			this.LNoeuInit.Text = "Noeud initial";
			// 
			// TBNoeuInit
			// 
			this.TBNoeuInit.Location = new System.Drawing.Point(214, 41);
			this.TBNoeuInit.Name = "TBNoeuInit";
			this.TBNoeuInit.Size = new System.Drawing.Size(83, 22);
			this.TBNoeuInit.TabIndex = 7;
			// 
			// TBNoeuFin
			// 
			this.TBNoeuFin.Location = new System.Drawing.Point(400, 41);
			this.TBNoeuFin.Name = "TBNoeuFin";
			this.TBNoeuFin.Size = new System.Drawing.Size(83, 22);
			this.TBNoeuFin.TabIndex = 8;
			// 
			// LBArcs
			// 
			this.LBArcs.FormattingEnabled = true;
			this.LBArcs.ItemHeight = 16;
			this.LBArcs.Location = new System.Drawing.Point(214, 102);
			this.LBArcs.Name = "LBArcs";
			this.LBArcs.Size = new System.Drawing.Size(120, 164);
			this.LBArcs.TabIndex = 9;
			// 
			// LBDist
			// 
			this.LBDist.FormattingEnabled = true;
			this.LBDist.ItemHeight = 16;
			this.LBDist.Location = new System.Drawing.Point(400, 102);
			this.LBDist.Name = "LBDist";
			this.LBDist.Size = new System.Drawing.Size(120, 164);
			this.LBDist.TabIndex = 10;
			// 
			// TVArbre
			// 
			this.TVArbre.Location = new System.Drawing.Point(573, 102);
			this.TVArbre.Name = "TVArbre";
			this.TVArbre.Size = new System.Drawing.Size(184, 195);
			this.TVArbre.TabIndex = 11;
			// 
			// Dijkstra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(885, 401);
			this.Controls.Add(this.TVArbre);
			this.Controls.Add(this.LBDist);
			this.Controls.Add(this.LBArcs);
			this.Controls.Add(this.TBNoeuFin);
			this.Controls.Add(this.TBNoeuInit);
			this.Controls.Add(this.LNoeuInit);
			this.Controls.Add(this.LNoeuFin);
			this.Controls.Add(this.BAEtoile);
			this.Controls.Add(this.BInit2);
			this.Controls.Add(this.BInit1);
			this.Name = "Dijkstra";
			this.Text = "Dijkstra";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BInit1;
		private System.Windows.Forms.Button BInit2;
		private System.Windows.Forms.Button BAEtoile;
		private System.Windows.Forms.Label LNoeuFin;
		private System.Windows.Forms.Label LNoeuInit;
		private System.Windows.Forms.TextBox TBNoeuInit;
		private System.Windows.Forms.TextBox TBNoeuFin;
		private System.Windows.Forms.ListBox LBArcs;
		private System.Windows.Forms.ListBox LBDist;
		private System.Windows.Forms.TreeView TVArbre;
	}
}