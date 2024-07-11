namespace NoteTaking
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
            label1 = new Label();
            label2 = new Label();
            textTitle = new TextBox();
            textMessage = new TextBox();
            dataGridView1 = new DataGridView();
            buttonNew = new Button();
            buttonSave = new Button();
            buttonRead = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 42);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 113);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Message";
            // 
            // textTitle
            // 
            textTitle.Location = new Point(151, 34);
            textTitle.Name = "textTitle";
            textTitle.Size = new Size(216, 23);
            textTitle.TabIndex = 2;
            // 
            // textMessage
            // 
            textMessage.Location = new Point(151, 105);
            textMessage.Multiline = true;
            textMessage.Name = "textMessage";
            textMessage.Size = new Size(216, 155);
            textMessage.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(455, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(230, 226);
            dataGridView1.TabIndex = 4;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(151, 305);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(75, 23);
            buttonNew.TabIndex = 5;
            buttonNew.Text = "New";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(292, 305);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonRead
            // 
            buttonRead.Location = new Point(431, 305);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(75, 23);
            buttonRead.TabIndex = 7;
            buttonRead.Text = "Read";
            buttonRead.UseVisualStyleBackColor = true;
            buttonRead.Click += buttonRead_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(557, 305);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 389);
            Controls.Add(buttonDelete);
            Controls.Add(buttonRead);
            Controls.Add(buttonSave);
            Controls.Add(buttonNew);
            Controls.Add(dataGridView1);
            Controls.Add(textMessage);
            Controls.Add(textTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textTitle;
        private TextBox textMessage;
        private DataGridView dataGridView1;
        private Button buttonNew;
        private Button buttonSave;
        private Button buttonRead;
        private Button buttonDelete;
    }
}
