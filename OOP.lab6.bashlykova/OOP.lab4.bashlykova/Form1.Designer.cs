namespace OOP.lab4.bashlykova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            tsbtnSquare = new ToolStripButton();
            tsbtnCircle = new ToolStripButton();
            tsbtnRectangle = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            tsbtnCyan = new ToolStripButton();
            tsbtnLime = new ToolStripButton();
            tsbtnYellow = new ToolStripButton();
            tsbtnRed = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            маленькийToolStripMenuItem = new ToolStripMenuItem();
            обычныйToolStripMenuItem = new ToolStripMenuItem();
            большойToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripLabel3 = new ToolStripLabel();
            toolStripLabel4 = new ToolStripLabel();
            toolStrip1 = new ToolStrip();
            toolStripLabel2 = new ToolStripSeparator();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Cursor = Cursors.Cross;
            panel1.Location = new Point(-3, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(1758, 1504);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseClick += panel1_MouseClick;
            // 
            // tsbtnSquare
            // 
            tsbtnSquare.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtnSquare.Image = (Image)resources.GetObject("tsbtnSquare.Image");
            tsbtnSquare.ImageTransparentColor = Color.Magenta;
            tsbtnSquare.Name = "tsbtnSquare";
            tsbtnSquare.Size = new Size(46, 78);
            tsbtnSquare.Text = "квадрат";
            tsbtnSquare.Click += tsbtnSquare_Click;
            // 
            // tsbtnCircle
            // 
            tsbtnCircle.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtnCircle.Image = (Image)resources.GetObject("tsbtnCircle.Image");
            tsbtnCircle.ImageTransparentColor = Color.Magenta;
            tsbtnCircle.Name = "tsbtnCircle";
            tsbtnCircle.Size = new Size(46, 78);
            tsbtnCircle.Text = "toolStripButton2";
            tsbtnCircle.Click += tsbtnCircle_Click;
            // 
            // tsbtnRectangle
            // 
            tsbtnRectangle.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtnRectangle.Image = (Image)resources.GetObject("tsbtnRectangle.Image");
            tsbtnRectangle.ImageTransparentColor = Color.Magenta;
            tsbtnRectangle.Name = "tsbtnRectangle";
            tsbtnRectangle.Size = new Size(46, 78);
            tsbtnRectangle.Text = "toolStripButton3";
            tsbtnRectangle.Click += tsbtnRectangle_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 84);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(111, 78);
            toolStripLabel1.Text = "Цвет:";
            // 
            // tsbtnCyan
            // 
            tsbtnCyan.BackColor = Color.Cyan;
            tsbtnCyan.DisplayStyle = ToolStripItemDisplayStyle.None;
            tsbtnCyan.ForeColor = SystemColors.ActiveCaptionText;
            tsbtnCyan.Image = (Image)resources.GetObject("tsbtnCyan.Image");
            tsbtnCyan.ImageTransparentColor = Color.Magenta;
            tsbtnCyan.Name = "tsbtnCyan";
            tsbtnCyan.Size = new Size(46, 78);
            tsbtnCyan.Text = "toolStripButton6";
            tsbtnCyan.Click += tsbtnCyan_Click;
            // 
            // tsbtnLime
            // 
            tsbtnLime.BackColor = Color.Lime;
            tsbtnLime.DisplayStyle = ToolStripItemDisplayStyle.None;
            tsbtnLime.Image = (Image)resources.GetObject("tsbtnLime.Image");
            tsbtnLime.ImageTransparentColor = Color.Magenta;
            tsbtnLime.Name = "tsbtnLime";
            tsbtnLime.Size = new Size(46, 78);
            tsbtnLime.Text = "toolStripButton7";
            tsbtnLime.Click += tsbtnLime_Click;
            // 
            // tsbtnYellow
            // 
            tsbtnYellow.BackColor = Color.Yellow;
            tsbtnYellow.DisplayStyle = ToolStripItemDisplayStyle.None;
            tsbtnYellow.Image = (Image)resources.GetObject("tsbtnYellow.Image");
            tsbtnYellow.ImageTransparentColor = Color.Magenta;
            tsbtnYellow.Name = "tsbtnYellow";
            tsbtnYellow.Size = new Size(46, 78);
            tsbtnYellow.Text = "toolStripButton8";
            tsbtnYellow.Click += tsbtnYellow_Click;
            // 
            // tsbtnRed
            // 
            tsbtnRed.BackColor = Color.Red;
            tsbtnRed.DisplayStyle = ToolStripItemDisplayStyle.None;
            tsbtnRed.ForeColor = SystemColors.ActiveCaptionText;
            tsbtnRed.Image = (Image)resources.GetObject("tsbtnRed.Image");
            tsbtnRed.ImageTransparentColor = Color.Magenta;
            tsbtnRed.Name = "tsbtnRed";
            tsbtnRed.Size = new Size(46, 78);
            tsbtnRed.Text = "toolStripButton9";
            tsbtnRed.Click += tsbtnRed_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 84);
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { маленькийToolStripMenuItem, обычныйToolStripMenuItem, большойToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(188, 78);
            toolStripDropDownButton1.Text = "Размер фигур";
            // 
            // маленькийToolStripMenuItem
            // 
            маленькийToolStripMenuItem.Name = "маленькийToolStripMenuItem";
            маленькийToolStripMenuItem.Size = new Size(268, 44);
            маленькийToolStripMenuItem.Text = "маленький";
            маленькийToolStripMenuItem.Click += маленькийToolStripMenuItem_Click;
            // 
            // обычныйToolStripMenuItem
            // 
            обычныйToolStripMenuItem.Name = "обычныйToolStripMenuItem";
            обычныйToolStripMenuItem.Size = new Size(268, 44);
            обычныйToolStripMenuItem.Text = "обычный";
            обычныйToolStripMenuItem.Click += обычныйToolStripMenuItem_Click;
            // 
            // большойToolStripMenuItem
            // 
            большойToolStripMenuItem.Name = "большойToolStripMenuItem";
            большойToolStripMenuItem.Size = new Size(268, 44);
            большойToolStripMenuItem.Text = "большой";
            большойToolStripMenuItem.Click += большойToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 84);
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Font = new Font("Segoe UI", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(0, 78);
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Font = new Font("Segoe UI Light", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toolStripLabel4.ForeColor = SystemColors.ActiveCaptionText;
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(46, 78);
            toolStripLabel4.Text = ".";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtnSquare, tsbtnCircle, tsbtnRectangle, toolStripSeparator1, toolStripLabel1, tsbtnCyan, tsbtnLime, tsbtnYellow, tsbtnRed, toolStripSeparator2, toolStripLabel2, toolStripDropDownButton1, toolStripSeparator3, toolStripLabel3, toolStripLabel4 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(3101, 84);
            toolStrip1.Stretch = true;
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(6, 84);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(3101, 1605);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ToolStripButton tsbtnSquare;
        private ToolStripButton tsbtnCircle;
        private ToolStripButton tsbtnRectangle;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton tsbtnCyan;
        private ToolStripButton tsbtnLime;
        private ToolStripButton tsbtnYellow;
        private ToolStripButton tsbtnRed;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel toolStripLabel3;
        private ToolStripLabel toolStripLabel4;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem маленькийToolStripMenuItem;
        private ToolStripMenuItem обычныйToolStripMenuItem;
        private ToolStripMenuItem большойToolStripMenuItem;
        private ToolStripSeparator toolStripLabel2;
    }
}
