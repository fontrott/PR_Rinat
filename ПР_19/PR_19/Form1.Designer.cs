namespace PR_19
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.Label labelArea1;
        private System.Windows.Forms.Label labelArea2;
        private System.Windows.Forms.Button buttonCalculate;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxX = new TextBox();
            textBoxY = new TextBox();
            textBoxZ = new TextBox();
            labelArea1 = new Label();
            labelArea2 = new Label();
            buttonCalculate = new Button();
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            рассчитатьToolStripMenuItem = new ToolStripMenuItem();
            очиститьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            оСправкеToolStripMenuItem = new ToolStripMenuItem();
            buttonExit = new Button();
            Расчеты = new TabPage();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            tabControl1 = new TabControl();
            menuStrip1.SuspendLayout();
            Расчеты.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(42, 176);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(88, 23);
            textBoxX.TabIndex = 0;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(42, 202);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(88, 23);
            textBoxY.TabIndex = 1;
            // 
            // textBoxZ
            // 
            textBoxZ.Location = new Point(236, 176);
            textBoxZ.Name = "textBoxZ";
            textBoxZ.Size = new Size(88, 23);
            textBoxZ.TabIndex = 3;
            // 
            // labelArea1
            // 
            labelArea1.AutoSize = true;
            labelArea1.Location = new Point(9, 330);
            labelArea1.Name = "labelArea1";
            labelArea1.Size = new Size(0, 15);
            labelArea1.TabIndex = 6;
            // 
            // labelArea2
            // 
            labelArea2.AutoSize = true;
            labelArea2.Location = new Point(9, 355);
            labelArea2.Name = "labelArea2";
            labelArea2.Size = new Size(0, 15);
            labelArea2.TabIndex = 7;
            // 
            // buttonCalculate
            // 
            buttonCalculate.BackColor = SystemColors.Control;
            buttonCalculate.Location = new Point(76, 372);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(88, 22);
            buttonCalculate.TabIndex = 8;
            buttonCalculate.Text = "Рассчитать";
            buttonCalculate.UseVisualStyleBackColor = false;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Location = new Point(12, 230);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 9;
            label1.Text = "X =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Location = new Point(12, 256);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 10;
            label2.Text = "Y = ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientInactiveCaption;
            label7.Location = new Point(11, 193);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 15;
            label7.Text = "Исходные данные:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.GradientInactiveCaption;
            label8.Location = new Point(209, 193);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 16;
            label8.Text = "Результат:";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, оСправкеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(383, 24);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { рассчитатьToolStripMenuItem, очиститьToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // рассчитатьToolStripMenuItem
            // 
            рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
            рассчитатьToolStripMenuItem.Size = new Size(135, 22);
            рассчитатьToolStripMenuItem.Text = "Рассчитать";
            рассчитатьToolStripMenuItem.Click += рассчитатьToolStripMenuItem_Click;
            // 
            // очиститьToolStripMenuItem
            // 
            очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            очиститьToolStripMenuItem.Size = new Size(135, 22);
            очиститьToolStripMenuItem.Text = "Очистить";
            очиститьToolStripMenuItem.Click += очиститьToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(135, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // оСправкеToolStripMenuItem
            // 
            оСправкеToolStripMenuItem.Name = "оСправкеToolStripMenuItem";
            оСправкеToolStripMenuItem.Size = new Size(65, 20);
            оСправкеToolStripMenuItem.Text = "Справка";
            оСправкеToolStripMenuItem.Click += оСправкеToolStripMenuItem_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = SystemColors.Control;
            buttonExit.Location = new Point(208, 372);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(88, 22);
            buttonExit.TabIndex = 18;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // Расчеты
            // 
            Расчеты.BackColor = SystemColors.GradientInactiveCaption;
            Расчеты.Controls.Add(label3);
            Расчеты.Controls.Add(pictureBox1);
            Расчеты.Controls.Add(label9);
            Расчеты.Controls.Add(textBoxZ);
            Расчеты.Controls.Add(textBoxX);
            Расчеты.Controls.Add(textBoxY);
            Расчеты.Location = new Point(4, 24);
            Расчеты.Name = "Расчеты";
            Расчеты.Padding = new Padding(3);
            Расчеты.Size = new Size(375, 350);
            Расчеты.TabIndex = 0;
            Расчеты.Text = "Расчеты";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Location = new Point(205, 179);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 20;
            label3.Text = "Z =";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.photo_2024_07_07_18_00_00;
            pictureBox1.Location = new Point(1, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(374, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.GradientInactiveCaption;
            label9.Location = new Point(31, 13);
            label9.Name = "label9";
            label9.Size = new Size(316, 15);
            label9.TabIndex = 0;
            label9.Text = "Рассчитать значение выражения при исходных данных:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Расчеты);
            tabControl1.Location = new Point(0, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(383, 378);
            tabControl1.TabIndex = 19;
            tabControl1.Tag = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 406);
            Controls.Add(buttonExit);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCalculate);
            Controls.Add(labelArea2);
            Controls.Add(labelArea1);
            Controls.Add(menuStrip1);
            Controls.Add(tabControl1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Мое приложение";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            Расчеты.ResumeLayout(false);
            Расчеты.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label7;
        private Label label8;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem рассчитатьToolStripMenuItem;
        private ToolStripMenuItem очиститьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem оСправкеToolStripMenuItem;
        private Button buttonExit;
        private TabPage tabPage2;
        private TabPage Расчеты;
        private TabControl tabControl1;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label3;
    }
}
