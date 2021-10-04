using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiaTareaEnPareja
{
    class Zebra : Animal
    {
        public Boolean is_wild { get; set; }
        public string getInfo()
        {
            var wild = "";

            if (is_wild ==true)
            {
                wild = " es salvaje";
            }
            else
            {
                wild = " no es salvaje";
            }
            return " La Zebra " + wild;
        }
        public   string run()
        {
            return "La Zebra esta corriendo" ;
        }

        public string run(string name, string owner)
        {
            return "La Zebra se llama " + name +
                " esta en el zoologico " + owner;
        }

        // metodod heredado
        public override string mate()
        {
            return base.mate() + " Es compañero de " + " los caballos ";
        }
    }
}
