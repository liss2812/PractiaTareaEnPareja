using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiaTareaEnPareja
{
    class Animal
    { 
       //propiedades
        public int animalAge { get; set; }

        public string animalGender { get; set; }
        
        //metodos
        public   string mammal()
        {
            return "El animal es Mamifero";
        }
        public  virtual string mate()
        {
            return "El  Animal tiene  " + animalAge + "  años   y es de genero  " + animalGender   ;
        }

       
    }
    }

