namespace OOP.lab3.bashlykova
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
            PaintBox = new Panel();
            SuspendLayout();
            // 
            // PaintBox
            // 
            PaintBox.BackColor = SystemColors.Control;
            PaintBox.Location = new Point(367, 171);
            PaintBox.Name = "PaintBox";
            PaintBox.Size = new Size(1770, 1223);
            PaintBox.TabIndex = 0;
            PaintBox.Paint += PaintBox_Paint;
            PaintBox.MouseClick += PaintBox_MouseClick;
            PaintBox.Resize += PaintBox_Resize;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(2523, 1587);
            Controls.Add(PaintBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            Resize += Form1_Resize;
            ResumeLayout(false);
        }

        #endregion

        private Panel PaintBox;
    }
}
