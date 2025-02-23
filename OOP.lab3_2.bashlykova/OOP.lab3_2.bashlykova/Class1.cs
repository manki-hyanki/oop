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

        // observers.Invoke(this, null); // покажет что изменили 

        public Numbers(int A, int B, int C) {
            if(A >= 0 && A <= 100)
                this.A = A;
            if(B >= 0 && B <= 100)
                this.B = B;
            if(C >= 0 && C <= 100)  
                this.C = C;
        }

        public Numbers() { 
            this.A = 0;
            this.B = 0;
            this.C = 0;
        }
        public int  get_A () { return A; }

        public int get_B() {  return B; }
        
        public int get_C() { return C; }

        public void set_A(int A) 
        { 
            if(A >=0 && A <= 100)
                this.A = A;
            observers.Invoke(this, null);
        }

        public void set_B (int B)
        {
            if (B >=0 && B <= 100)
                this.B = B;
            observers.Invoke(this, null);
        }

        public void set_C(int C)
        {
            if(C >=0 && C <= 100)
                this.C = C;
            observers.Invoke(this, null);
        }
    }
}
