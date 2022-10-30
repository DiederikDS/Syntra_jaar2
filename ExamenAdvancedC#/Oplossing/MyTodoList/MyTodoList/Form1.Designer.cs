namespace MyTodoList
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
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnGroupPerWeek = new System.Windows.Forms.Button();
            this.btnGroupPerExecuter = new System.Windows.Forms.Button();
            this.btnShowExecutedTodo = new System.Windows.Forms.Button();
            this.btnShowAllTodo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 20;
            this.lstItems.Location = new System.Drawing.Point(12, 29);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(440, 384);
            this.lstItems.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(458, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(241, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Todo aanmaken";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(458, 87);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(241, 29);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Geselecteerde todo afwerken";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(458, 122);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(241, 29);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Todo\'s importeren";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnGroupPerWeek
            // 
            this.btnGroupPerWeek.Location = new System.Drawing.Point(458, 215);
            this.btnGroupPerWeek.Name = "btnGroupPerWeek";
            this.btnGroupPerWeek.Size = new System.Drawing.Size(241, 29);
            this.btnGroupPerWeek.TabIndex = 4;
            this.btnGroupPerWeek.Text = "Groepeer per week";
            this.btnGroupPerWeek.UseVisualStyleBackColor = true;
            this.btnGroupPerWeek.Click += new System.EventHandler(this.btnGroupPerWeek_Click);
            // 
            // btnGroupPerExecuter
            // 
            this.btnGroupPerExecuter.Location = new System.Drawing.Point(458, 250);
            this.btnGroupPerExecuter.Name = "btnGroupPerExecuter";
            this.btnGroupPerExecuter.Size = new System.Drawing.Size(241, 29);
            this.btnGroupPerExecuter.TabIndex = 5;
            this.btnGroupPerExecuter.Text = "Groepeer per uitvoerder";
            this.btnGroupPerExecuter.UseVisualStyleBackColor = true;
            this.btnGroupPerExecuter.Click += new System.EventHandler(this.btnGroupPerExecuter_Click);
            // 
            // btnShowExecutedTodo
            // 
            this.btnShowExecutedTodo.Location = new System.Drawing.Point(458, 285);
            this.btnShowExecutedTodo.Name = "btnShowExecutedTodo";
            this.btnShowExecutedTodo.Size = new System.Drawing.Size(241, 29);
            this.btnShowExecutedTodo.TabIndex = 6;
            this.btnShowExecutedTodo.Text = "Uitgevoerde todo\'s";
            this.btnShowExecutedTodo.UseVisualStyleBackColor = true;
            this.btnShowExecutedTodo.Click += new System.EventHandler(this.btnShowExecutedTodo_Click);
            // 
            // btnShowAllTodo
            // 
            this.btnShowAllTodo.Location = new System.Drawing.Point(458, 320);
            this.btnShowAllTodo.Name = "btnShowAllTodo";
            this.btnShowAllTodo.Size = new System.Drawing.Size(241, 29);
            this.btnShowAllTodo.TabIndex = 7;
            this.btnShowAllTodo.Text = "Uit te voeren (7 dagen)";
            this.btnShowAllTodo.UseVisualStyleBackColor = true;
            this.btnShowAllTodo.Click += new System.EventHandler(this.btnShowAllTodo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "todo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Acties:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Filters:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 423);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowAllTodo);
            this.Controls.Add(this.btnShowExecutedTodo);
            this.Controls.Add(this.btnGroupPerExecuter);
            this.Controls.Add(this.btnGroupPerWeek);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstItems);
            this.Name = "Form1";
            this.Text = "Todo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstItems;
        private Button btnAdd;
        private Button btnExecute;
        private Button btnImport;
        private Button btnGroupPerWeek;
        private Button btnGroupPerExecuter;
        private Button btnShowExecutedTodo;
        private Button btnShowAllTodo;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}