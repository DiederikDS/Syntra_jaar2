namespace VoorbeelExamen
{
    partial class PhoneWindow
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
            this.Btn_Call = new System.Windows.Forms.Button();
            this.Btn_Message = new System.Windows.Forms.Button();
            this.TxtB_PhoneNumber = new System.Windows.Forms.TextBox();
            this.RTxtB_Message = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Call
            // 
            this.Btn_Call.Location = new System.Drawing.Point(12, 71);
            this.Btn_Call.Name = "Btn_Call";
            this.Btn_Call.Size = new System.Drawing.Size(94, 29);
            this.Btn_Call.TabIndex = 0;
            this.Btn_Call.Text = "Call";
            this.Btn_Call.UseVisualStyleBackColor = true;
            this.Btn_Call.Click += new System.EventHandler(this.Btn_Call_Click);
            // 
            // Btn_Message
            // 
            this.Btn_Message.Location = new System.Drawing.Point(12, 404);
            this.Btn_Message.Name = "Btn_Message";
            this.Btn_Message.Size = new System.Drawing.Size(94, 29);
            this.Btn_Message.TabIndex = 1;
            this.Btn_Message.Text = "Message";
            this.Btn_Message.UseVisualStyleBackColor = true;
            // 
            // TxtB_PhoneNumber
            // 
            this.TxtB_PhoneNumber.Location = new System.Drawing.Point(12, 38);
            this.TxtB_PhoneNumber.Name = "TxtB_PhoneNumber";
            this.TxtB_PhoneNumber.Size = new System.Drawing.Size(341, 27);
            this.TxtB_PhoneNumber.TabIndex = 2;
            // 
            // RTxtB_Message
            // 
            this.RTxtB_Message.Location = new System.Drawing.Point(12, 195);
            this.RTxtB_Message.Name = "RTxtB_Message";
            this.RTxtB_Message.Size = new System.Drawing.Size(341, 203);
            this.RTxtB_Message.TabIndex = 3;
            this.RTxtB_Message.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message";
            // 
            // PhoneWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 527);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RTxtB_Message);
            this.Controls.Add(this.TxtB_PhoneNumber);
            this.Controls.Add(this.Btn_Message);
            this.Controls.Add(this.Btn_Call);
            this.Name = "PhoneWindow";
            this.Text = "PhoneWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_Call;
        private Button Btn_Message;
        private TextBox TxtB_PhoneNumber;
        private RichTextBox RTxtB_Message;
        private Label label1;
        private Label label2;
    }
}