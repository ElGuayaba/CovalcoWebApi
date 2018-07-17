namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.covalcoDataSet = new WindowsFormsApp1.CovalcoDataSet();
			this.alumnoTableAdapter = new WindowsFormsApp1.CovalcoDataSetTableAdapters.AlumnoTableAdapter();
			this.AddCaller = new System.Windows.Forms.Button();
			this.RefreshButton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.covalcoDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// alumnoBindingSource
			// 
			this.alumnoBindingSource.DataMember = "Alumno";
			this.alumnoBindingSource.DataSource = this.covalcoDataSet;
			// 
			// covalcoDataSet
			// 
			this.covalcoDataSet.DataSetName = "CovalcoDataSet";
			this.covalcoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// alumnoTableAdapter
			// 
			this.alumnoTableAdapter.ClearBeforeFill = true;
			// 
			// AddCaller
			// 
			this.AddCaller.Location = new System.Drawing.Point(125, 195);
			this.AddCaller.Name = "AddCaller";
			this.AddCaller.Size = new System.Drawing.Size(105, 35);
			this.AddCaller.TabIndex = 2;
			this.AddCaller.Text = "Add";
			this.AddCaller.UseVisualStyleBackColor = true;
			this.AddCaller.Click += new System.EventHandler(this.AddCaller_Click);
			// 
			// RefreshButton
			// 
			this.RefreshButton.Location = new System.Drawing.Point(12, 195);
			this.RefreshButton.Name = "RefreshButton";
			this.RefreshButton.Size = new System.Drawing.Size(107, 35);
			this.RefreshButton.TabIndex = 3;
			this.RefreshButton.Text = "Refresh";
			this.RefreshButton.UseVisualStyleBackColor = true;
			this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(444, 177);
			this.dataGridView1.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(240, 195);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(105, 35);
			this.button1.TabIndex = 5;
			this.button1.Text = "Edit";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(351, 195);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(105, 35);
			this.button2.TabIndex = 6;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(468, 239);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.RefreshButton);
			this.Controls.Add(this.AddCaller);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.covalcoDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private CovalcoDataSet covalcoDataSet;
		private System.Windows.Forms.BindingSource alumnoBindingSource;
		private CovalcoDataSetTableAdapters.AlumnoTableAdapter alumnoTableAdapter;
		private System.Windows.Forms.Button AddCaller;
		private System.Windows.Forms.Button RefreshButton;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}

