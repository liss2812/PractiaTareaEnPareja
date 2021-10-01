using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiaTareaEnPareja
{
    class Duck : Animal
    {
        public string beakColor { get; set; }
        

        public   string swim()
        {
            return " El Pato esta nadando y  es de color  "   + beakColor;
        }
        public string quack()
        {
            return "quak,quak";
        }
        // metodod heredado
        public override string mate()
        {
            return base.mate() + "es compañero  de  "  + " las patas ";
        }
    }
}
