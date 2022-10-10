namespace ToDoList_Diederik
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
            this.LiBx_ToDoItems = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_ToDoAanmaken = new System.Windows.Forms.Button();
            this.Btn_Finish = new System.Windows.Forms.Button();
            this.Btn_ToDoImport = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LiBx_ToDoItems
            // 
            this.LiBx_ToDoItems.FormattingEnabled = true;
            this.LiBx_ToDoItems.ItemHeight = 20;
            this.LiBx_ToDoItems.Location = new System.Drawing.Point(12, 32);
            this.LiBx_ToDoItems.Name = "LiBx_ToDoItems";
            this.LiBx_ToDoItems.Size = new System.Drawing.Size(551, 404);
            this.LiBx_ToDoItems.TabIndex = 0;
            this.LiBx_ToDoItems.SelectedValueChanged += new System.EventHandler(this.LiBx_ToDoItems_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ToDo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Acties:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filters:";
            // 
            // Btn_ToDoAanmaken
            // 
            this.Btn_ToDoAanmaken.Location = new System.Drawing.Point(569, 65);
            this.Btn_ToDoAanmaken.Name = "Btn_ToDoAanmaken";
            this.Btn_ToDoAanmaken.Size = new System.Drawing.Size(219, 29);
            this.Btn_ToDoAanmaken.TabIndex = 4;
            this.Btn_ToDoAanmaken.Text = "ToDo Aanmaken";
            this.Btn_ToDoAanmaken.UseVisualStyleBackColor = true;
            this.Btn_ToDoAanmaken.Click += new System.EventHandler(this.Btn_ToDoAanmaken_Click);
            // 
            // Btn_Finish
            // 
            this.Btn_Finish.Location = new System.Drawing.Point(569, 100);
            this.Btn_Finish.Name = "Btn_Finish";
            this.Btn_Finish.Size = new System.Drawing.Size(219, 29);
            this.Btn_Finish.TabIndex = 5;
            this.Btn_Finish.Text = "Geselecteerde ToDo afwerken";
            this.Btn_Finish.UseVisualStyleBackColor = true;
            this.Btn_Finish.Click += new System.EventHandler(this.Btn_Finish_Click);
            // 
            // Btn_ToDoImport
            // 
            this.Btn_ToDoImport.Location = new System.Drawing.Point(569, 135);
            this.Btn_ToDoImport.Name = "Btn_ToDoImport";
            this.Btn_ToDoImport.Size = new System.Drawing.Size(219, 29);
            this.Btn_ToDoImport.TabIndex = 6;
            this.Btn_ToDoImport.Text = "ToDo\'s importeren";
            this.Btn_ToDoImport.UseVisualStyleBackColor = true;
            this.Btn_ToDoImport.Click += new System.EventHandler(this.Btn_ToDoImport_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(569, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 29);
            this.button4.TabIndex = 7;
            this.button4.Text = "Groepeer per week";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(569, 235);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(219, 29);
            this.button5.TabIndex = 8;
            this.button5.Text = "Groepeer per uitvoerder";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(569, 270);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(219, 29);
            this.button6.TabIndex = 9;
            this.button6.Text = "Uitgevoerde ToDo\'s";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(569, 305);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(219, 29);
            this.button7.TabIndex = 10;
            this.button7.Text = "Uit te voeren (7 dagen)";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Location = new System.Drawing.Point(569, 407);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(94, 29);
            this.Btn_Refresh.TabIndex = 11;
            this.Btn_Refresh.Text = "Refresh";
            this.Btn_Refresh.UseMnemonic = false;
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Btn_ToDoImport);
            this.Controls.Add(this.Btn_Finish);
            this.Controls.Add(this.Btn_ToDoAanmaken);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LiBx_ToDoItems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox LiBx_ToDoItems;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Btn_ToDoAanmaken;
        private Button Btn_Finish;
        private Button Btn_ToDoImport;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button Btn_Refresh;
    }
}