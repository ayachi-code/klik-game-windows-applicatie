﻿using System;
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
            String normaal_klik = normaal.Text;
            int normaal_klik_getal = Int32.Parse(normaal_klik);
            normaal_klik_getal += 1;
            String normaal_klik_nieuwe_waarden = normaal_klik_getal.ToString();
            if (normaal_klik_getal >= 10)
            {
                //Een super punt en reset de normaal_waarde naar nul
                normaal_klik_getal = 0;
                normaal.Text = normaal_klik_getal.ToString();
            } else
            {
                //Als er niks aan de hand is voer dan een punt bij normaal
                normaal.Text = normaal_klik_nieuwe_waarden;
            }
            
        }
    }
}
