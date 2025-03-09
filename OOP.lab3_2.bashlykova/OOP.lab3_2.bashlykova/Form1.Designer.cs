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
            numA.Location = new Point(115, 31);
            numA.Margin = new Padding(2, 0, 2, 0);
            numA.Name = "numA";
            numA.Size = new Size(62, 65);
            numA.TabIndex = 0;
            numA.Text = "A";
            // 
            // comparison1
            // 
            comparison1.AutoSize = true;
            comparison1.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comparison1.Location = new Point(191, 38);
            comparison1.Margin = new Padding(2, 0, 2, 0);
            comparison1.Name = "comparison1";
            comparison1.Size = new Size(76, 51);
            comparison1.TabIndex = 1;
            comparison1.Text = "<=";
            // 
            // numB
            // 
            numB.AutoSize = true;
            numB.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numB.Location = new Point(295, 31);
            numB.Margin = new Padding(2, 0, 2, 0);
            numB.Name = "numB";
            numB.Size = new Size(59, 65);
            numB.TabIndex = 2;
            numB.Text = "B";
            // 
            // comparison2
            // 
            comparison2.AutoSize = true;
            comparison2.Font = new Font("Segoe UI", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comparison2.Location = new Point(374, 38);
            comparison2.Margin = new Padding(2, 0, 2, 0);
            comparison2.Name = "comparison2";
            comparison2.Size = new Size(76, 51);
            comparison2.TabIndex = 3;
            comparison2.Text = "<=";
            // 
            // numC
            // 
            numC.AutoSize = true;
            numC.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numC.Location = new Point(475, 31);
            numC.Margin = new Padding(2, 0, 2, 0);
            numC.Name = "numC";
            numC.Size = new Size(58, 65);
            numC.TabIndex = 4;
            numC.Text = "C";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(78, 93);
            textBoxA.Margin = new Padding(2, 1, 2, 1);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(131, 23);
            textBoxA.TabIndex = 5;
            textBoxA.KeyDown += textBoxA_KeyDown;
            textBoxA.KeyPress += textBoxA_KeyPress;
            textBoxA.Leave += textBoxA_Leave;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(260, 93);
            textBoxB.Margin = new Padding(2, 1, 2, 1);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(131, 23);
            textBoxB.TabIndex = 6;
            textBoxB.KeyDown += textBoxB_KeyDown;
            textBoxB.KeyPress += textBoxB_KeyPress;
            textBoxB.Leave += textBoxB_Leave;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(442, 93);
            textBoxC.Margin = new Padding(2, 1, 2, 1);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(131, 23);
            textBoxC.TabIndex = 7;
            textBoxC.KeyDown += textBoxC_KeyDown;
            textBoxC.KeyPress += textBoxC_KeyPress;
            textBoxC.Leave += textBoxC_Leave;
            // 
            // numericUpDownA
            // 
            numericUpDownA.Location = new Point(78, 121);
            numericUpDownA.Margin = new Padding(2, 1, 2, 1);
            numericUpDownA.Name = "numericUpDownA";
            numericUpDownA.Size = new Size(129, 23);
            numericUpDownA.TabIndex = 8;
            numericUpDownA.ValueChanged += numericUpDownA_ValueChanged;
            // 
            // numericUpDownB
            // 
            numericUpDownB.Location = new Point(260, 121);
            numericUpDownB.Margin = new Padding(2, 1, 2, 1);
            numericUpDownB.Name = "numericUpDownB";
            numericUpDownB.Size = new Size(129, 23);
            numericUpDownB.TabIndex = 9;
            numericUpDownB.ValueChanged += numericUpDownB_ValueChanged;
            // 
            // numericUpDownC
            // 
            numericUpDownC.Location = new Point(442, 121);
            numericUpDownC.Margin = new Padding(2, 1, 2, 1);
            numericUpDownC.Name = "numericUpDownC";
            numericUpDownC.Size = new Size(129, 23);
            numericUpDownC.TabIndex = 10;
            numericUpDownC.ValueChanged += numericUpDownC_ValueChanged;
            // 
            // trackBarA
            // 
            trackBarA.BackColor = SystemColors.Control;
            trackBarA.Location = new Point(78, 157);
            trackBarA.Margin = new Padding(2, 1, 2, 1);
            trackBarA.Maximum = 100;
            trackBarA.Name = "trackBarA";
            trackBarA.Size = new Size(135, 45);
            trackBarA.TabIndex = 11;
            trackBarA.Scroll += trackBarA_Scroll;
            // 
            // trackBarB
            // 
            trackBarB.Location = new Point(260, 157);
            trackBarB.Margin = new Padding(2, 1, 2, 1);
            trackBarB.Maximum = 100;
            trackBarB.Name = "trackBarB";
            trackBarB.Size = new Size(135, 45);
            trackBarB.TabIndex = 12;
            trackBarB.Scroll += trackBarB_Scroll;
            // 
            // trackBarC
            // 
            trackBarC.Location = new Point(442, 157);
            trackBarC.Margin = new Padding(2, 1, 2, 1);
            trackBarC.Maximum = 100;
            trackBarC.Name = "trackBarC";
            trackBarC.Size = new Size(135, 45);
            trackBarC.TabIndex = 13;
            trackBarC.Scroll += trackBarC_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 245);
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
            Margin = new Padding(2, 1, 2, 1);
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
