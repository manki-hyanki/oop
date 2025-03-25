using OOP.lab4.bashlykova;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.lab6.bashlykova
{
    public class Group : Shapes
    {
        private
            int _maxcount;
            int _count;
            Shapes[]_shapes;

        public Group(int maxcount) //конструктор массива объектов шейпс
        {
            _maxcount = maxcount;
            _count = 0;
            _shapes = new Shapes[maxcount];
            for (int i = 0; i < _maxcount; i++)
            {
                _shapes[i] = null;
            }

            Console.WriteLine("Этот текст появится в консоли!");
        }

        public void Add_Shapes_Group(Shapes shape)
        {
            if (_count < _maxcount)  // проверяем есть ли место в массиве
            {
                _shapes[_count] = shape;  // записываем в текущую позицию
                _count++;
            }
        }

        public Shapes[] Get_Shapes_Group()
        {
            return _shapes;

        }

        public override void setIsSelected(bool isSelected)
        {
            foreach (Shapes shape in Get_Shapes_Group())
            {
                if (shape != null)
                shape.setIsSelected(isSelected);
            }
        }

        public override void DoSpecific(Graphics g, Pen pen)
        {
            foreach (Shapes shape in Get_Shapes_Group()) 
            { 
                if(shape != null)
                shape.draw(g); 
            }
        }

        public int Get_maxcount()
        {
            return _maxcount;
        }

        public bool Contains_Shape(Shapes shape)
        {
            for (int i = 0; i < _maxcount; i++)
            {
                if (_shapes[i] == shape)
                    return true;
            }
            return false;
        }


        public override bool ContainsPoint(int pointX, int pointY) //проверяет всю группу на попадание курсора
        {
            for (int i = 0; i < _count; i++) {
                if (_shapes[i].ContainsPoint(pointX, pointY)) 
                {
                    setIsSelected(true);
                    return true;
                }
            }
            return false;
        }
        public void NewSetIsSelected(bool selected)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_shapes[i] != null)
                {
                    _shapes[i].setIsSelected(selected);
                }
            }
        }

        public void move(int w, int h, int dx, int dy)
        {
            for (int i = 0; i < _maxcount; i++)
            {
                _shapes[i].move(w, h, dx, dy);
            }
        }

        public override bool isAvailableLocation(int w, int h, int dX, int dY) //проверяем не выходит ли за границы панели
        {
            for (int i = 0; i < _maxcount; i++)
            {
                if (!_shapes[i].isAvailableLocation(w, h, dX, dY))
                {
                    return false;
                }
            }
            return true;
        }

        ~Group() //деструктор
        {
            for (int i = 0; i < _count; i++)  //удаляем ссылки
                _shapes[i] = null;

            _shapes = null; //очищаем массив

        } 















    }


}
