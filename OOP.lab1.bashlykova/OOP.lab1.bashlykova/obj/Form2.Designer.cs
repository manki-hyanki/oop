namespace OOP.lab1.bashlykova.obj
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            dateTimePicker1 = new DateTimePicker();
            lblBirthDate = new Label();
            textBox1 = new TextBox();
            panelPaint = new Panel();
            listBoxFormSize = new ListBox();
            lblPaint = new Label();
            lblSizeForm = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            menuStrip1 = new MenuStrip();
            открытьОкнаToolStripMenuItem = new ToolStripMenuItem();
            окно1ToolStripMenuItem = new ToolStripMenuItem();
            окно2ToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBoxPage1 = new TextBox();
            tabPage2 = new TabPage();
            textBoxPage2 = new TextBox();
            imageList1 = new ImageList(components);
            pictureBox2 = new PictureBox();
            notifyIcon1 = new NotifyIcon(components);
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(27, 94);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 39);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dtBirthDate_ValueChanged;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(27, 50);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(359, 32);
            lblBirthDate.TabIndex = 2;
            lblBirthDate.Text = "Выберите вашу дату рождения";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 39);
            textBox1.TabIndex = 3;
            // 
            // panelPaint
            // 
            panelPaint.BackColor = SystemColors.Window;
            panelPaint.Location = new Point(27, 245);
            panelPaint.Name = "panelPaint";
            panelPaint.Size = new Size(666, 492);
            panelPaint.TabIndex = 4;
            panelPaint.MouseDown += panelPaint_MouseDown_1;
            panelPaint.MouseMove += panelPaint_MouseMove_1;
            panelPaint.MouseUp += panelPaint_MouseUp_1;
            // 
            // listBoxFormSize
            // 
            listBoxFormSize.FormattingEnabled = true;
            listBoxFormSize.Location = new Point(833, 99);
            listBoxFormSize.Name = "listBoxFormSize";
            listBoxFormSize.Size = new Size(240, 132);
            listBoxFormSize.TabIndex = 5;
            listBoxFormSize.SelectedIndexChanged += listBoxFormSize_SelectedIndexChanged;
            // 
            // lblPaint
            // 
            lblPaint.AutoSize = true;
            lblPaint.Location = new Point(289, 210);
            lblPaint.Name = "lblPaint";
            lblPaint.Size = new Size(128, 32);
            lblPaint.TabIndex = 6;
            lblPaint.Text = "Рисовалка";
            // 
            // lblSizeForm
            // 
            lblSizeForm.AutoSize = true;
            lblSizeForm.Location = new Point(833, 64);
            lblSizeForm.Name = "lblSizeForm";
            lblSizeForm.Size = new Size(158, 32);
            lblSizeForm.TabIndex = 7;
            lblSizeForm.Text = "Размер окна:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(50, 850);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(254, 36);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Включить рекламу";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(48, 895);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(268, 36);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Отключить рекламу";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton_CheckedChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { открытьОкнаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1319, 40);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // открытьОкнаToolStripMenuItem
            // 
            открытьОкнаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { окно1ToolStripMenuItem, окно2ToolStripMenuItem });
            открытьОкнаToolStripMenuItem.Name = "открытьОкнаToolStripMenuItem";
            открытьОкнаToolStripMenuItem.Size = new Size(186, 36);
            открытьОкнаToolStripMenuItem.Text = "Открыть окна";
            // 
            // окно1ToolStripMenuItem
            // 
            окно1ToolStripMenuItem.Name = "окно1ToolStripMenuItem";
            окно1ToolStripMenuItem.Size = new Size(225, 44);
            окно1ToolStripMenuItem.Text = "Окно 1";
            окно1ToolStripMenuItem.Click += окно1ToolStripMenuItem_Click;
            // 
            // окно2ToolStripMenuItem
            // 
            окно2ToolStripMenuItem.Name = "окно2ToolStripMenuItem";
            окно2ToolStripMenuItem.Size = new Size(225, 44);
            окно2ToolStripMenuItem.Text = "Окно 2";
            окно2ToolStripMenuItem.Click += окно2ToolStripMenuItem_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(746, 270);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(515, 157);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBoxPage1);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(499, 103);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxPage1
            // 
            textBoxPage1.Location = new Point(15, 39);
            textBoxPage1.Name = "textBoxPage1";
            textBoxPage1.Size = new Size(469, 39);
            textBoxPage1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBoxPage2);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(499, 103);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxPage2
            // 
            textBoxPage2.Location = new Point(9, 25);
            textBoxPage2.Name = "textBoxPage2";
            textBoxPage2.Size = new Size(484, 39);
            textBoxPage2.TabIndex = 0;
            textBoxPage2.Click += textBoxPage2_Click;
            textBoxPage2.TextChanged += textBoxPage2_TextChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "images (1).jpg");
            imageList1.Images.SetKeyName(1, "images.jpg");
            imageList1.Images.SetKeyName(2, "2261bc7d0a72005647adf48c4c032f64.jpg");
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(761, 512);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(507, 401);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "приложение";
            notifyIcon1.Visible = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1319, 1118);
            Controls.Add(pictureBox2);
            Controls.Add(tabControl1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(lblSizeForm);
            Controls.Add(lblPaint);
            Controls.Add(listBoxFormSize);
            Controls.Add(panelPaint);
            Controls.Add(textBox1);
            Controls.Add(lblBirthDate);
            Controls.Add(dateTimePicker1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Glamour";
            KeyDown += Form2_KeyDown;
            MouseDown += Form2_MouseDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label lblBirthDate;
        private TextBox textBox1;
        private Panel panelPaint;
        private ListBox listBoxFormSize;
        private Label lblPaint;
        private Label lblSizeForm;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem открытьОкнаToolStripMenuItem;
        private ToolStripMenuItem окно1ToolStripMenuItem;
        private ToolStripMenuItem окно2ToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBoxPage1;
        private TextBox textBoxPage2;
        private ImageList imageList1;
        private PictureBox pictureBox2;
        private NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
    }
}