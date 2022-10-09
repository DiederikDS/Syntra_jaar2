namespace BucketOefening
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Fill = new System.Windows.Forms.Button();
            this.TxtB_FillAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Fill
            // 
            this.Btn_Fill.Location = new System.Drawing.Point(21, 69);
            this.Btn_Fill.Name = "Btn_Fill";
            this.Btn_Fill.Size = new System.Drawing.Size(139, 39);
            this.Btn_Fill.TabIndex = 0;
            this.Btn_Fill.Text = "Fill";
            this.Btn_Fill.UseVisualStyleBackColor = true;
            this.Btn_Fill.Click += new System.EventHandler(this.Btn_Fill_Click);
            // 
            // TxtB_FillAmount
            // 
            this.TxtB_FillAmount.Location = new System.Drawing.Point(21, 31);
            this.TxtB_FillAmount.Name = "TxtB_FillAmount";
            this.TxtB_FillAmount.Size = new System.Drawing.Size(100, 23);
            this.TxtB_FillAmount.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtB_FillAmount);
            this.Controls.Add(this.Btn_Fill);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_Fill;
        private TextBox TxtB_FillAmount;
    }
}