using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace taller_final
{
    public partial class Form1 : Form
    {

        //instanciar las clases 
        Suma suma = new Suma();
        Resta resta = new Resta();
            Multiplicacion multiplicacion = new Multiplicacion();
        Division division = new Division();
        Miligramos miligramos = new Miligramos();
        Gramos gramos = new Gramos();
        Decagramos decagramos = new Decagramos();



        public Form1()
        {
            InitializeComponent();
        }

        private void pbxconversor_Click(object sender, EventArgs e)
        {
            Conversion conversion = new Conversion();
            conversion.Show();
            this.Hide();
        }

        private void pbxoperaciones_Click(object sender, EventArgs e)
        {
            Operaciones operaciones = new Operaciones();
            operaciones.Show();
            this.Hide();
        }
    }
}
