using OOP.lab6.bashlykova;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.DirectoryServices;

namespace OOP.lab4.bashlykova
{
    public partial class Form1 : Form
    {

        Shapes_Container shapes_container = new Shapes_Container();
        Group shapes_group = new Group(10);
        My_Shapes_Container Factory = new My_Shapes_Container();

        public string filename;
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
            shapes_container.DrawAll(e.Graphics);//��������� �������� �� ����������
        }

        public void moveSelectedShapes(int dx, int dy) //������� ��� ������������ ���������� ��������
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

        private void changeColorSelectedShapes(Color color) // ������� ��� ��������� ����� ��� �����
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

        private void changeSizeSelectedShapes(int x) // ������� ��� ��������� ������� ��� �����
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
            bool isCtrlPressed = (ModifierKeys & Keys.Control) == Keys.Control; // ������������ ����� �� ctrl


            foreach (Shapes existing_shape in shapes_container.Get_Shapes()) // ��� ������ ������ � ����������
            {
                if (!isCtrlPressed && existing_shape != null) //���� ctrl �� �����
                    existing_shape.setIsSelected(false); // ������������� ���� ������� ��� ��� �� ��������
            }

            //�������� ������� � �������� ���� ������� � ��� ����� ������
            Shapes clickedShape = shapes_container.FindShapeAtPoint(e.X, e.Y);


            if (clickedShape != null) // ���� ������ ����� � ������
            {
                if (shapes_group.Contains_Shape(clickedShape)) //���� ���� ������ �� ������
                {
                    shapes_group.NewSetIsSelected(true);
                    panel1.Invalidate();
                }
                else
                {
                    foreach (Shapes shape in shapes_container.Get_Shapes())
                    {
                        if (shape.ContainsPoint(e.X, e.Y)) //��������� ������ �������
                        {
                            shape.setIsSelected(true);
                            // break;

                        }
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
                //Log("������ �������������");
            }


            panel1.Invalidate();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e) // �������� �����
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

            if (e.KeyCode == Keys.A)     // ��������� ����� ������ ������ W A S D � ����������
                moveSelectedShapes(-10, 0);
            else if (e.KeyCode == Keys.W)
                moveSelectedShapes(0, -10);
            else if (e.KeyCode == Keys.S)
                moveSelectedShapes(0, 10);
            else if (e.KeyCode == Keys.D)
                moveSelectedShapes(10, 0);
            panel1.Invalidate();

            if (e.KeyCode == Keys.G) //&& (ModifierKeys & Keys.Control) == Keys.Control) //���� ������ G + �trl
            {
                Group shapes_group = new Group(10);

                var shapesToGroup = new List<Shapes>(); //����� ������ ��� ��������� �����

                foreach (Shapes shape in shapes_container.Get_Shapes())
                {
                    if (shape.getIsSelected())
                    {
                        shapesToGroup.Add(shape);  //���������� � ������ shapesToGroup ��������� �����
                    }

                }

                foreach (var shape in shapesToGroup)
                {
                    shapes_group.Add_Shapes_Group(shape); //���������� ����� � ������ (������)
                    shapes_container.Remove_Shapes(shape);
                    //Log($"{shapes_container} ");
                }
                shapes_container.Add_Shapes(shapes_group); //���������� ������ � ���������


                // ����������� ��������� � ���� ����� ����� �������� ������
                foreach (Shapes existing_shape in shapes_container.Get_Shapes()) // ��� ������ ������ � ����������
                {
                    existing_shape.setIsSelected(false); // ������������� ���� ������� ��� ��� �� ��������
                }

                panel1.Invalidate();
            }

            if (e.KeyCode == Keys.U)
            {
                List<Shapes> shapesToAdd = new List<Shapes>(); // ������� 2 ������ � ������� ����� ������ �� ������� ������� ���� �������� � �������
                List<Shapes> shapesToRemove = new List<Shapes>();

                foreach (Shapes shape in shapes_container.Get_Shapes())
                {
                    if (shape.getIsSelected() && shape is Group group) // �������� ��� shape ������� � ��� �������, ���� ��, �� ������������ ���������� ���� ���� � ����
                    {
                        foreach (Shapes i in Group.Ungroup(group))
                        {
                            shapesToAdd.Add(i);
                        }

                        shapesToRemove.Add(shape);
                    }
                }
                // ��������� ��������� ����� ���������� ��������
                foreach (Shapes shape in shapesToAdd)
                {
                    if (shape != null)
                        shapes_container.Add_Shapes(shape);
                }

                foreach (Shapes shape in shapesToRemove)
                {
                    shapes_container.Remove_Shapes(shape);
                }
                panel1.Invalidate();
            }

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


        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            size = 50;
            changeSizeSelectedShapes(size);
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            size = 100;
            changeSizeSelectedShapes(size);
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            size = 200;
            changeSizeSelectedShapes(size);
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                filename = saveFileDialog1.FileName;
                FileStream fcreate = File.Open(filename, FileMode.Create);

                StreamWriter SW = new StreamWriter(fcreate);
                SW.WriteLine(shapes_container.Get_Container_Size());
                foreach (Shapes s in shapes_container.Get_Shapes())
                {
                    s.save(SW);
                }
                SW.Close();
            }
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    shapes_container.Clear();
                    shapes_container.LoadShapes(openFileDialog1.FileName);
                    panel1.Invalidate(); // �������������� ���������� ������
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"������ ��������: {ex.Message}", "������",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

