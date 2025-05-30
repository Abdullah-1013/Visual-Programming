namespace DataBase_Connection
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
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            numericUpDown1 = new NumericUpDown();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            button6 = new Button();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(491, 78);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(452, 237);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(470, 159);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(470, 120);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(532, 229);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(532, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(532, 112);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(12, 309);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(125, 309);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Read";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(268, 309);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(384, 309);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 11;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(532, 70);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 12;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Email";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Password";
            Column4.Name = "Column4";
            // 
            // button5
            // 
            button5.Location = new Point(491, 309);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 14;
            button5.Text = "Next";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(57, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(427, 33);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 16;
            label5.Text = "Serial Number";
            // 
            // button6
            // 
            button6.Location = new Point(57, 151);
            button6.Name = "button6";
            button6.Size = new Size(96, 23);
            button6.TabIndex = 17;
            button6.Text = "Choose Image";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(532, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(532, 190);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(434, 198);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 20;
            label6.Text = "Father Name";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(532, 267);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(442, 275);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 22;
            label7.Text = "Image URL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(numericUpDown1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private NumericUpDown numericUpDown1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button5;
        private PictureBox pictureBox1;
        private Label label5;
        private Button button6;
        private TextBox textBox1;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
    }
}
