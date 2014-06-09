/*
 * Created by SharpDevelop.
 * User: Pillos
 * Date: 09/05/2014
 * Time: 09:51 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace ProyectoX
{
	/// <summary>
	/// Description of Conexion.
	/// </summary>
	public class Conexion
	{
		protected MySqlConnection myConnection;
		public Conexion ()
		{
		}

		protected void abrirConexion(){
			string connectionString =
          		"Server=localhost;" +
	          	"Database=catalogo;" +
	          	"User ID=root;" +
	          	"Password=;" +
	          	"Pooling=false;";
	       this.myConnection = new MySqlConnection(connectionString);
	       this.myConnection.Open();
		}

		protected void cerrarConexion(){
			this.myConnection.Close(); 
			this.myConnection = null;
		}

	}
}