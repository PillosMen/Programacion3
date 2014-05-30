/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 30/05/2014
 * Time: 09:39 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoX
{
	/// <summary>
	/// Description of Nuevo.
	/// </summary>
	public partial class Nuevo : Form
	{
		
		string nombre, apellido, telefono, direccion;
		//string mensaje= "Se guardo con exito";
		Funciones f = new Funciones();
		
		public Nuevo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void CancelarClick(object sender, EventArgs e)
		{
			MainForm mf = new MainForm();
			mf.Show();
			Hide();
		}
		
		void GuardarClick(object sender, EventArgs e)
		{
			nombre = nom.Text;
			apellido = ape.Text;
			telefono = tel.Text;
			direccion = dir.Text;
			
			f.Agregar(nombre, apellido, telefono, direccion);
			
			
	
			//System.Windows.Forms.MessageBox(mensaje);
		}
	}
}
