namespace Pet__Adoption_System
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            panel1 = new Panel();
            button3 = new Button();
            button1 = new Button();
            panel8 = new Panel();
            label14 = new Label();
            label12 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            panel9 = new Panel();
            panel7 = new Panel();
            pictureBox7 = new PictureBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel6 = new Panel();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            pictureBox6 = new PictureBox();
            label13 = new Label();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            panel13 = new Panel();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PapayaWhip;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(186, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(935, 460);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 64, 64);
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(557, 423);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(155, 28);
            button3.TabIndex = 20;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 64, 64);
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(193, 423);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(163, 28);
            button1.TabIndex = 18;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel8
            // 
            panel8.BackColor = Color.PeachPuff;
            panel8.Controls.Add(label14);
            panel8.Controls.Add(label12);
            panel8.Controls.Add(textBox1);
            panel8.Controls.Add(comboBox1);
            panel8.Location = new Point(10, 8);
            panel8.Name = "panel8";
            panel8.Size = new Size(917, 59);
            panel8.TabIndex = 17;
            panel8.Paint += panel8_Paint;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(600, 3);
            label14.Name = "label14";
            label14.Size = new Size(207, 28);
            label14.TabIndex = 19;
            label14.Text = "~~ pet category ~~";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(12, 2);
            label12.Name = "label12";
            label12.Size = new Size(170, 28);
            label12.TabIndex = 18;
            label12.Text = "~~ Products ~~";
            label12.Click += label12_Click;
            // 
            // textBox1
            // 

            textBox1.Location = new Point(14, 40);
            textBox1.Margin = new Padding(3, 4, 3, 4);

            textBox1.Location = new Point(12, 31);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search an item by Name and breed...";
            textBox1.Size = new Size(580, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(600, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(304, 23);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(919, 340);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // panel9
            // 
            panel9.BackColor = Color.PeachPuff;
            panel9.Controls.Add(panel7);
            panel9.Controls.Add(pictureBox1);
            panel9.Controls.Add(panel2);
            panel9.Controls.Add(panel6);
            panel9.Controls.Add(panel3);
            panel9.Controls.Add(panel5);
            panel9.Location = new Point(24, 24);
            panel9.Name = "panel9";
            panel9.Size = new Size(152, 462);
            panel9.TabIndex = 17;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(128, 64, 64);
            panel7.Controls.Add(pictureBox7);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(12, 394);
            panel7.Name = "panel7";
            panel7.Size = new Size(126, 39);
            panel7.TabIndex = 7;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(10, 8);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(27, 25);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 11;
            pictureBox7.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(38, 12);
            label6.Name = "label6";
            label6.Size = new Size(52, 17);
            label6.TabIndex = 11;
            label6.Text = "Logout";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 14);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 64, 64);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(14, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(126, 39);
            panel2.TabIndex = 0;
            panel2.Click += label1_Click;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, 9);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(23, 12);
            label1.Name = "label1";
            label1.Size = new Size(82, 17);
            label1.TabIndex = 5;
            label1.Text = " Dashboard";
            label1.Click += label1_Click_1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(128, 64, 64);
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(12, 306);
            panel6.Name = "panel6";
            panel6.Size = new Size(126, 39);
            panel6.TabIndex = 6;
            panel6.Click += label5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(11, 9);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(27, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(36, 13);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 10;
            label5.Text = " Billings";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(128, 64, 64);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(13, 192);
            panel3.Name = "panel3";
            panel3.Size = new Size(126, 36);
            panel3.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(4, 2);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(7, 11);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(33, 10);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 6;
            label2.Text = "Inventory";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(128, 64, 64);
            panel5.Controls.Add(pictureBox6);
            panel5.Controls.Add(label13);
            panel5.Location = new Point(12, 246);
            panel5.Name = "panel5";
            panel5.Size = new Size(126, 39);
            panel5.TabIndex = 6;
            panel5.Click += label4_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(9, 9);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(27, 25);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ButtonFace;
            label13.Location = new Point(37, 13);
            label13.Name = "label13";
            label13.Size = new Size(39, 17);
            label13.TabIndex = 9;
            label13.Text = "Logs";
            label13.Click += label13_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Sienna;
            panel10.Location = new Point(10, 9);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(1128, 8);
            panel10.TabIndex = 18;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Sienna;
            panel11.Location = new Point(10, 491);
            panel11.Margin = new Padding(3, 2, 3, 2);
            panel11.Name = "panel11";
            panel11.Size = new Size(1127, 8);
            panel11.TabIndex = 19;
            panel11.Paint += panel11_Paint;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Sienna;
            panel12.Location = new Point(8, 9);
            panel12.Margin = new Padding(3, 2, 3, 2);
            panel12.Name = "panel12";
            panel12.Size = new Size(9, 490);
            panel12.TabIndex = 18;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Sienna;
            panel13.Location = new Point(1130, 9);
            panel13.Margin = new Padding(3, 2, 3, 2);
            panel13.Name = "panel13";
            panel13.Size = new Size(9, 490);
            panel13.TabIndex = 19;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(1148, 507);
            Controls.Add(panel13);
            Controls.Add(panel12);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel9.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private Label label6;
        private Panel panel3;
        private Label label2;
        private Panel panel6;
        private Label label5;
        private Panel panel5;
        private Label label3;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Panel panel8;
        private ComboBox comboBox1;
        private Label label12;
        private Panel panel9;
        private PictureBox pictureBox7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private Label label13;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Label label14;
        private Button button3;
        private Button button1;
    }
}