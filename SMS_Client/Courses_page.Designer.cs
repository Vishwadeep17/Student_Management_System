namespace SMS_Client
{
    partial class Courses_page
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            button5 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            button4 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(472, 31);
            label1.Name = "label1";
            label1.Size = new Size(82, 17);
            label1.TabIndex = 0;
            label1.Text = "COURSES";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(296, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(440, 214);
            dataGridView1.TabIndex = 1;
           //dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(268, 303);
            button1.Name = "button1";
            button1.Size = new Size(94, 25);
            button1.TabIndex = 2;
            button1.Text = "Add Course";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(451, 303);
            button2.Name = "button2";
            button2.Size = new Size(124, 25);
            button2.TabIndex = 3;
            button2.Text = "Update Course";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(656, 303);
            button3.Name = "button3";
            button3.Size = new Size(117, 25);
            button3.TabIndex = 4;
            button3.Text = "Delete Course";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 371);
            panel1.TabIndex = 5;
            // 
            // button5
            // 
            button5.Location = new Point(19, 227);
            button5.Name = "button5";
            button5.Size = new Size(114, 52);
            button5.TabIndex = 5;
            button5.Text = "Upload Documents";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(18, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 25);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 65);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 3;
            label3.Text = "Course ID :";
            // 
            // button4
            // 
            button4.Location = new Point(24, 310);
            button4.Name = "button4";
            button4.Size = new Size(94, 25);
            button4.TabIndex = 2;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 25);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 131);
            label2.Name = "label2";
            label2.Size = new Size(107, 17);
            label2.TabIndex = 0;
            label2.Text = "Course Name :";
            // 
            // Courses_page
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 382);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Courses_page";
            Text = "Courses_page";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Button button4;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Button button5;
    }
}