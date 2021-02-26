using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSoma_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txtNum1.Text);
            int n2 = Convert.ToInt32(txtNum2.Text);

            CalcMath obj = new CalcMath();

            obj.x = n1;// o x é um value member da class calcMath, mas foi incorretamente especificado como Public
            obj.y = n1;// o y é um value member da class calcMath, mas foi incorretamente especificado como Public
            int resultado = obj.Somar();
            txtResultado.Text = Convert.ToString(resultado);

        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txtNum1.Text);
            int n2 = Convert.ToInt32(txtNum2.Text);

            CalcMath obj = new CalcMath();

            obj.x = n1;
            obj.y = n1;
            int resultado = obj.Multiplicar();
            txtResultado.Text = Convert.ToString(resultado);
        }


    }
}
