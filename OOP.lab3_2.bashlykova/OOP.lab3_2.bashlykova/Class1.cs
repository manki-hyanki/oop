using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.lab3_2.bashlykova
{
    internal class Numbers
    {
        private
        int A;
        int B;
        int C;

        public System.EventHandler observers; //уведомляет об изменении в модели другие части кода

        // observers?.Invoke(this, null); // покажет что изменили 

        public Numbers(int A, int B, int C) {
            if(A >= 0 && A <= 100)
                this.A = A;
            if(B >= 0 && B <= 100)
                this.B = B;
            if(C >= 0 && C <= 100)  
                this.C = C;
        }

        public Numbers() {
            this.A = Properties.Settings.Default.A;
            this.B = Properties.Settings.Default.B;
            this.C = Properties.Settings.Default.C;
            observers?.Invoke(this, null);
        }
        public int  get_A () { return A; }

        public int get_B() {  return B; }
        
        public int get_C() { return C; }

        public void set_A(int A) 
        { 
            if(A >=0 && A <= 100)
                this.A = A;
               
            if (this.A > this.C) 
            {
                this.C = this.A;
            }
            recalculate_B();
            notifyObservers();
            observers.Invoke(this, null);
        }

        public void set_B (int B)
        {
            if (B >= get_A() && B <= get_C())
                this.B = B;
            else
                this.B = this.A;
            recalculate_B();
            notifyObservers();
            observers.Invoke(this, null);
        }

        public void set_C(int C)
        {
            if(C >=0 && C <= 100)
                this.C = C;
            if (this.C < this.A)
            {
                this.A = this.C;
            }
            recalculate_B();
            notifyObservers();
            observers.Invoke(this, null);
        }



        private void recalculate_B() {
            int new_B;
            if (get_B() > get_C())
            {
                new_B = get_C();
                set_B(new_B);
            }
            else if (get_B() < get_A())
            {
                new_B = get_A();
                set_B(new_B);
            }
        }

        private void notifyObservers()
        {
            observers?.Invoke(this, null);

            Properties.Settings.Default.A = this.A;
            Properties.Settings.Default.B = this.B;
            Properties.Settings.Default.C = this.C;
            Properties.Settings.Default.Save();
        }




    }
}
