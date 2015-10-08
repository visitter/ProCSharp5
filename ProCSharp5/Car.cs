using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp5
{
    class Car
    {
        public string Make{ get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        
        public Car()
        {
            
        }
        public Car( string Make, string Model )
        {            
            this.Make = Make;
            this.Model = Model;
        }

        private void changeSpeed(int delta)
        {
            if ((this.Speed + delta) >= 0)
                this.Speed += delta;
            else this.Speed = 0;
        }

        public void speedUp(UInt16 acceleration)
        {
            changeSpeed(acceleration);
        }

        public void slowDown(UInt16 decreaseing)
        {
            changeSpeed(-decreaseing);
        }
    }
}
