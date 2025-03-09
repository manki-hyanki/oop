using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.lab4.bashlykova
{

    internal abstract class Shapes
    {
        protected
            bool isSelected = false;
            Color color;  //структура color 
            int x, y;

        protected Shapes(){}

        public virtual void DoSpecific(Graphics g, Pen pen) { } //template method

        public void draw(Graphics g)
        {
            Pen pen;

            if (isSelected)
            {
                pen = new Pen(Color.Blue, 3);
            }
            else
            {
                pen = new Pen(color, 3);
            }

            // Вызов метода для рисования конкретной фигуры
            DoSpecific(g, pen);

            pen.Dispose();

        }

        public abstract bool ContainsPoint(int pointX, int pointY);

        public void setIsSelected(bool isSelected)
        {
            this.isSelected = isSelected;
        }

        public bool getIsSelected()
        {
            return isSelected;
        }

        public void setColor(Color color)
        {
            this.color = color;
        }

        public Color getColor()
        {
            return color;
        }

        public int getX()
        { // геттер для Х
            return x;
        }

        public int getY()
        {
            return y;
        }//геттер для У

        public void setX(int x) {
            this.x = x;
        }
        public void setY(int y) { 
            this.y = y;
        }

    }

    internal class Square : Shapes {
        private
            const int SideLength = 160;

        public Square(){
            this.setX(0);
            this.setY(0);
        }
        public Square(int x, int y, Color color)
        {
            this.setX(x);
            this.setY(y);
            this.setColor(color);
        } // конструктор с параметрами

        public override void DoSpecific(Graphics g, Pen pen)
        {

            int topLeftX = getX() - SideLength / 2; // коор верз лев угла квадрата
            int topLeftY = getY() - SideLength / 2;

            // рисуем квадрат
            g.DrawRectangle(pen, topLeftX, topLeftY, SideLength, SideLength);
            pen.Dispose();
        }


        public override bool ContainsPoint(int pointX, int pointY)
        {
            // вычисляем границы квадрата
            int left = getX() - SideLength / 2;
            int right = getX() + SideLength / 2;
            int top = getY() - SideLength / 2;
            int bottom = getY() + SideLength / 2;

            // находится ли точка внутри квадрата
            return pointX >= left && pointX <= right && pointY >= top && pointY <= bottom;
        }
    };

    internal class Circle : Shapes
    {
        private
            const int r = 100;

        public Circle()
        {
            this.setX(0);
            this.setY(0);
        }
        public Circle(int x, int y, Color color)
        {
            this.setX(x);
            this.setY(y);
            this.setColor(color);
        } // конструктор с параметрами

        public override void DoSpecific(Graphics g, Pen pen)
        {
            g.DrawEllipse(pen, getX() - r, getY() - r, r * 2, r * 2);

        }

        public override bool ContainsPoint(int pointX, int pointY)
        {
            double distance = Math.Sqrt(Math.Pow(pointX - getX(), 2) + Math.Pow(pointY - getY(), 2));
            return distance <= r;
        }
    };

    internal class Rectangle : Shapes
    {
        private
         const int Width = 260; 
         const int Height = 160;


        public Rectangle()
        {
            this.setX(0);
            this.setY(0);
        }
        public Rectangle(int x, int y, Color color)
        {
            this.setX(x);
            this.setY(y);
            this.setColor(color);
        } // конструктор с параметрами

        public override void DoSpecific(Graphics g, Pen pen)
        {
            g.DrawRectangle(pen, getX(), getY(), Width, Height);
        }


        public override bool ContainsPoint(int pointX, int pointY)
        {
            //находится ли точка внутри прямоугольника
            return pointX >= getX() && pointX <= getX() + Width &&
                   pointY >= getY() && pointY <= getY() + Height;
        }
    }
}
