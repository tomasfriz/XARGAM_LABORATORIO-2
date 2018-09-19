﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grados;

namespace Ejercicio_24
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnPeso_Click(object sender, EventArgs e)
		{
			double grados;
			Kelvin kelvin;
			if (double.TryParse(txtKelvin.Text, out grados) )
			{
				kelvin = grados;
				this.txtKelvinKelvin.Text = kelvin.GetGrados().ToString("0.00");
				this.txtKelvinCelsius.Text = ((Celsius)kelvin).GetGrados().ToString("0.00");
				this.txtKelvinFahrenheit.Text = ((Fahrenheit)kelvin).GetGrados().ToString("0.00");
			}
		}

		private void btnDolar_Click(object sender, EventArgs e)
		{
			double grados;
			Celsius celsius;
			if (double.TryParse(txtCelsius.Text, out grados) )
			{
				celsius = grados;
				this.txtCelsiusCelcius.Text = celsius.GetGrados().ToString("0.00");
				this.txtCelsiusFahrenheit.Text = ((Fahrenheit)celsius).GetGrados().ToString("0.00");
				this.txtCelsiusKelvin.Text = ((Kelvin)celsius).GetGrados().ToString("0.00");
			}
		}

		private void btnEuro_Click(object sender, EventArgs e)
		{
			double grados;
			Fahrenheit fahrenheit;
			if (Double.TryParse(txtFahrenheit.Text, out grados) )
			{
				fahrenheit = grados;
				this.txtFahrenheitFahrenheit.Text = fahrenheit.GetGrados().ToString("0.00");
				this.txtFahrenheitCelsius.Text = ((Celsius)fahrenheit).GetGrados().ToString("0.00");
				this.txtFahrenheitKelvin.Text = ((Kelvin)fahrenheit).GetGrados().ToString("0.00");
			}
		}

		private void lblPeso_Click(object sender, EventArgs e)
		{

		}

		private void lblDolar_Click(object sender, EventArgs e)
		{

		}

		private void lblEuro_Click(object sender, EventArgs e)
		{

		}

		private void txtPeso_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtDolar_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtEuro_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void txtEuroEuro_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
