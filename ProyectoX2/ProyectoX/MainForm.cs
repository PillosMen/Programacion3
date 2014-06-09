/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 30/05/2014
 * Time: 09:23 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProyectoX
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private MySqlCommand myCmdQuery;
		private MySqlDataAdapter myDataAdapter;
		private BindingSource myBindingSource;
		private MySqlCommandBuilder myCommandBuilder;
		private DataSet myData;
		private MySqlConnection myConnection;
		private string myStringCon;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			conectar();
			MainFormLoad();
			actualizarTabla();
		}
		
		void conectar(){
			this.myCmdQuery= new MySqlCommand();
			this.myDataAdapter=new MySqlDataAdapter();
			this.myBindingSource=new BindingSource();
			this.myCommandBuilder =new MySqlCommandBuilder();
			this.myData =new DataSet();
			this.dataGridView1.AllowUserToAddRows = false;
			this.myStringCon=
				"Server=localhost;" +
				"Database=catalogo;" +
				"User ID=root;" +
				"Password=;" +
				"Pooling=false;";	
		}
		
		void MainFormLoad()
		{
			//create an instance of MySqlConnection class
			this.myConnection = new MySqlConnection(this.myStringCon);
			try{
				this.myConnection.Open();
			}catch(MySqlException ex){
				MessageBox.Show(ex.Message);
				System.Environment.Exit(1);
			}
			
			this.myCmdQuery.CommandText="SELECT * FROM clientes";//muestra lo de la tablas
			this.myCmdQuery.CommandType=CommandType.Text;
			this.myCmdQuery.Connection=this.myConnection;
			
			this.myDataAdapter.SelectCommand=this.myCmdQuery;
			this.myCommandBuilder.DataAdapter=this.myDataAdapter;
			//Llenar el dataset
			this.myDataAdapter.Fill(this.myData,"clientes");
			this.myBindingSource.DataSource=this.myData;
			this.myBindingSource.DataMember="clientes";
			this.dataGridView1.DataSource=this.myBindingSource;

			
            
		}
		
	    void eliminarAlumno(string id){
			string sql = "DELETE FROM `clientes` WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
		}
		
		public void actualizarTabla(){
			try{
				this.myData.Clear();
				this.myDataAdapter.Fill(this.myData,"clientes");
				this.myBindingSource.DataSource=this.myData;
				this.myBindingSource.DataMember="clientes";
				this.dataGridView1.DataSource=this.myBindingSource;
				this.dataGridView1.Update();
				this.dataGridView1.Refresh();
			}catch(MySqlException ex){
				MessageBox.Show(ex.Message);
			}
		}
		   
		int ejecutarComando(string sql){
			MySqlCommand myCommand = new MySqlCommand(sql,this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Nuevo n = new Nuevo();
			n.Show();
			Hide();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if ( MessageBox.Show ( "¿Desea Cerrar Sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1 ) == System.Windows.Forms.DialogResult.Yes )
                {
				  Acceso a = new Acceso();
			      a.Show();
			      Hide();
                }
			
		}
		
		void BtnEditarClick(object sender, EventArgs e)
		{
			if(this.dataGridView1.SelectedRows.Count>0){
				DataGridViewRow row = this.dataGridView1.SelectedRows[0];
				DataGridViewCell cell = row.Cells[0];
				DataGridViewCell cell2 = row.Cells[1];
				DataGridViewCell cell3 = row.Cells[2];
				DataGridViewCell cell4 = row.Cells[3];
				DataGridViewCell cell5 = row.Cells[4];
				
				string id = cell.Value.ToString();
				string nombre = cell2.Value.ToString();
				string apellido = cell3.Value.ToString();
				string telefono = cell4.Value.ToString();
				string domicilio = cell5.Value.ToString();
				
				Editar editar = new Editar(id,nombre,apellido,telefono,domicilio);
				editar.Show();
				Hide();
			}
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
				if(this.dataGridView1.SelectedRows.Count>0){
				DataGridViewRow row = this.dataGridView1.SelectedRows[0];
				DataGridViewCell cell0 = row.Cells[0];
				DataGridViewCell cell1 = row.Cells[1];
				DataGridViewCell cell2 = row.Cells[2];
				string id = cell0.Value.ToString();
				string nombre = cell2.Value.ToString();
				
				System.Windows.Forms.DialogResult result = MessageBox.Show(
					"¿Está seguro que desea eliminar al cliente con ID " + id + "?", "Confirmar eliminación",
					 
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1);
			
				
				if(result == System.Windows.Forms.DialogResult.Yes){
					this.eliminarAlumno(id);
					this.actualizarTabla();
					MessageBox.Show("El cliente con el ID " + id + " fue eliminado con exito.");
				}
			}
		}
	}
}
