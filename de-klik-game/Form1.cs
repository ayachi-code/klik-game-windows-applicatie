using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de_klik_game
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Normaal getal
            String normaal_klik = normaal.Text;
            int normaal_klik_getal = Int32.Parse(normaal_klik);
            normaal_klik_getal += 1;
            String normaal_klik_nieuwe_waarden = normaal_klik_getal.ToString();
            //Super getal
            String super_klik = super.Text;
            int super_klik_waarden = Int32.Parse(super_klik);
            super_klik_waarden += 1;
            String super_klik_waarden_niewen = super_klik_waarden.ToString();
         
            if (normaal_klik_getal >= 10)
            {
                //Een super punt en reset de normaal_waarde naar nul
                //Hier word het gerest
                normaal_klik_getal = 0;
                normaal.Text = normaal_klik_getal.ToString();
                //Voeg een punt bij
                super.Text = super_klik_waarden_niewen;


            } else
            {
                //Als er niks aan de hand is voer dan een punt bij normaal
                normaal.Text = normaal_klik_nieuwe_waarden;
            }
            
        }
    }
}
