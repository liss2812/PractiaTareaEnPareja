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
            return " El Pez esta nadando....... ";


        }

        public string swin(string name, string owner)
        {
            return "El pez " + name +
                " esta nadando cerca del pato que se llama " + owner;
        }
       
        //Agrege esta otra parte pero no supe como ponerlo en pantalla Att: Fatima

        // metodod heredado
        public override string mate()
        {
            return base.mate() + " El Pez es comapeñero  "  +  "  de los pulpos ";
        }
    }
}




