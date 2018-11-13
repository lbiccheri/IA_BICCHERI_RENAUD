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
            this.btQuestionSuivante = new System.Windows.Forms.Button();
            this.cb1Reponse = new System.Windows.Forms.CheckBox();
            this.cb2Reponse = new System.Windows.Forms.CheckBox();
            this.cb3Reponse = new System.Windows.Forms.CheckBox();
            this.lbNbQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Location = new System.Drawing.Point(377, 159);
            this.lbQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(73, 20);
            this.lbQuestion.TabIndex = 0;
            this.lbQuestion.Text = "Question";
            // 
            // btQuestionSuivante
            // 
            this.btQuestionSuivante.Location = new System.Drawing.Point(350, 438);
            this.btQuestionSuivante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btQuestionSuivante.Name = "btQuestionSuivante";
            this.btQuestionSuivante.Size = new System.Drawing.Size(130, 52);
            this.btQuestionSuivante.TabIndex = 4;
            this.btQuestionSuivante.Text = "Question suivante";
            this.btQuestionSuivante.UseVisualStyleBackColor = true;
            this.btQuestionSuivante.Click += new System.EventHandler(this.btQuestionSuivante_Click);
            // 
            // cb1Reponse
            // 
            this.cb1Reponse.AutoSize = true;
            this.cb1Reponse.Location = new System.Drawing.Point(221, 260);
            this.cb1Reponse.Name = "cb1Reponse";
            this.cb1Reponse.Size = new System.Drawing.Size(113, 24);
            this.cb1Reponse.TabIndex = 5;
            this.cb1Reponse.Text = "checkBox1";
            this.cb1Reponse.UseVisualStyleBackColor = true;
            // 
            // cb2Reponse
            // 
            this.cb2Reponse.AutoSize = true;
            this.cb2Reponse.Location = new System.Drawing.Point(221, 304);
            this.cb2Reponse.Name = "cb2Reponse";
            this.cb2Reponse.Size = new System.Drawing.Size(113, 24);
            this.cb2Reponse.TabIndex = 6;
            this.cb2Reponse.Text = "checkBox2";
            this.cb2Reponse.UseVisualStyleBackColor = true;
            // 
            // cb3Reponse
            // 
            this.cb3Reponse.AutoSize = true;
            this.cb3Reponse.Location = new System.Drawing.Point(221, 354);
            this.cb3Reponse.Name = "cb3Reponse";
            this.cb3Reponse.Size = new System.Drawing.Size(113, 24);
            this.cb3Reponse.TabIndex = 7;
            this.cb3Reponse.Text = "checkBox3";
            this.cb3Reponse.UseVisualStyleBackColor = true;
            // 
            // lbNbQuestion
            // 
            this.lbNbQuestion.AutoSize = true;
            this.lbNbQuestion.Location = new System.Drawing.Point(737, 46);
            this.lbNbQuestion.Name = "lbNbQuestion";
            this.lbNbQuestion.Size = new System.Drawing.Size(51, 20);
            this.lbNbQuestion.TabIndex = 8;
            this.lbNbQuestion.Text = "label1";
            // 
            // formQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(876, 629);
            this.Controls.Add(this.lbNbQuestion);
            this.Controls.Add(this.cb3Reponse);
            this.Controls.Add(this.cb2Reponse);
            this.Controls.Add(this.cb1Reponse);
            this.Controls.Add(this.btQuestionSuivante);
            this.Controls.Add(this.lbQuestion);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.Button btQuestionSuivante;
        private System.Windows.Forms.CheckBox cb1Reponse;
        private System.Windows.Forms.CheckBox cb2Reponse;
        private System.Windows.Forms.CheckBox cb3Reponse;
        private System.Windows.Forms.Label lbNbQuestion;
    }
}