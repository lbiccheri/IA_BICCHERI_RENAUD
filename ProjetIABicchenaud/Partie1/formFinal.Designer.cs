namespace Partie1
{
    partial class formFinal
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
            this.lbScore = new System.Windows.Forms.Label();
            this.lbFelicitation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Location = new System.Drawing.Point(365, 211);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(51, 20);
            this.lbScore.TabIndex = 0;
            this.lbScore.Text = "label1";
            // 
            // lbFelicitation
            // 
            this.lbFelicitation.AutoSize = true;
            this.lbFelicitation.Location = new System.Drawing.Point(369, 102);
            this.lbFelicitation.Name = "lbFelicitation";
            this.lbFelicitation.Size = new System.Drawing.Size(48, 20);
            this.lbFelicitation.TabIndex = 1;
            this.lbFelicitation.Text = "Label";
            // 
            // formFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbFelicitation);
            this.Controls.Add(this.lbScore);
            this.Name = "formFinal";
            this.Text = "formFinal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbFelicitation;
    }
}