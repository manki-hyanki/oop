using System.Collections.Specialized;
using System.Diagnostics;
using System.Windows.Forms;

namespace OOP.lab4.bashlykova
{
    public partial class Form1 : Form
    {
        Shapes_Container shapes_container = new Shapes_Container();

        public bool btnSquare_con = false;
        public bool btnCircle_con = false;
        public bool btnRectangle_con = false;
        public Color color = Color.Black;
        public int size;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            shapes_container.DrawAll(e.Graphics);
        }

        public void moveSelectedShapes(int dx, int dy)
        {
            foreach (Shapes shape in shapes_container.Get_Shapes())
            {
                if (shape.getIsSelected())
                {
                    int newX = shape.getX() + dx;
                    int newY = shape.getY() + dy;
                    shape.move(panel1.Width, panel1.Height, dx, dy);
                }
            }
        }

        private void changeColorSelectedShapes(Color color) // функция для изменения цветы выд фигур
        {
            foreach (Shapes shape in shapes_container.Get_Shapes())
            {
                if (shape.getIsSelected())
                {
                    shape.setColor(color);
                    panel1.Invalidate();
                }
            }

        }

        private void changeSizeSelectedShapes(int x) // функция для изменения размера выд фигур
        {
            foreach (Shapes shape in shapes_container.Get_Shapes())
            {
                if (shape.getIsSelected())
                {
                    shape.ChangeSize(size, panel1.Width, panel1.Height);
                    panel1.Invalidate();
                }
            }

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            bool isCtrlPressed = (ModifierKeys & Keys.Control) == Keys.Control; // устанавливет нажат ли ctrl

            foreach (Shapes existing_shape in shapes_container.Get_Shapes()) // для каждой фигуры в контейнере
            {
                if (!isCtrlPressed) //если ctrl не нажат
                    existing_shape.setIsSelected(false); // устанавливает всем фигурам что они не выделены
            }


            Shapes clickedShape = shapes_container.FindShapeAtPoint(e.X, e.Y);

            if (clickedShape != null) // если курсор попал в фигуру
            {
                foreach (Shapes shape in shapes_container.Get_Shapes())
                {
                    if (shape.ContainsPoint(e.X, e.Y))
                    {
                        shape.setIsSelected(true);
                        // break;

                    }
                }

            }

            else if (btnSquare_con)
            {

                Shapes newShape = new Square(e.X, e.Y, color, size);
                shapes_container.Add_Shapes(newShape);
            }

            else if (btnCircle_con)
            {
                Shapes newShape = new Circle(e.X, e.Y, color, size);
                shapes_container.Add_Shapes(newShape);
            }

            else if (btnRectangle_con)
            {
                Shapes newShape = new Rectangle(e.X, e.Y, color, size);
                shapes_container.Add_Shapes(newShape);
            }


            panel1.Invalidate();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e) // удаление фигур
        {
            if (e.KeyCode == Keys.Delete)
            {

                var shapesToRemove = new List<Shapes>();

                foreach (Shapes shape in shapes_container.Get_Shapes())
                {
                    if (shape.getIsSelected())
                    {
                        shapesToRemove.Add(shape);
                    }

                }

                foreach (var shape in shapesToRemove)
                {
                    shapes_container.Remove_Shapes(shape);
                }

                panel1.Invalidate();
            }

            if (e.KeyCode == Keys.A)     // проверяем какая кнопка нажата W A S D и перемещаем
                moveSelectedShapes(-10, 0);
            else if (e.KeyCode == Keys.W)
                moveSelectedShapes(0, -10);
            else if (e.KeyCode == Keys.S)
                moveSelectedShapes(0, 10);
            else if (e.KeyCode == Keys.D)
                moveSelectedShapes(10, 0);
            panel1.Invalidate();

        }
        private void tsbtnSquare_Click(object sender, EventArgs e)
        {
            btnCircle_con = false;
            btnRectangle_con = false;
            btnSquare_con = true;
        }

        private void tsbtnCircle_Click(object sender, EventArgs e)
        {
            btnRectangle_con = false;
            btnSquare_con = false;
            btnCircle_con = true;
        }

        private void tsbtnRectangle_Click(object sender, EventArgs e)
        {
            btnRectangle_con = true;
            btnSquare_con = false;
            btnCircle_con = false;
        }

        private void tsbtnCyan_Click(object sender, EventArgs e)
        {
            color = Color.Cyan;
            changeColorSelectedShapes(color);
        }

        private void tsbtnLime_Click(object sender, EventArgs e)
        {
            color = Color.Lime;
            changeColorSelectedShapes(color);
        }

        private void tsbtnYellow_Click(object sender, EventArgs e)
        {
            color = Color.Yellow;
            changeColorSelectedShapes(color);
        }

        private void tsbtnRed_Click(object sender, EventArgs e)
        {
            color = Color.Red;
            changeColorSelectedShapes(color);
        }


        private void маленькийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            size = 50;
            changeSizeSelectedShapes(size);
        }

        private void обычныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            size = 100;
            changeSizeSelectedShapes(size);
        }

        private void большойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            size = 200;
            changeSizeSelectedShapes(size);
        }
    }
}

