using OOP.lab6.bashlykova;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.lab4.bashlykova
{
    public class Shapes_Container
    {
        private List<Shapes> Container = new List<Shapes>();
        public int Count()
        {
            int count = 0;
            foreach (var shape in Container) { count++; }
            return count;
        }

        

        public static Shapes createShape(char code, int x = 0, int y = 0, Color color = default(Color), int size = 0 )
        {
            Shapes shape = null;
            switch (code)
            {
                case 'C':
                    shape = new Circle(x, y, color, size);
                    break;
                case 'R':
                    shape = new Rectangle(x, y, color, size);
                    break;
                case 'S':
                    shape = new Square(x, y, color, size);
                    break;
                case 'G':

                    shape = new Group(10);
                    break;
                default:
                    break;
            }
            return shape;
        }

        public void LoadShapes(string filename)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    // Читаем количество фигур
                    int count = int.Parse(reader.ReadLine());

                    for (int i = 0; i < count; i++)
                    {
                        // Читаем код фигуры
                        char code = (char)reader.Read();
                        reader.ReadLine(); // Пропускаем оставшуюся часть строки

                        Shapes shape = createShape(code); // в этом моменте вызывается креатеШапе на 20 строке
                        if (shape != null)
                        {
                            shape.load(reader);
                            Container.Add(shape);
                            reader.ReadLine();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка загрузки файла: {ex.Message}");
            }
        }

        public void SaveShapes(string filename)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    // Сохраняем количество фигур в контейнере
                    writer.WriteLine(Container.Count);

                    // Сохраняем каждую фигуру
                    foreach (Shapes shape in Container)
                    {
                        if (shape != null)
                        {
                            // Сохраняем тип фигуры (первая строка)
                            char shapeCode = GetShapeCode(shape);
                            writer.WriteLine(shapeCode);

                            // Сохраняем данные фигуры (последующие строки)
                            shape.save(writer);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка сохранения: {ex.Message}");
                // Можно добавить более детальную обработку ошибок
                throw; // Перебрасываем исключение для обработки на уровне выше
            }
        }

        public int Get_Container_Size()
        {
            return Container.Count;
        }



        public void Clear()
        {
            this.Container.Clear();
        }

        private char GetShapeCode(Shapes shape)
        {
            if (shape is Circle) return 'C';
            if (shape is Square) return 'S';
            if (shape is Rectangle) return 'R';
            if (shape is Group) return 'G';
            throw new NotSupportedException($"Тип фигуры {shape.GetType().Name} не поддерживается");
        }


        public void Add_Shapes(Shapes shape)
        {
            Container.Add(shape);
        }

        public void Remove_Shapes(Shapes shape)
        {
            Container.Remove(shape);
        }

        public List<Shapes> Get_Shapes()
        {
            return Container;
        }
        // метод для отрисовки всех кругов

        public void DrawAll(Graphics g)
        {
            foreach (var shape in Container)
            {
                if(shape != null) 
                shape.draw(g);
            }
        }

        // метод для поиска фигур в которые попал курсор
        public Shapes FindShapeAtPoint(int pointX, int pointY)
        {
            foreach (Shapes shape in Container)
            {
                if (shape.ContainsPoint(pointX, pointY))
                {
                    return shape;
                }
            }
            return null;
        }
    }


    public class My_Shapes_Container : Shapes_Container
    {
        public Shapes createShape(char code, int x = 0, int y = 0, Color color = default(Color), int size = 0)
        {
            Shapes shape = null;
            switch (code)
            {
                case 'C':
                    shape = new Circle(x, y, color, size);
                    break;
                case 'R':
                    shape = new Rectangle(x, y, color, size);
                    break;
                case 'S':
                    shape = new Square(x, y, color, size);
                    break;
                case 'G':
                    shape = new Group(10);
                    break;
                default:
                    break;
            }
            return shape;
        }
    }
}
