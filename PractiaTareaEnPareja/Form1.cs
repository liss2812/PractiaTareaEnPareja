using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractiaTareaEnPareja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //crear instancia de fish
            Fish fish = new Fish();
            fish.animalAge = 2;
            fish.animalGender = "Masculino";
            fish.canEar = true;
            fish.sizeInFt = 1;

            MessageBox.Show(fish.GetInfo());
            MessageBox.Show(fish.swim());
            MessageBox.Show(fish.mammal());
            MessageBox.Show(fish.mate());

            //crear instancia de duck
           Duck duck = new Duck();
            duck.animalAge = 4;
            duck.animalGender = "Masculino";
            duck.beakColor = "yellow";


            MessageBox.Show(duck.swim());
            MessageBox.Show(duck.quack());
            MessageBox.Show(duck.mammal());
            MessageBox.Show(duck.mate());
           
            


            //crear instancia de Zebra
            Zebra zebra = new Zebra();
            zebra.animalAge = 3;
            zebra.animalGender = "Femenino";
            zebra.is_wild = true;



            MessageBox.Show(zebra.run());
            MessageBox.Show(zebra.mammal());
            MessageBox.Show(zebra.mate());
            
        }
    }
}
