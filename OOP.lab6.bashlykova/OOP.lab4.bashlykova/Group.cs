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
            this.isSelected = isSelected;
            foreach (Shapes shape in Get_Shapes_Group())
            {
                if (shape != null)
                shape.setIsSelected(isSelected);
            }
        }

        public override bool getIsSelected()
        {
            return isSelected;
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

        public override void move(int w, int h, int dx, int dy)
        {
            bool stop = false;
            for (int i = 0; i < _maxcount; i++)
            {
                if (_shapes[i] != null && !_shapes[i].isAvailableLocation(w, h, dx, dy))
                {
                    stop = true;
                }
            }
            foreach (Shapes shape in _shapes)
            {

                if (shape != null && shape.isAvailableLocation(w, h, dx,dy) && !stop)
                    shape.move(w, h, dx, dy);

                else
                    break;
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


        // метод принимает группу обьектов Shape, среди которых может быть и Group
        // метод возвращает список обьектов Shape
        public static List<Shapes> Ungroup(Group shape_gr)
        {
            // создается список куда мы будем помещать разгруппированные обьекты, который в итоге мы вернем
            List<Shapes> shapesList = new List<Shapes>();


            // цикл который проходится по всем обьектам группы
            foreach (Shapes shape in shape_gr.Get_Shapes_Group())
            {
                // если обьект группа
                if (shape is Group group)
                {
                    // вызвать у этой группы метод Ungroup, чтобы вернулся список обьектов из этой группы
                    // затем этот список помещается в конец списка shapesList
                    shapesList.AddRange(Ungroup(group));
                }
                // иначе добавить обьект в список
                else {
                    shapesList.Add(shape);
                }
            }

            return shapesList;
        }
        ~Group() //деструктор
        {
            for (int i = 0; i < _count; i++)  //удаляем ссылки
                _shapes[i] = null;

            _shapes = null; //очищаем массив

        } 















    }


}
