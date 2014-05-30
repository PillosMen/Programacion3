/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 30/05/2014
 * Time: 10:03 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace ProyectoX 
{
	/// <summary>
	/// Description of Funciones.
	/// </summary>
	public class Funciones : Conexion
	{
		
		public Funciones()
		{
		}
		
		public void Agregar(string nombre, string apellido, string telefono, string direccion){
			this.abrirConexion();
			string sql = "INSERT INTO clientes (nombre, apellido, telefono, direccion) VALUES ('" + nombre + "' , '" + apellido + "' , '" + telefono + "' , '" + direccion + "' )";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		
		private int ejecutarComando(string sql){
			MySqlCommand myCommand = new MySqlCommand(sql,this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		}
	}
}
