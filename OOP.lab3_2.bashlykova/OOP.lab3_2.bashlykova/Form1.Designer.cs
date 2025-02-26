namespace OOP.lab3_2.bashlykova
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
            numA = new Label();
            comparison1 = new Label();
            numB = new Label();
            comparison2 = new Label();
            numC = new Label();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            numericUpDownA = new NumericUpDown();
            numericUpDownB = new NumericUpDown();
            numericUpDownC = new NumericUpDown();
            trackBarA = new TrackBar();
            trackBarB = new TrackBar();
            trackBarC = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarC).BeginInit();
            SuspendLayout();
            // 
            // numA
            // 
            numA.AutoSize = true;
            numA.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numA.Location = new Point(213, 67);
            numA.Name = "numA";
            numA.Size = new Size(122, 128);
            numA.TabIndex = 0;
            numA.Text = "A";
            // 
            // comparison1
            // 
            comparison1.AutoSize = true;
            comparison1.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comparison1.Location = new Point(355, 80);
            comparison1.Name = "comparison1";
            comparison1.Size = new Size(148, 100);
            comparison1.TabIndex = 1;
            comparison1.Text = "<=";
            // 
            // numB
            // 
            numB.AutoSize = true;
            numB.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numB.Location = new Point(548, 67);
            numB.Name = "numB";
            numB.Size = new Size(116, 128);
            numB.TabIndex = 2;
            numB.Text = "B";
            // 
            // comparison2
            // 
            comparison2.AutoSize = true;
            comparison2.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comparison2.Location = new Point(695, 80);
            comparison2.Name = "comparison2";
            comparison2.Size = new Size(148, 100);
            comparison2.TabIndex = 3;
            comparison2.Text = "<=";
            // 
            // numC
            // 
            numC.AutoSize = true;
            numC.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numC.Location = new Point(882, 67);
            numC.Name = "numC";
            numC.Size = new Size(114, 128);
            numC.TabIndex = 4;
            numC.Text = "C";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(145, 198);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(240, 39);
            textBoxA.TabIndex = 5;
            textBoxA.TextChanged += textBoxA_TextChanged;
            textBoxA.KeyDown += textBoxA_KeyDown;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(483, 198);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(240, 39);
            textBoxB.TabIndex = 6;
            textBoxB.TextChanged += textBoxB_TextChanged;
            textBoxB.KeyDown += textBoxB_KeyDown;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(820, 198);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(240, 39);
            textBoxC.TabIndex = 7;
            textBoxC.TextChanged += textBoxC_TextChanged;
            textBoxC.KeyDown += textBoxC_KeyDown;
            // 
            // numericUpDownA
            // 
            numericUpDownA.Location = new Point(145, 259);
            numericUpDownA.Name = "numericUpDownA";
            numericUpDownA.Size = new Size(240, 39);
            numericUpDownA.TabIndex = 8;
            numericUpDownA.ValueChanged += numericUpDownA_ValueChanged;
            // 
            // numericUpDownB
            // 
            numericUpDownB.Location = new Point(483, 259);
            numericUpDownB.Name = "numericUpDownB";
            numericUpDownB.Size = new Size(240, 39);
            numericUpDownB.TabIndex = 9;
            numericUpDownB.ValueChanged += numericUpDownB_ValueChanged;
            // 
            // numericUpDownC
            // 
            numericUpDownC.Location = new Point(820, 259);
            numericUpDownC.Name = "numericUpDownC";
            numericUpDownC.Size = new Size(240, 39);
            numericUpDownC.TabIndex = 10;
            numericUpDownC.ValueChanged += numericUpDownC_ValueChanged;
            // 
            // trackBarA
            // 
            trackBarA.BackColor = SystemColors.Control;
            trackBarA.Location = new Point(145, 335);
            trackBarA.Maximum = 100;
            trackBarA.Name = "trackBarA";
            trackBarA.Size = new Size(251, 90);
            trackBarA.TabIndex = 11;
            trackBarA.Scroll += trackBarA_Scroll;
            // 
            // trackBarB
            // 
            trackBarB.Location = new Point(483, 335);
            trackBarB.Maximum = 100;
            trackBarB.Name = "trackBarB";
            trackBarB.Size = new Size(251, 90);
            trackBarB.TabIndex = 12;
            trackBarB.Scroll += trackBarB_Scroll;
            // 
            // trackBarC
            // 
            trackBarC.Location = new Point(820, 335);
            trackBarC.Maximum = 100;
            trackBarC.Name = "trackBarC";
            trackBarC.Size = new Size(250, 90);
            trackBarC.TabIndex = 13;
            trackBarC.Scroll += trackBarC_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 523);
            Controls.Add(trackBarC);
            Controls.Add(trackBarB);
            Controls.Add(trackBarA);
            Controls.Add(numericUpDownC);
            Controls.Add(numericUpDownB);
            Controls.Add(numericUpDownA);
            Controls.Add(textBoxC);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(numC);
            Controls.Add(comparison2);
            Controls.Add(numB);
            Controls.Add(comparison1);
            Controls.Add(numA);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownC).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarA).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numA;
        private Label comparison1;
        private Label numB;
        private Label comparison2;
        private Label numC;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private NumericUpDown numericUpDownA;
        private NumericUpDown numericUpDownB;
        private NumericUpDown numericUpDownC;
        private TrackBar trackBarA;
        private TrackBar trackBarB;
        private TrackBar trackBarC;
    }
}
