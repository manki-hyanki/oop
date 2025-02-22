using OOP.lab1.bashlykova.obj;
using System;
using System.Media;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace OOP.lab1.bashlykova
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
            сhLBquestion.Items.Add("Блонды");
            сhLBquestion.Items.Add("Брюнетки");
            сhLBquestion.Items.Add("Мне неважно");

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;


        }



        private void btnGlamour_Click(object sender, EventArgs e) //смена фона
        {
            if (this.BackColor == Color.White)
            {
                this.BackColor = Color.LightPink;
                UpdateProgressbar1(25);

            }
            else
            {
                this.BackColor = Color.White;

                if (progressBar1.Value - 25 >= progressBar1.Minimum)
                    UpdateProgressbar1(-25);
            }

        }



        private void FormStart_MouseMove(object sender, MouseEventArgs e) //коор мышки
        {
            if (chBmouse_tracking.Checked)
            {
                lblCoorX.Text = e.X.ToString();
                lblCoorY.Text = e.Y.ToString();
            }
            else
            {
                lblCoorX.Text = null; // можно и так, и так :)
                lblCoorY.Text = " ";
            }


        }


        private void btnCheckListBox_Click(object sender, EventArgs e)
        {
            if (сhLBquestion.GetItemChecked(0) == true && сhLBquestion.GetItemChecked(1) == true && сhLBquestion.GetItemChecked(2) == true)
            {
                MessageBox.Show("Гламур, блонды и брюнетки, мне неваааажно");
                UpdateProgressbar1(25);
            }
            else
            {
                MessageBox.Show("Неправильно :( Попробуйте снова!");
                if (progressBar1.Value - 25 >= progressBar1.Minimum)
                    UpdateProgressbar1(-25);
            }
        }

        private void UpdateProgressbar1(int progress)
        {

            progressBar1.Value += progress;


        }

        private void chBmouse_tracking_CheckedChanged(object sender, EventArgs e)
        {
            if (chBmouse_tracking.Checked)
            {
                UpdateProgressbar1(25);
            }
            else
            {
                if (progressBar1.Value - 25 >= progressBar1.Minimum)
                    UpdateProgressbar1(-25);

            }

        }

        private void btnImageSize_Click(object sender, EventArgs e)
        {
            if (picBoxCats.SizeMode != PictureBoxSizeMode.StretchImage)
            {
                picBoxCats.SizeMode = PictureBoxSizeMode.StretchImage;
                UpdateProgressbar1(25);
            }

        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Вы не опробовали все функции ;( Заполните прогресс полностью!");
            }
        }



        private void открытьОкно1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStart frm1 = new FormStart();
            frm1.Show();
            this.Hide();
        }

        private void открытьОкно2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }
}
