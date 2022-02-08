using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiquidCalculator
{
    public partial class Form1 : Form
    {

        Calculator calculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            calculator.Data.TotalVolume = Convert.ToDouble(textBox_volume.Text);
            calculator.Data.BaseConcentration = Convert.ToDouble(textBox_base.Text);
            calculator.Data.ShotConcentration = Convert.ToDouble(textBox_shot.Text);
            calculator.Data.Strength = Convert.ToDouble(textBox_strength.Text);
            textBox_result.Text = calculator.Calculate().ToString();
        }

    }
}
