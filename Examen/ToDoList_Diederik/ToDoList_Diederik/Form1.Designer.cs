﻿namespace ToDoList_Diederik
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(569, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Geselecteerde ToDo afwerken";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(569, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "ToDo\'s importeren";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(569, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 29);
            this.button4.TabIndex = 7;
            this.button4.Text = "Groepeer per week";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(569, 235);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(219, 29);
            this.button5.TabIndex = 8;
            this.button5.Text = "Groepeer per uitvoerder";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(569, 270);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(219, 29);
            this.button6.TabIndex = 9;
            this.button6.Text = "Uitgevoerde ToDo\'s";
            this.button6.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button Btn_Refresh;
    }
}