using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiaTareaEnPareja
{
    class Fish : Animal
    {

        public int sizeInFt { get; set; }
       
        //metodos
        public Boolean canEar { get; set; }
        public string GetInfo()
        {
            var Ear = "";
            if (canEar == true)
            {
                Ear = " puede oir";
            }
            else
            {
                Ear = "no puede oir";
            }
            return " El Pez " + Ear + " y mide " +   sizeInFt + " pies "  ;
        }


        public  string swim ()
        {
            return " El Pez esta nadando... ";


        }
        // metodod heredado
        public override string mate()
        {
            return base.mate() + " El Pez es comapeñero  "  +  "  de los pulpos ";
        }
    }
}




