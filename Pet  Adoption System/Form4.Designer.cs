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
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            panel8 = new Panel();
            label14 = new Label();
            label12 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            panel9 = new Panel();
            pictureBox1 = new PictureBox();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            panel13 = new Panel();
            panel7 = new Panel();
            pictureBox7 = new PictureBox();
            label6 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            pictureBox6 = new PictureBox();
            label4 = new Label();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PapayaWhip;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(213, 35);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1069, 613);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 64, 64);
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(429, 564);
            button2.Name = "button2";
            button2.Size = new Size(186, 37);
            button2.TabIndex = 21;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 64, 64);
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(637, 564);
            button3.Name = "button3";
            button3.Size = new Size(177, 37);
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
            button1.Location = new Point(221, 564);
            button1.Name = "button1";
            button1.Size = new Size(186, 37);
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
            panel8.Location = new Point(11, 11);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(1048, 79);
            panel8.TabIndex = 17;
            panel8.Paint += panel8_Paint;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(686, 4);
            label14.Name = "label14";
            label14.Size = new Size(255, 35);
            label14.TabIndex = 19;
            label14.Text = "~~ pet category ~~";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(14, 3);
            label12.Name = "label12";
            label12.Size = new Size(209, 35);
            label12.TabIndex = 18;
            label12.Text = "~~ Products ~~";
            label12.Click += label12_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 41);
            textBox1.Margin = new Padding(3, 5, 3, 5);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search an item by Name and breed...";
            textBox1.Size = new Size(662, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(686, 41);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(347, 28);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 97);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1050, 453);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // panel9
            // 
            panel9.BackColor = Color.PeachPuff;
            panel9.Controls.Add(panel7);
            panel9.Controls.Add(panel2);
            panel9.Controls.Add(panel3);
            panel9.Controls.Add(panel5);
            panel9.Controls.Add(pictureBox1);
            panel9.Location = new Point(27, 32);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(174, 616);
            panel9.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Sienna;
            panel10.Location = new Point(11, 12);
            panel10.Name = "panel10";
            panel10.Size = new Size(1289, 11);
            panel10.TabIndex = 18;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Sienna;
            panel11.Location = new Point(11, 655);
            panel11.Name = "panel11";
            panel11.Size = new Size(1288, 11);
            panel11.TabIndex = 19;
            panel11.Paint += panel11_Paint;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Sienna;
            panel12.Location = new Point(9, 12);
            panel12.Name = "panel12";
            panel12.Size = new Size(10, 653);
            panel12.TabIndex = 18;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Sienna;
            panel13.Location = new Point(1291, 12);
            panel13.Name = "panel13";
            panel13.Size = new Size(10, 653);
            panel13.TabIndex = 19;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(64, 0, 0);
            panel7.Controls.Add(pictureBox7);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(15, 383);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(144, 52);
            panel7.TabIndex = 14;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(11, 11);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(31, 33);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 11;
            pictureBox7.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(50, 16);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 11;
            label6.Text = "Logout";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 0);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(15, 181);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(144, 52);
            panel2.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(38, 16);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 5;
            label1.Text = " Dashboard";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 0, 0);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(15, 247);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(144, 48);
            panel3.TabIndex = 12;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(5, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(8, 15);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(50, 13);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 6;
            label2.Text = "Inventory";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(64, 0, 0);
            panel5.Controls.Add(pictureBox6);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(15, 311);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(144, 52);
            panel5.TabIndex = 13;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(10, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 33);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(52, 17);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 9;
            label4.Text = "Logs";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(1312, 676);
            Controls.Add(panel13);
            Controls.Add(panel12);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Panel panel8;
        private ComboBox comboBox1;
        private Label label12;
        private Panel panel9;
        private PictureBox pictureBox1;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Label label14;
        private Button button3;
        private Button button1;
        private Button button2;
        private Panel panel7;
        private PictureBox pictureBox7;
        private Label label6;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label2;
        private Panel panel5;
        private PictureBox pictureBox6;
        private Label label4;
    }
}