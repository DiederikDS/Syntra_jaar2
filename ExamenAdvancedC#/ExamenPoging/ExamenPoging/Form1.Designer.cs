namespace ExamenPoging
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LV_ToDo = new System.Windows.Forms.ListView();
            this.Btn_CreateToDo = new System.Windows.Forms.Button();
            this.Btn_FinishSelToDo = new System.Windows.Forms.Button();
            this.Btn_ImportToDo = new System.Windows.Forms.Button();
            this.Btn_SortByWeek = new System.Windows.Forms.Button();
            this.Btn_SortByExecutor = new System.Windows.Forms.Button();
            this.Btn_SortByFinished = new System.Windows.Forms.Button();
            this.Btn_SortByToBeExecuted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ToDo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Actions:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filters";
            // 
            // LV_ToDo
            // 
            this.LV_ToDo.Location = new System.Drawing.Point(14, 36);
            this.LV_ToDo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LV_ToDo.Name = "LV_ToDo";
            this.LV_ToDo.Size = new System.Drawing.Size(581, 547);
            this.LV_ToDo.TabIndex = 3;
            this.LV_ToDo.UseCompatibleStateImageBehavior = false;
            // 
            // Btn_CreateToDo
            // 
            this.Btn_CreateToDo.Location = new System.Drawing.Point(613, 60);
            this.Btn_CreateToDo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_CreateToDo.Name = "Btn_CreateToDo";
            this.Btn_CreateToDo.Size = new System.Drawing.Size(288, 31);
            this.Btn_CreateToDo.TabIndex = 4;
            this.Btn_CreateToDo.Text = "Create ToDo";
            this.Btn_CreateToDo.UseVisualStyleBackColor = true;
            this.Btn_CreateToDo.Click += new System.EventHandler(this.Btn_CreateToDo_Click);
            // 
            // Btn_FinishSelToDo
            // 
            this.Btn_FinishSelToDo.Location = new System.Drawing.Point(613, 99);
            this.Btn_FinishSelToDo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_FinishSelToDo.Name = "Btn_FinishSelToDo";
            this.Btn_FinishSelToDo.Size = new System.Drawing.Size(288, 31);
            this.Btn_FinishSelToDo.TabIndex = 5;
            this.Btn_FinishSelToDo.Text = "Finish selected ToDo";
            this.Btn_FinishSelToDo.UseVisualStyleBackColor = true;
            // 
            // Btn_ImportToDo
            // 
            this.Btn_ImportToDo.Location = new System.Drawing.Point(613, 137);
            this.Btn_ImportToDo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_ImportToDo.Name = "Btn_ImportToDo";
            this.Btn_ImportToDo.Size = new System.Drawing.Size(288, 31);
            this.Btn_ImportToDo.TabIndex = 6;
            this.Btn_ImportToDo.Text = "Import";
            this.Btn_ImportToDo.UseVisualStyleBackColor = true;
            // 
            // Btn_SortByWeek
            // 
            this.Btn_SortByWeek.Location = new System.Drawing.Point(613, 209);
            this.Btn_SortByWeek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_SortByWeek.Name = "Btn_SortByWeek";
            this.Btn_SortByWeek.Size = new System.Drawing.Size(288, 31);
            this.Btn_SortByWeek.TabIndex = 7;
            this.Btn_SortByWeek.Text = "Sort by week";
            this.Btn_SortByWeek.UseVisualStyleBackColor = true;
            // 
            // Btn_SortByExecutor
            // 
            this.Btn_SortByExecutor.Location = new System.Drawing.Point(613, 248);
            this.Btn_SortByExecutor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_SortByExecutor.Name = "Btn_SortByExecutor";
            this.Btn_SortByExecutor.Size = new System.Drawing.Size(288, 31);
            this.Btn_SortByExecutor.TabIndex = 8;
            this.Btn_SortByExecutor.Text = "Sort by executor";
            this.Btn_SortByExecutor.UseVisualStyleBackColor = true;
            // 
            // Btn_SortByFinished
            // 
            this.Btn_SortByFinished.Location = new System.Drawing.Point(613, 287);
            this.Btn_SortByFinished.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_SortByFinished.Name = "Btn_SortByFinished";
            this.Btn_SortByFinished.Size = new System.Drawing.Size(288, 31);
            this.Btn_SortByFinished.TabIndex = 9;
            this.Btn_SortByFinished.Text = "Sort by finished";
            this.Btn_SortByFinished.UseVisualStyleBackColor = true;
            // 
            // Btn_SortByToBeExecuted
            // 
            this.Btn_SortByToBeExecuted.Location = new System.Drawing.Point(613, 325);
            this.Btn_SortByToBeExecuted.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_SortByToBeExecuted.Name = "Btn_SortByToBeExecuted";
            this.Btn_SortByToBeExecuted.Size = new System.Drawing.Size(288, 31);
            this.Btn_SortByToBeExecuted.TabIndex = 10;
            this.Btn_SortByToBeExecuted.Text = "Sort by to be executed";
            this.Btn_SortByToBeExecuted.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.Btn_SortByToBeExecuted);
            this.Controls.Add(this.Btn_SortByFinished);
            this.Controls.Add(this.Btn_SortByExecutor);
            this.Controls.Add(this.Btn_SortByWeek);
            this.Controls.Add(this.Btn_ImportToDo);
            this.Controls.Add(this.Btn_FinishSelToDo);
            this.Controls.Add(this.Btn_CreateToDo);
            this.Controls.Add(this.LV_ToDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListView LV_ToDo;
        private Button Btn_CreateToDo;
        private Button Btn_FinishSelToDo;
        private Button Btn_ImportToDo;
        private Button Btn_SortByWeek;
        private Button Btn_SortByExecutor;
        private Button Btn_SortByFinished;
        private Button Btn_SortByToBeExecuted;
    }
}