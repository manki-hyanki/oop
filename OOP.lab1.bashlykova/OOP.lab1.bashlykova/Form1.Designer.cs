namespace OOP.lab1.bashlykova
{
    partial class FormStart
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            btnGlamour = new Button();
            label1 = new Label();
            chBmouse_tracking = new CheckBox();
            lblCoorX = new Label();
            lblCoorY = new Label();
            lblX = new Label();
            lblY = new Label();
            сhLBquestion = new CheckedListBox();
            lblListBox = new Label();
            btnCheckListBox = new Button();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            btnImageSize = new Button();
            picBoxCats = new PictureBox();
            btnReady = new Button();
            menuStrip1 = new MenuStrip();
            открытьОкноToolStripMenuItem = new ToolStripMenuItem();
            открытьОкно1ToolStripMenuItem = new ToolStripMenuItem();
            открытьОкно2ToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)picBoxCats).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGlamour
            // 
            btnGlamour.BackColor = Color.LightPink;
            btnGlamour.Location = new Point(765, 153);
            btnGlamour.Name = "btnGlamour";
            btnGlamour.Size = new Size(150, 46);
            btnGlamour.TabIndex = 0;
            btnGlamour.Text = "Glamour?";
            btnGlamour.UseVisualStyleBackColor = false;
            btnGlamour.Click += btnGlamour_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Pink;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 26F);
            label1.ForeColor = Color.PaleVioletRed;
            label1.Location = new Point(625, 40);
            label1.Name = "label1";
            label1.Size = new Size(449, 95);
            label1.TabIndex = 1;
            label1.Text = "glamour.com";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chBmouse_tracking
            // 
            chBmouse_tracking.AutoSize = true;
            chBmouse_tracking.Location = new Point(45, 303);
            chBmouse_tracking.Name = "chBmouse_tracking";
            chBmouse_tracking.Size = new Size(201, 36);
            chBmouse_tracking.TabIndex = 2;
            chBmouse_tracking.Text = "абьюз мышки";
            chBmouse_tracking.UseVisualStyleBackColor = true;
            chBmouse_tracking.CheckedChanged += chBmouse_tracking_CheckedChanged;
            // 
            // lblCoorX
            // 
            lblCoorX.AutoSize = true;
            lblCoorX.Location = new Point(109, 342);
            lblCoorX.Name = "lblCoorX";
            lblCoorX.Size = new Size(0, 32);
            lblCoorX.TabIndex = 3;
            // 
            // lblCoorY
            // 
            lblCoorY.AutoSize = true;
            lblCoorY.Location = new Point(109, 385);
            lblCoorY.Name = "lblCoorY";
            lblCoorY.Size = new Size(0, 32);
            lblCoorY.TabIndex = 4;
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Location = new Point(70, 342);
            lblX.Name = "lblX";
            lblX.Size = new Size(33, 32);
            lblX.TabIndex = 5;
            lblX.Text = "X:";
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Location = new Point(70, 385);
            lblY.Name = "lblY";
            lblY.Size = new Size(32, 32);
            lblY.TabIndex = 6;
            lblY.Text = "Y:";
            // 
            // сhLBquestion
            // 
            сhLBquestion.FormattingEnabled = true;
            сhLBquestion.Location = new Point(45, 494);
            сhLBquestion.Name = "сhLBquestion";
            сhLBquestion.Size = new Size(240, 148);
            сhLBquestion.TabIndex = 7;
            // 
            // lblListBox
            // 
            lblListBox.AutoSize = true;
            lblListBox.Location = new Point(47, 449);
            lblListBox.Name = "lblListBox";
            lblListBox.Size = new Size(227, 32);
            lblListBox.TabIndex = 8;
            lblListBox.Text = "Кого вы выберете?";
            // 
            // btnCheckListBox
            // 
            btnCheckListBox.Location = new Point(70, 648);
            btnCheckListBox.Name = "btnCheckListBox";
            btnCheckListBox.Size = new Size(150, 46);
            btnCheckListBox.TabIndex = 9;
            btnCheckListBox.Text = "Проверить";
            btnCheckListBox.UseVisualStyleBackColor = true;
            btnCheckListBox.Click += btnCheckListBox_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(409, 1068);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(845, 46);
            progressBar1.TabIndex = 10;
            // 
            // btnImageSize
            // 
            btnImageSize.Location = new Point(866, 890);
            btnImageSize.Name = "btnImageSize";
            btnImageSize.Size = new Size(438, 46);
            btnImageSize.TabIndex = 11;
            btnImageSize.Text = "Изменить размер изображения";
            btnImageSize.UseVisualStyleBackColor = true;
            btnImageSize.Click += btnImageSize_Click;
            // 
            // picBoxCats
            // 
            picBoxCats.Image = (Image)resources.GetObject("picBoxCats.Image");
            picBoxCats.Location = new Point(461, 303);
            picBoxCats.Name = "picBoxCats";
            picBoxCats.Size = new Size(1222, 571);
            picBoxCats.TabIndex = 12;
            picBoxCats.TabStop = false;
            // 
            // btnReady
            // 
            btnReady.Location = new Point(765, 1132);
            btnReady.Name = "btnReady";
            btnReady.Size = new Size(150, 46);
            btnReady.TabIndex = 13;
            btnReady.Text = "Готово!";
            btnReady.UseVisualStyleBackColor = true;
            btnReady.Click += btnReady_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { открытьОкноToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1704, 40);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // открытьОкноToolStripMenuItem
            // 
            открытьОкноToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьОкно1ToolStripMenuItem, открытьОкно2ToolStripMenuItem });
            открытьОкноToolStripMenuItem.Name = "открытьОкноToolStripMenuItem";
            открытьОкноToolStripMenuItem.Size = new Size(186, 36);
            открытьОкноToolStripMenuItem.Text = "Открыть окна";
            // 
            // открытьОкно1ToolStripMenuItem
            // 
            открытьОкно1ToolStripMenuItem.Name = "открытьОкно1ToolStripMenuItem";
            открытьОкно1ToolStripMenuItem.Size = new Size(218, 44);
            открытьОкно1ToolStripMenuItem.Text = "Окно1";
            открытьОкно1ToolStripMenuItem.Click += открытьОкно1ToolStripMenuItem_Click;
            // 
            // открытьОкно2ToolStripMenuItem
            // 
            открытьОкно2ToolStripMenuItem.Name = "открытьОкно2ToolStripMenuItem";
            открытьОкно2ToolStripMenuItem.Size = new Size(218, 44);
            открытьОкно2ToolStripMenuItem.Text = "Окно2";
            открытьОкно2ToolStripMenuItem.Click += открытьОкно2ToolStripMenuItem_Click;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1704, 1224);
            Controls.Add(btnReady);
            Controls.Add(picBoxCats);
            Controls.Add(btnImageSize);
            Controls.Add(progressBar1);
            Controls.Add(btnCheckListBox);
            Controls.Add(lblListBox);
            Controls.Add(сhLBquestion);
            Controls.Add(lblY);
            Controls.Add(lblX);
            Controls.Add(lblCoorY);
            Controls.Add(lblCoorX);
            Controls.Add(chBmouse_tracking);
            Controls.Add(label1);
            Controls.Add(btnGlamour);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormStart";
            Text = "Glamour";
            MouseMove += FormStart_MouseMove;
            ((System.ComponentModel.ISupportInitialize)picBoxCats).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGlamour;
        private Label label1;
        private CheckBox chBmouse_tracking;
        private Label lblCoorX;
        private Label lblCoorY;
        private Label lblX;
        private Label lblY;
        private CheckedListBox сhLBquestion;
        private Label lblListBox;
        private Button btnCheckListBox;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Button btnImageSize;
        private PictureBox picBoxCats;
        private Button btnReady;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem открытьОкноToolStripMenuItem;
        private ToolStripMenuItem открытьОкно1ToolStripMenuItem;
        private ToolStripMenuItem открытьОкно2ToolStripMenuItem;
    }
}
