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

namespace ProyectoX
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Nuevo n = new Nuevo();
			n.Show();
			Hide();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Acceso a = new Acceso();
			a.Show();
			Hide();
		}
	}
}
