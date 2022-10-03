namespace Oef2_GemDelers
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
            this.TxtB_Getal1 = new System.Windows.Forms.TextBox();
            this.TxtB_Getal2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.RTB_Numbers = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TxtB_Getal1
            // 
            this.TxtB_Getal1.Location = new System.Drawing.Point(73, 12);
            this.TxtB_Getal1.Name = "TxtB_Getal1";
            this.TxtB_Getal1.Size = new System.Drawing.Size(125, 27);
            this.TxtB_Getal1.TabIndex = 0;
            // 
            // TxtB_Getal2
            // 
            this.TxtB_Getal2.Location = new System.Drawing.Point(272, 12);
            this.TxtB_Getal2.Name = "TxtB_Getal2";
            this.TxtB_Getal2.Size = new System.Drawing.Size(125, 27);
            this.TxtB_Getal2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Getal2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Getal1";
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(73, 45);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(94, 29);
            this.Btn_Start.TabIndex = 4;
            this.Btn_Start.Text = "Delers!";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // RTB_Numbers
            // 
            this.RTB_Numbers.Location = new System.Drawing.Point(17, 101);
            this.RTB_Numbers.Name = "RTB_Numbers";
            this.RTB_Numbers.Size = new System.Drawing.Size(771, 337);
            this.RTB_Numbers.TabIndex = 5;
            this.RTB_Numbers.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RTB_Numbers);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtB_Getal2);
            this.Controls.Add(this.TxtB_Getal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtB_Getal1;
        private TextBox TxtB_Getal2;
        private Label label1;
        private Label label2;
        private Button Btn_Start;
        private RichTextBox RTB_Numbers;
    }
}