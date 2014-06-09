/*
 * Created by SharpDevelop.
 * User: AMD
 * Date: 08/06/2014
 * Time: 11:34 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoX
{
	/// <summary>
	/// Description of Editar.
	/// </summary>
	public partial class Editar : Form
	{
		string nombre, apellido, telefono, direccion, id;
		string mensaje= "Se Actualizo con exito";
		Funciones f = new Funciones();
		MainForm mf = new MainForm();
		
		public Editar(string id, string nombre, string apellido, string telefono, string domicilio)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			Id.Text = id;
			nom.Text = nombre;
			ape.Text = apellido;
			tel.Text = telefono;
			dir.Text = domicilio;
			
			nom.Focus();
			
		}
		
		
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
	
			mf.Show();
			Hide();
		}
		
		void BtnEditarClick(object sender, EventArgs e)
		{
			
			id = Id.Text;
		    nombre = nom.Text;
			apellido = ape.Text;
			telefono = tel.Text;
			direccion = dir.Text;
			
			f.EditarRegistro(id, nombre, apellido, telefono, direccion);
			
			System.Windows.Forms.MessageBox.Show(mensaje);
			
			mf.actualizarTabla();
			
			mf.Show();
			Hide();
		}
	}
}
