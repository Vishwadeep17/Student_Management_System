namespace SMS_Client
{
    partial class Grades_page
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
            panel1 = new Panel();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 447);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(93, 374);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AA", "AB", "BB", "BC", "CC", "CD", "FF" });
            comboBox1.Location = new Point(41, 210);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 187);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Grades :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 99);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter a Student ID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 35);
            label1.Name = "label1";
            label1.Size = new Size(226, 20);
            label1.TabIndex = 0;
            label1.Text = "Add / Update Grades info. Here :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(452, 46);
            label4.Name = "label4";
            label4.Size = new Size(201, 20);
            label4.TabIndex = 3;
            label4.Text = "GRADES LIST OF STUDENTS :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(354, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(399, 188);
            dataGridView1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(391, 330);
            button3.Name = "button3";
            button3.Size = new Size(135, 29);
            button3.TabIndex = 6;
            button3.Text = "UPDATE Grades";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(576, 330);
            button4.Name = "button4";
            button4.Size = new Size(122, 29);
            button4.TabIndex = 7;
            button4.Text = "DELETE Grades";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Grades_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Grades_page";
            Text = "Grades_page";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
    }
}