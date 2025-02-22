using System.DirectoryServices;

namespace OOP.lab3.bashlykova

{
    public partial class Form1 : Form
    {
        CCircle_Container circle_container = new CCircle_Container();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PaintBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void PaintBox_MouseClick(object sender, MouseEventArgs e)
        {
            bool permission = true; //разрешение для рисования
            bool isCtrlPressed = (ModifierKeys & Keys.Control) == Keys.Control;//проверка нажатия кнопки ctrl

            foreach (CCircle existing_circle in circle_container.Get_CCircles()) //сбрасывание выделения если не нажат ctrl
            {
                if (!isCtrlPressed)
                    existing_circle.setIsSelected(false);
            }

            foreach (CCircle existing_circle in circle_container.Get_CCircles())
            {

                double distance = Math.Sqrt(Math.Pow(e.X - existing_circle.getX(), 2) + Math.Pow(e.Y - existing_circle.getY(), 2));

                if (distance <= existing_circle.getR())
                {
                    existing_circle.setIsSelected(true);
                    PaintBox.Invalidate();
                    permission = false;
                    //break; // для выделения одного на пересечении
                }
            }
            if (permission)
            {
                CCircle circle = new CCircle(e.X, e.Y);
                circle_container.Add_Circle(circle);
                PaintBox.Invalidate();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) {

                //временный список для удаления
                var circlesToRemove = new List<CCircle>();

                foreach (CCircle circle in circle_container.Get_CCircles())
                {
                    if (circle.getIsSelected())
                    {
                        circlesToRemove.Add(circle);
                    }

                }

                foreach (var circle in circlesToRemove)
                {
                    circle_container.Remove_Circle(circle);
                }

                PaintBox.Invalidate();
            }
            
        }

        private void PaintBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (var circle in circle_container.Get_CCircles())
            {
                Pen pen;
                if (circle.getIsSelected())
                    pen = new Pen(Color.Blue, 3);
                else
                    pen = new Pen(Color.Black, 3);

                g.DrawEllipse(pen, circle.getX() - circle.getR(), circle.getY() - circle.getR(), circle.getR() * 2, circle.getR() * 2);
                pen.Dispose();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void PaintBox_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }


    }
}
