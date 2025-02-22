using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP.lab3.bashlykova
{
    internal class CCircle
    {
        private // инициализация полей
            int x, y;
            const int  r = 50;
            bool isSelected = false;

        public CCircle()
        {
            x = 0;
            y = 0;
        } //контруктор по умолчанию

        public CCircle(int x, int y)
        {
            this.x = x;
            this.y = y;
        } // конструктор с параметрами

        public void setIsSelected(bool isSelected)
        {
            this.isSelected = isSelected;
        }

        public bool getIsSelected()
        {
            return isSelected;
        }

        public int getX() { // геттер для Х
            return x;
        } 

        public int getY() { 
            return y;
        }//геттер для У

        public int getR() { 
            return r;
        }

        ~CCircle(){} // деструктор
    }

    internal class CCircle_Container
    {
        
        private List<CCircle> circle_container = new List<CCircle>();
        public bool isEmpty()
        {
            
            return circle_container.Count == 0; //сравнивает кол-во объектов если 0 возвращает тру
        }
        public void Add_Circle(CCircle circle)
        {
            circle_container.Add(circle);
        }

        public void Remove_Circle(CCircle circle)
        {
            circle_container.Remove(circle);
        }

        public List<CCircle> Get_CCircles() { 
            return circle_container;
        }




    }
}
