namespace DoMin
{
    partial class DoKho
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonDe = new System.Windows.Forms.RadioButton();
            this.radioButtonKho = new System.Windows.Forms.RadioButton();
            this.radioButtonTrungBinh = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(249, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn độ khó";
            // 
            // radioButtonDe
            // 
            this.radioButtonDe.AutoSize = true;
            this.radioButtonDe.Location = new System.Drawing.Point(129, 64);
            this.radioButtonDe.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDe.Name = "radioButtonDe";
            this.radioButtonDe.Size = new System.Drawing.Size(39, 17);
            this.radioButtonDe.TabIndex = 1;
            this.radioButtonDe.Text = "Dễ";
            this.radioButtonDe.UseVisualStyleBackColor = true;
            this.radioButtonDe.CheckedChanged += new System.EventHandler(this.Easy_CheckedChanged);
            // 
            // radioButtonKho
            // 
            this.radioButtonKho.AutoSize = true;
            this.radioButtonKho.Location = new System.Drawing.Point(430, 64);
            this.radioButtonKho.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonKho.Name = "radioButtonKho";
            this.radioButtonKho.Size = new System.Drawing.Size(44, 17);
            this.radioButtonKho.TabIndex = 2;
            this.radioButtonKho.Text = "Khó";
            this.radioButtonKho.UseVisualStyleBackColor = true;
            this.radioButtonKho.CheckedChanged += new System.EventHandler(this.Difficult_CheckedChanged);
            // 
            // radioButtonTrungBinh
            // 
            this.radioButtonTrungBinh.AutoSize = true;
            this.radioButtonTrungBinh.Location = new System.Drawing.Point(273, 64);
            this.radioButtonTrungBinh.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTrungBinh.Name = "radioButtonTrungBinh";
            this.radioButtonTrungBinh.Size = new System.Drawing.Size(76, 17);
            this.radioButtonTrungBinh.TabIndex = 3;
            this.radioButtonTrungBinh.Text = "Trung bình";
            this.radioButtonTrungBinh.UseVisualStyleBackColor = true;
            this.radioButtonTrungBinh.CheckedChanged += new System.EventHandler(this.Medium_CheckedChanged);
            // 
            // DoKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 104);
            this.Controls.Add(this.radioButtonTrungBinh);
            this.Controls.Add(this.radioButtonKho);
            this.Controls.Add(this.radioButtonDe);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DoKho";
            this.Text = "DoKho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonDe;
        private System.Windows.Forms.RadioButton radioButtonKho;
        private System.Windows.Forms.RadioButton radioButtonTrungBinh;
    }
}