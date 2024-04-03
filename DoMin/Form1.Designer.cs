namespace DoMin
{
    partial class Form1
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
            this.paldomin = new System.Windows.Forms.Panel();
            this.lbkq = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbomo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbsomin = new System.Windows.Forms.Label();
            this.restartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paldomin
            // 
            this.paldomin.Location = new System.Drawing.Point(64, 10);
            this.paldomin.Margin = new System.Windows.Forms.Padding(2);
            this.paldomin.Name = "paldomin";
            this.paldomin.Size = new System.Drawing.Size(713, 504);
            this.paldomin.TabIndex = 0;
            this.paldomin.Paint += new System.Windows.Forms.PaintEventHandler(this.paldomin_Paint);
            // 
            // lbkq
            // 
            this.lbkq.AutoSize = true;
            this.lbkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbkq.Location = new System.Drawing.Point(822, 102);
            this.lbkq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbkq.Name = "lbkq";
            this.lbkq.Size = new System.Drawing.Size(72, 22);
            this.lbkq.TabIndex = 1;
            this.lbkq.Text = "Kết quả";
            this.lbkq.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(809, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số ô đã mở";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbomo
            // 
            this.lbomo.AutoSize = true;
            this.lbomo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbomo.Location = new System.Drawing.Point(847, 203);
            this.lbomo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbomo.Name = "lbomo";
            this.lbomo.Size = new System.Drawing.Size(20, 22);
            this.lbomo.TabIndex = 3;
            this.lbomo.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(802, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng số mìn";
            // 
            // lbsomin
            // 
            this.lbsomin.AutoSize = true;
            this.lbsomin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbsomin.Location = new System.Drawing.Point(847, 316);
            this.lbsomin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbsomin.Name = "lbsomin";
            this.lbsomin.Size = new System.Drawing.Size(20, 22);
            this.lbsomin.TabIndex = 5;
            this.lbsomin.Text = "0";
            // 
            // restartBtn
            // 
            this.restartBtn.Location = new System.Drawing.Point(822, 368);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(72, 32);
            this.restartBtn.TabIndex = 6;
            this.restartBtn.Text = "Restart Game";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Visible = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Clicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 525);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.lbsomin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbomo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbkq);
            this.Controls.Add(this.paldomin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paldomin;
        private System.Windows.Forms.Label lbkq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbomo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbsomin;
        private System.Windows.Forms.Button restartBtn;
    }
}

