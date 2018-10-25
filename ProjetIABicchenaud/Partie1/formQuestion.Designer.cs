namespace Partie1
{
    partial class formQuestion
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
            this.lbQuestion = new System.Windows.Forms.Label();
            this.lbRep1 = new System.Windows.Forms.Label();
            this.lbRep2 = new System.Windows.Forms.Label();
            this.lbRep3 = new System.Windows.Forms.Label();
            this.btQuestionSuivante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Location = new System.Drawing.Point(246, 94);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(35, 13);
            this.lbQuestion.TabIndex = 0;
            this.lbQuestion.Text = "label1";
            // 
            // lbRep1
            // 
            this.lbRep1.AutoSize = true;
            this.lbRep1.Location = new System.Drawing.Point(90, 173);
            this.lbRep1.Name = "lbRep1";
            this.lbRep1.Size = new System.Drawing.Size(35, 13);
            this.lbRep1.TabIndex = 1;
            this.lbRep1.Text = "label1";
            // 
            // lbRep2
            // 
            this.lbRep2.AutoSize = true;
            this.lbRep2.Location = new System.Drawing.Point(93, 211);
            this.lbRep2.Name = "lbRep2";
            this.lbRep2.Size = new System.Drawing.Size(35, 13);
            this.lbRep2.TabIndex = 2;
            this.lbRep2.Text = "label1";
            // 
            // lbRep3
            // 
            this.lbRep3.AutoSize = true;
            this.lbRep3.Location = new System.Drawing.Point(90, 249);
            this.lbRep3.Name = "lbRep3";
            this.lbRep3.Size = new System.Drawing.Size(35, 13);
            this.lbRep3.TabIndex = 3;
            this.lbRep3.Text = "label1";
            // 
            // btQuestionSuivante
            // 
            this.btQuestionSuivante.Location = new System.Drawing.Point(249, 317);
            this.btQuestionSuivante.Name = "btQuestionSuivante";
            this.btQuestionSuivante.Size = new System.Drawing.Size(75, 23);
            this.btQuestionSuivante.TabIndex = 4;
            this.btQuestionSuivante.Text = "button1";
            this.btQuestionSuivante.UseVisualStyleBackColor = true;
            // 
            // formQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 409);
            this.Controls.Add(this.btQuestionSuivante);
            this.Controls.Add(this.lbRep3);
            this.Controls.Add(this.lbRep2);
            this.Controls.Add(this.lbRep1);
            this.Controls.Add(this.lbQuestion);
            this.Name = "formQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.Label lbRep1;
        private System.Windows.Forms.Label lbRep2;
        private System.Windows.Forms.Label lbRep3;
        private System.Windows.Forms.Button btQuestionSuivante;
    }
}