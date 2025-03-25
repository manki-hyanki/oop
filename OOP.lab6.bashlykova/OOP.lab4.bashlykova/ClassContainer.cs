using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.lab4.bashlykova
{
    internal class Shapes_Container
    {
        private List<Shapes> Container = new List<Shapes>();
        public int Count()
        {
            int count = 0;
            foreach (var shape in Container) { count++; }
            return count;
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
}
