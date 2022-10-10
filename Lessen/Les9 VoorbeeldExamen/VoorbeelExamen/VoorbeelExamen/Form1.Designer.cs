namespace VoorbeelExamen
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
            this.Btn_Create = new System.Windows.Forms.Button();
            this.TxtB_Name = new System.Windows.Forms.TextBox();
            this.TxtB_Version = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtB_OS = new System.Windows.Forms.TextBox();
            this.CBox_Phone = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtB_Number = new System.Windows.Forms.TextBox();
            this.Btn_Open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Create
            // 
            this.Btn_Create.Location = new System.Drawing.Point(37, 144);
            this.Btn_Create.Name = "Btn_Create";
            this.Btn_Create.Size = new System.Drawing.Size(94, 29);
            this.Btn_Create.TabIndex = 0;
            this.Btn_Create.Text = "Create";
            this.Btn_Create.UseVisualStyleBackColor = true;
            this.Btn_Create.Click += new System.EventHandler(this.Btn_Create_Click);
            // 
            // TxtB_Name
            // 
            this.TxtB_Name.Location = new System.Drawing.Point(104, 12);
            this.TxtB_Name.Name = "TxtB_Name";
            this.TxtB_Name.Size = new System.Drawing.Size(250, 27);
            this.TxtB_Name.TabIndex = 1;
            // 
            // TxtB_Version
            // 
            this.TxtB_Version.Location = new System.Drawing.Point(104, 78);
            this.TxtB_Version.Name = "TxtB_Version";
            this.TxtB_Version.Size = new System.Drawing.Size(250, 27);
            this.TxtB_Version.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "OS";
            // 
            // TxtB_OS
            // 
            this.TxtB_OS.Location = new System.Drawing.Point(104, 111);
            this.TxtB_OS.Name = "TxtB_OS";
            this.TxtB_OS.Size = new System.Drawing.Size(250, 27);
            this.TxtB_OS.TabIndex = 6;
            // 
            // CBox_Phone
            // 
            this.CBox_Phone.FormattingEnabled = true;
            this.CBox_Phone.Location = new System.Drawing.Point(104, 235);
            this.CBox_Phone.Name = "CBox_Phone";
            this.CBox_Phone.Size = new System.Drawing.Size(250, 28);
            this.CBox_Phone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Number";
            // 
            // TxtB_Number
            // 
            this.TxtB_Number.Location = new System.Drawing.Point(104, 45);
            this.TxtB_Number.Name = "TxtB_Number";
            this.TxtB_Number.Size = new System.Drawing.Size(250, 27);
            this.TxtB_Number.TabIndex = 10;
            // 
            // Btn_Open
            // 
            this.Btn_Open.Location = new System.Drawing.Point(37, 269);
            this.Btn_Open.Name = "Btn_Open";
            this.Btn_Open.Size = new System.Drawing.Size(94, 29);
            this.Btn_Open.TabIndex = 12;
            this.Btn_Open.Text = "Open";
            this.Btn_Open.UseVisualStyleBackColor = true;
            this.Btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Open);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtB_Number);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBox_Phone);
            this.Controls.Add(this.TxtB_OS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtB_Version);
            this.Controls.Add(this.TxtB_Name);
            this.Controls.Add(this.Btn_Create);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_Create;
        private TextBox TxtB_Name;
        private TextBox TxtB_Version;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtB_OS;
        private ComboBox CBox_Phone;
        private Label label5;
        private Label label4;
        private TextBox TxtB_Number;
        private Button Btn_Open;
    }
}