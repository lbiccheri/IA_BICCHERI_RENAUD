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
            this.lbNbQuestion = new System.Windows.Forms.Label();
            this.rbRep1 = new System.Windows.Forms.RadioButton();
            this.rbRep2 = new System.Windows.Forms.RadioButton();
            this.rbRep3 = new System.Windows.Forms.RadioButton();
            this.gbReponse = new System.Windows.Forms.GroupBox();
            this.gbReponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestion.Location = new System.Drawing.Point(380, 120);
            this.lbQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(126, 29);
            this.lbQuestion.TabIndex = 0;
            this.lbQuestion.Text = "Question";
            this.lbQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btQuestionSuivante
            // 
            this.btQuestionSuivante.Location = new System.Drawing.Point(504, 564);
            this.btQuestionSuivante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btQuestionSuivante.Name = "btQuestionSuivante";
            this.btQuestionSuivante.Size = new System.Drawing.Size(258, 96);
            this.btQuestionSuivante.TabIndex = 4;
            this.btQuestionSuivante.Text = "Question suivante";
            this.btQuestionSuivante.UseVisualStyleBackColor = true;
            this.btQuestionSuivante.Click += new System.EventHandler(this.btQuestionSuivante_Click);
            // 
            // lbNbQuestion
            // 
            this.lbNbQuestion.AutoSize = true;
            this.lbNbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNbQuestion.Location = new System.Drawing.Point(1020, 54);
            this.lbNbQuestion.Name = "lbNbQuestion";
            this.lbNbQuestion.Size = new System.Drawing.Size(64, 25);
            this.lbNbQuestion.TabIndex = 8;
            this.lbNbQuestion.Text = "label1";
            // 
            // rbRep1
            // 
            this.rbRep1.AutoSize = true;
            this.rbRep1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRep1.Location = new System.Drawing.Point(55, 89);
            this.rbRep1.Name = "rbRep1";
            this.rbRep1.Size = new System.Drawing.Size(152, 28);
            this.rbRep1.TabIndex = 9;
            this.rbRep1.TabStop = true;
            this.rbRep1.Text = "radioButton1";
            this.rbRep1.UseVisualStyleBackColor = true;
            // 
            // rbRep2
            // 
            this.rbRep2.AutoSize = true;
            this.rbRep2.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRep2.Location = new System.Drawing.Point(55, 159);
            this.rbRep2.Name = "rbRep2";
            this.rbRep2.Size = new System.Drawing.Size(154, 28);
            this.rbRep2.TabIndex = 10;
            this.rbRep2.TabStop = true;
            this.rbRep2.Text = "radioButton2";
            this.rbRep2.UseVisualStyleBackColor = true;
            // 
            // rbRep3
            // 
            this.rbRep3.AutoSize = true;
            this.rbRep3.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRep3.Location = new System.Drawing.Point(55, 234);
            this.rbRep3.Name = "rbRep3";
            this.rbRep3.Size = new System.Drawing.Size(154, 28);
            this.rbRep3.TabIndex = 11;
            this.rbRep3.TabStop = true;
            this.rbRep3.Text = "radioButton3";
            this.rbRep3.UseVisualStyleBackColor = true;
            // 
            // gbReponse
            // 
            this.gbReponse.Controls.Add(this.rbRep1);
            this.gbReponse.Controls.Add(this.rbRep2);
            this.gbReponse.Controls.Add(this.rbRep3);
            this.gbReponse.Location = new System.Drawing.Point(116, 164);
            this.gbReponse.Name = "gbReponse";
            this.gbReponse.Size = new System.Drawing.Size(992, 367);
            this.gbReponse.TabIndex = 12;
            this.gbReponse.TabStop = false;
            this.gbReponse.Text = "Réponses possibles";
            // 
            // formQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1204, 696);
            this.Controls.Add(this.gbReponse);
            this.Controls.Add(this.lbNbQuestion);
            this.Controls.Add(this.btQuestionSuivante);
            this.Controls.Add(this.lbQuestion);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formQuestion";
            this.gbReponse.ResumeLayout(false);
            this.gbReponse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.Button btQuestionSuivante;
        private System.Windows.Forms.Label lbNbQuestion;
        private System.Windows.Forms.RadioButton rbRep1;
        private System.Windows.Forms.RadioButton rbRep2;
        private System.Windows.Forms.RadioButton rbRep3;
        private System.Windows.Forms.GroupBox gbReponse;
    }
}