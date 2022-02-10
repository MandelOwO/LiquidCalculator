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

        private void button_volume10_Click(object sender, EventArgs e)
        {
            textBox_volume.Text = "10";
        }

        private void butto_volume30_Click(object sender, EventArgs e)
        {
            textBox_volume.Text = "30";
        }

        private void button_volume_60_Click(object sender, EventArgs e)
        {
            textBox_volume.Text = "60";
        }

        private void button_base0_Click(object sender, EventArgs e)
        {
            textBox_base.Text = "0";
        }

        private void button_shot10_Click(object sender, EventArgs e)
        {
            textBox_shot.Text = "10";
        }

        private void button_shot15_Click(object sender, EventArgs e)
        {
            textBox_shot.Text = "15";
        }

        private void button_shot20_Click(object sender, EventArgs e)
        {
            textBox_shot.Text = "20";
        }

        private void button_strength2_Click(object sender, EventArgs e)
        {
            textBox_strength.Text = "2";
        }

        private void button_strength3_Click(object sender, EventArgs e)
        {
            textBox_strength.Text = "3";
        }

        private void button_strength4_Click(object sender, EventArgs e)
        {
            textBox_strength.Text = "4";
        }
    }
}
