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
            �hLBquestion.Items.Add("������");
            �hLBquestion.Items.Add("��������");
            �hLBquestion.Items.Add("��� �������");

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;


        }



        private void btnGlamour_Click(object sender, EventArgs e) //����� ����
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



        private void FormStart_MouseMove(object sender, MouseEventArgs e) //���� �����
        {
            if (chBmouse_tracking.Checked)
            {
                lblCoorX.Text = e.X.ToString();
                lblCoorY.Text = e.Y.ToString();
            }
            else
            {
                lblCoorX.Text = null; // ����� � ���, � ��� :)
                lblCoorY.Text = " ";
            }


        }


        private void btnCheckListBox_Click(object sender, EventArgs e)
        {
            if (�hLBquestion.GetItemChecked(0) == true && �hLBquestion.GetItemChecked(1) == true && �hLBquestion.GetItemChecked(2) == true)
            {
                MessageBox.Show("������, ������ � ��������, ��� ����������");
                UpdateProgressbar1(25);
            }
            else
            {
                MessageBox.Show("����������� :( ���������� �����!");
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
                MessageBox.Show("�� �� ���������� ��� ������� ;( ��������� �������� ���������!");
            }
        }



        private void �����������1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStart frm1 = new FormStart();
            frm1.Show();
            this.Hide();
        }

        private void �����������2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }
}
