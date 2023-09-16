using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassMultiplicacion;
using ClassResta;
using ClassSuma;
using DivisionClass;

namespace Nacho_opera
{
    public partial class WPrincipal : Form
    {
        public WPrincipal()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == "" || txtNum2.Text == "") MessageBox.Show("Ingrese los datos por favor");
            else
            {
                long resulSuma = ClassSuma.Suma.Sumar(long.Parse(txtNum1.Text), long.Parse(txtNum2.Text));
                txtSuma.Text = resulSuma.ToString();

                long ResulResta = ClassResta.Resta.Restar(int.Parse(txtNum1.Text), int.Parse(txtNum2.Text));
                txtResta.Text = ResulResta.ToString();

                long resulMulti = ClassMultiplicacion.Multiplicacion.Multiplicar(long.Parse(txtNum1.Text), long.Parse(txtNum2.Text));
                txtMultiplicacion.Text = resulMulti.ToString();

                if (long.Parse(txtNum2.Text) == 0) MessageBox.Show("No se puede dividir por 0");
                else
                {
                    long resulDivision = DivisionClass.Division.Dividir(long.Parse(txtNum1.Text), long.Parse(txtNum2.Text));
                    txtDivision.Text = resulDivision.ToString();
                }
            }
        }
    }
}
