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

    

    public partial class Conversion : Form
    {
        Miligramos miligramos = new Miligramos();
        Gramos gramos = new Gramos();
        Decagramos decagramos = new Decagramos();

        public Conversion()
        {
            InitializeComponent();
        }

        private void btnmiligramos_Click(object sender, EventArgs e)
        {
            miligramos.setPeso(double.Parse(txtpeso.Text));

            lblresultado.Visible = true;
            lblresultado.Text = Convert.ToString(miligramos.miligramos());
        }

        private void btngramos_Click(object sender, EventArgs e)
        {
            gramos.setPeso(double.Parse(txtpeso.Text));

            lblresultado.Visible = true;
            lblresultado.Text = Convert.ToString(gramos.gramos());
        }

        private void btndecagramos_Click(object sender, EventArgs e)
        {
            decagramos.setPeso(double.Parse(txtpeso.Text));

            lblresultado.Visible = true;
            lblresultado.Text = Convert.ToString(decagramos.decagramos());
        }
    }
}
