using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CovalcoWebApi.Models;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		HttpApiController controller;
		public Form1()
		{
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = true;
			controller = new HttpApiController();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void RefreshButton_Click(object sender, EventArgs e)
		{
			List<Alumno> alumnos = new List<Alumno>();
			alumnos = HttpApiController.GetCall().Result; //$$$$$$$;
			dataGridView1.DataSource = alumnos;
			dataGridView1.Refresh();
		}

		private void AddCaller_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.Show();
		}
	}
}
