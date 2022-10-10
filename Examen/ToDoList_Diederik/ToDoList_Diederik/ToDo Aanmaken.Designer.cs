namespace ToDoList_Diederik
{
    partial class ToDo_Aanmaken
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtB_Name = new System.Windows.Forms.TextBox();
            this.TxtB_Location = new System.Windows.Forms.TextBox();
            this.TxtB_Executor = new System.Windows.Forms.TextBox();
            this.DTP_Due = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.RTB_Description = new System.Windows.Forms.RichTextBox();
            this.CoBx_Types = new System.Windows.Forms.ComboBox();
            this.Btn_Create = new System.Windows.Forms.Button();
            this.Btn_Cancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uitvoerder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Uitvoer datum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Locatie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Omschrijving";
            // 
            // TxtB_Name
            // 
            this.TxtB_Name.Location = new System.Drawing.Point(138, 59);
            this.TxtB_Name.Name = "TxtB_Name";
            this.TxtB_Name.Size = new System.Drawing.Size(250, 27);
            this.TxtB_Name.TabIndex = 6;
            // 
            // TxtB_Location
            // 
            this.TxtB_Location.Location = new System.Drawing.Point(138, 158);
            this.TxtB_Location.Name = "TxtB_Location";
            this.TxtB_Location.Size = new System.Drawing.Size(250, 27);
            this.TxtB_Location.TabIndex = 8;
            // 
            // TxtB_Executor
            // 
            this.TxtB_Executor.Location = new System.Drawing.Point(138, 92);
            this.TxtB_Executor.Name = "TxtB_Executor";
            this.TxtB_Executor.Size = new System.Drawing.Size(250, 27);
            this.TxtB_Executor.TabIndex = 9;
            // 
            // DTP_Due
            // 
            this.DTP_Due.Location = new System.Drawing.Point(138, 125);
            this.DTP_Due.Name = "DTP_Due";
            this.DTP_Due.Size = new System.Drawing.Size(250, 27);
            this.DTP_Due.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(407, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 29);
            this.button3.TabIndex = 13;
            this.button3.Text = "Aanmaken en sluiten";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // RTB_Description
            // 
            this.RTB_Description.Location = new System.Drawing.Point(407, 59);
            this.RTB_Description.Name = "RTB_Description";
            this.RTB_Description.Size = new System.Drawing.Size(290, 126);
            this.RTB_Description.TabIndex = 14;
            this.RTB_Description.Text = "";
            // 
            // CoBx_Types
            // 
            this.CoBx_Types.FormattingEnabled = true;
            this.CoBx_Types.Location = new System.Drawing.Point(138, 25);
            this.CoBx_Types.Name = "CoBx_Types";
            this.CoBx_Types.Size = new System.Drawing.Size(250, 28);
            this.CoBx_Types.TabIndex = 15;
            // 
            // Btn_Create
            // 
            this.Btn_Create.Location = new System.Drawing.Point(603, 191);
            this.Btn_Create.Name = "Btn_Create";
            this.Btn_Create.Size = new System.Drawing.Size(94, 29);
            this.Btn_Create.TabIndex = 16;
            this.Btn_Create.Text = "Aanmaken";
            this.Btn_Create.UseVisualStyleBackColor = true;
            this.Btn_Create.Click += new System.EventHandler(this.Btn_Create_Click);
            // 
            // Btn_Cancle
            // 
            this.Btn_Cancle.Location = new System.Drawing.Point(15, 191);
            this.Btn_Cancle.Name = "Btn_Cancle";
            this.Btn_Cancle.Size = new System.Drawing.Size(94, 29);
            this.Btn_Cancle.TabIndex = 17;
            this.Btn_Cancle.Text = "Annuleren";
            this.Btn_Cancle.UseVisualStyleBackColor = true;
            this.Btn_Cancle.Click += new System.EventHandler(this.Btn_Cancle_Click);
            // 
            // ToDo_Aanmaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 238);
            this.Controls.Add(this.Btn_Cancle);
            this.Controls.Add(this.Btn_Create);
            this.Controls.Add(this.CoBx_Types);
            this.Controls.Add(this.RTB_Description);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DTP_Due);
            this.Controls.Add(this.TxtB_Executor);
            this.Controls.Add(this.TxtB_Location);
            this.Controls.Add(this.TxtB_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ToDo_Aanmaken";
            this.Text = "ToDo_Aanmaken";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TxtB_Name;
        private TextBox TxtB_Location;
        private TextBox TxtB_Executor;
        private DateTimePicker DTP_Due;
        private Button button3;
        private RichTextBox RTB_Description;
        private ComboBox CoBx_Types;
        private Button Btn_Create;
        private Button Btn_Cancle;
    }
}