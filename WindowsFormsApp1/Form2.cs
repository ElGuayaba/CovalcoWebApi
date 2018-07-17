using CovalcoWebApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Alumno alumno = new Alumno(textBox1.Text, textBox2.Text, textBox3.Text);
			HttpApiController.AñadirAlumnos(alumno);
		}
	}
}
