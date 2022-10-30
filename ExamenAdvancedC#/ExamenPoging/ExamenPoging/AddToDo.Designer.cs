namespace ExamenPoging
{
    partial class AddToDo
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
            this.Lbl_Type = new System.Windows.Forms.Label();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_Ececutor = new System.Windows.Forms.Label();
            this.Lbl_DueDate = new System.Windows.Forms.Label();
            this.Lbl_Location = new System.Windows.Forms.Label();
            this.CBB_Type = new System.Windows.Forms.ComboBox();
            this.DTP_DueDate = new System.Windows.Forms.DateTimePicker();
            this.TxtB_Name = new System.Windows.Forms.TextBox();
            this.TxTB_Executor = new System.Windows.Forms.TextBox();
            this.TxTB_Location = new System.Windows.Forms.TextBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Create = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Lbl_Description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Type
            // 
            this.Lbl_Type.AutoSize = true;
            this.Lbl_Type.Location = new System.Drawing.Point(12, 29);
            this.Lbl_Type.Name = "Lbl_Type";
            this.Lbl_Type.Size = new System.Drawing.Size(43, 20);
            this.Lbl_Type.TabIndex = 0;
            this.Lbl_Type.Text = "Type:";
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Location = new System.Drawing.Point(12, 66);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(52, 20);
            this.Lbl_Name.TabIndex = 1;
            this.Lbl_Name.Text = "Name:";
            // 
            // Lbl_Ececutor
            // 
            this.Lbl_Ececutor.AutoSize = true;
            this.Lbl_Ececutor.Location = new System.Drawing.Point(12, 100);
            this.Lbl_Ececutor.Name = "Lbl_Ececutor";
            this.Lbl_Ececutor.Size = new System.Drawing.Size(69, 20);
            this.Lbl_Ececutor.TabIndex = 2;
            this.Lbl_Ececutor.Text = "Executor:";
            // 
            // Lbl_DueDate
            // 
            this.Lbl_DueDate.AutoSize = true;
            this.Lbl_DueDate.Location = new System.Drawing.Point(12, 135);
            this.Lbl_DueDate.Name = "Lbl_DueDate";
            this.Lbl_DueDate.Size = new System.Drawing.Size(75, 20);
            this.Lbl_DueDate.TabIndex = 3;
            this.Lbl_DueDate.Text = "Due Date:";
            // 
            // Lbl_Location
            // 
            this.Lbl_Location.AutoSize = true;
            this.Lbl_Location.Location = new System.Drawing.Point(12, 167);
            this.Lbl_Location.Name = "Lbl_Location";
            this.Lbl_Location.Size = new System.Drawing.Size(69, 20);
            this.Lbl_Location.TabIndex = 4;
            this.Lbl_Location.Text = "Location:";
            // 
            // CBB_Type
            // 
            this.CBB_Type.FormattingEnabled = true;
            this.CBB_Type.Location = new System.Drawing.Point(108, 26);
            this.CBB_Type.Name = "CBB_Type";
            this.CBB_Type.Size = new System.Drawing.Size(250, 28);
            this.CBB_Type.TabIndex = 5;
            // 
            // DTP_DueDate
            // 
            this.DTP_DueDate.Location = new System.Drawing.Point(108, 130);
            this.DTP_DueDate.Name = "DTP_DueDate";
            this.DTP_DueDate.Size = new System.Drawing.Size(250, 27);
            this.DTP_DueDate.TabIndex = 6;
            // 
            // TxtB_Name
            // 
            this.TxtB_Name.Location = new System.Drawing.Point(108, 63);
            this.TxtB_Name.Name = "TxtB_Name";
            this.TxtB_Name.Size = new System.Drawing.Size(250, 27);
            this.TxtB_Name.TabIndex = 7;
            // 
            // TxTB_Executor
            // 
            this.TxTB_Executor.Location = new System.Drawing.Point(108, 97);
            this.TxTB_Executor.Name = "TxTB_Executor";
            this.TxTB_Executor.Size = new System.Drawing.Size(250, 27);
            this.TxTB_Executor.TabIndex = 8;
            // 
            // TxTB_Location
            // 
            this.TxTB_Location.Location = new System.Drawing.Point(108, 163);
            this.TxTB_Location.Name = "TxTB_Location";
            this.TxTB_Location.Size = new System.Drawing.Size(250, 27);
            this.TxTB_Location.TabIndex = 9;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(12, 208);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Btn_Cancel.Size = new System.Drawing.Size(150, 29);
            this.Btn_Cancel.TabIndex = 10;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Create and close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Btn_Create
            // 
            this.Btn_Create.Location = new System.Drawing.Point(543, 208);
            this.Btn_Create.Name = "Btn_Create";
            this.Btn_Create.Size = new System.Drawing.Size(150, 29);
            this.Btn_Create.TabIndex = 12;
            this.Btn_Create.Text = "Create";
            this.Btn_Create.UseVisualStyleBackColor = true;
            this.Btn_Create.Click += new System.EventHandler(this.Btn_Create_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(375, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(318, 138);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // Lbl_Description
            // 
            this.Lbl_Description.AutoSize = true;
            this.Lbl_Description.Location = new System.Drawing.Point(375, 29);
            this.Lbl_Description.Name = "Lbl_Description";
            this.Lbl_Description.Size = new System.Drawing.Size(88, 20);
            this.Lbl_Description.TabIndex = 14;
            this.Lbl_Description.Text = "Description:";
            // 
            // AddToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 252);
            this.Controls.Add(this.Lbl_Description);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Btn_Create);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.TxTB_Location);
            this.Controls.Add(this.TxTB_Executor);
            this.Controls.Add(this.TxtB_Name);
            this.Controls.Add(this.DTP_DueDate);
            this.Controls.Add(this.CBB_Type);
            this.Controls.Add(this.Lbl_Location);
            this.Controls.Add(this.Lbl_DueDate);
            this.Controls.Add(this.Lbl_Ececutor);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Lbl_Type);
            this.Name = "AddToDo";
            this.Text = "AddToDo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Lbl_Type;
        private Label Lbl_Name;
        private Label Lbl_Ececutor;
        private Label Lbl_DueDate;
        private Label Lbl_Location;
        private ComboBox CBB_Type;
        private DateTimePicker DTP_DueDate;
        private TextBox TxtB_Name;
        private TextBox TxTB_Executor;
        private TextBox TxTB_Location;
        private Button Btn_Cancel;
        private Button button1;
        private Button Btn_Create;
        private RichTextBox richTextBox1;
        private Label Lbl_Description;
    }
}