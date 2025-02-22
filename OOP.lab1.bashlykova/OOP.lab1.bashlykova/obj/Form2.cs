using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace OOP.lab1.bashlykova.obj
{
    public partial class Form2 : Form
    {
        private bool isDrawing = false;
        private Point lastpoint;
        private int currentIndex = 0;
        private int counter = 0;
        public Form2()
        {
            InitializeComponent();

            notifyIcon1.Icon = SystemIcons.Application;

            listBoxFormSize.Items.Add("Маленький размер");
            listBoxFormSize.Items.Add("Средний размер");
            listBoxFormSize.Items.Add("Большой размер");

            RadioButton radioButton1 = new RadioButton();
            RadioButton radioButton2 = new RadioButton();

            pictureBox2.Image = imageList1.Images[currentIndex];


            this.KeyPreview = true;

            timer1.Interval = 5000;
            timer1.Start();


        }




        private void dtBirthDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime SelectedDate = dateTimePicker1.Value;
            DateTime Today = DateTime.Today;
            int age = Today.Year - dateTimePicker1.Value.Year;
            textBox1.Text = $"В этом году Вам исполнится(-сь) {age}";
        }

        private void panelPaint_MouseDown_1(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            lastpoint = e.Location;
        }

        private void panelPaint_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = panelPaint.CreateGraphics())
                {
                    g.DrawLine(Pens.Pink, lastpoint, e.Location);
                }
                lastpoint = e.Location;
            }
        }

        private void panelPaint_MouseUp_1(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void listBoxFormSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedSize = listBoxFormSize.SelectedItem.ToString();
            if (SelectedSize == "Маленький размер")
            {
                this.Size = new Size(1300, 900);
            }
            else if (SelectedSize == "Средний размер")
            {
                this.Size = new Size(1600, 1200);
            }
            else if (SelectedSize == "Большой размер")
            {
                this.Size = new Size(2000, 1500);
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = new Button();
            btn.Size = new Size(150, 46);
            btn.BackColor = Color.White;
            btn.Location = new Point(e.X - btn.Size.Width / 2, e.Y - btn.Size.Height / 2);
            btn.Click += btn_Click;
            this.Controls.Add(btn);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls.OfType<Button>().ToList())
            {
                this.Controls.Remove(control);
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                MessageBox.Show($"{rb.Text} (выбрано).");
            }
        }

        private void окно1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStart frm1 = new FormStart();
            frm1.Show();
            this.Hide();
        }

        private void окно2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }





        private void textBoxPage2_Click(object sender, EventArgs e)
        {
            textBoxPage2.Text = " ";
        }

        private void textBoxPage2_TextChanged(object sender, EventArgs e)
        {
            textBoxPage1.Text = textBoxPage2.Text;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                currentIndex = (currentIndex + 1) % imageList1.Images.Count;
                pictureBox2.Image = imageList1.Images[currentIndex];
            }
            else if (e.KeyCode == Keys.Left)
            {
                currentIndex = (currentIndex - 1 + imageList1.Images.Count) % imageList1.Images.Count;
                pictureBox2.Image = imageList1.Images[currentIndex];
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            notifyIcon1.BalloonTipTitle = "Напоминание";
            notifyIcon1.BalloonTipText = $"Прошло {counter * 5} секунд";
            notifyIcon1.ShowBalloonTip(3000);
        }
    }
}
