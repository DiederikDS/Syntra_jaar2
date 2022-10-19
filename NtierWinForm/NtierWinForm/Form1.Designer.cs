namespace NtierWinForm
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
            this.Btn_GetDirecotryItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_GetDirecotryItems
            // 
            this.Btn_GetDirecotryItems.Location = new System.Drawing.Point(12, 12);
            this.Btn_GetDirecotryItems.Name = "Btn_GetDirecotryItems";
            this.Btn_GetDirecotryItems.Size = new System.Drawing.Size(191, 29);
            this.Btn_GetDirecotryItems.TabIndex = 0;
            this.Btn_GetDirecotryItems.Text = "Read Directory";
            this.Btn_GetDirecotryItems.UseVisualStyleBackColor = true;
            this.Btn_GetDirecotryItems.Click += new System.EventHandler(this.Btn_GetDirecotryItems_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_GetDirecotryItems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Btn_GetDirecotryItems;
    }
}