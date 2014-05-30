/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 30/05/2014
 * Time: 09:39 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoX
{
	partial class Nuevo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dir = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tel = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.ape = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.nom = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Guardar = new System.Windows.Forms.Button();
			this.Cancelar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(172, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Agregar Registro";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.dir);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.tel);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.ape);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.nom);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(12, 59);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(427, 266);
			this.panel1.TabIndex = 1;
			// 
			// dir
			// 
			this.dir.Location = new System.Drawing.Point(203, 213);
			this.dir.Name = "dir";
			this.dir.Size = new System.Drawing.Size(149, 20);
			this.dir.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(66, 216);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 6;
			this.label5.Text = "Dirección:";
			// 
			// tel
			// 
			this.tel.Location = new System.Drawing.Point(203, 151);
			this.tel.Name = "tel";
			this.tel.Size = new System.Drawing.Size(149, 20);
			this.tel.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(66, 154);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Teléfono:";
			// 
			// ape
			// 
			this.ape.Location = new System.Drawing.Point(203, 85);
			this.ape.Name = "ape";
			this.ape.Size = new System.Drawing.Size(149, 20);
			this.ape.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(66, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Apellido:";
			// 
			// nom
			// 
			this.nom.Location = new System.Drawing.Point(203, 23);
			this.nom.Name = "nom";
			this.nom.Size = new System.Drawing.Size(149, 20);
			this.nom.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(66, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nombre:";
			// 
			// Guardar
			// 
			this.Guardar.Location = new System.Drawing.Point(363, 354);
			this.Guardar.Name = "Guardar";
			this.Guardar.Size = new System.Drawing.Size(75, 23);
			this.Guardar.TabIndex = 2;
			this.Guardar.Text = "GUARDAR";
			this.Guardar.UseVisualStyleBackColor = true;
			this.Guardar.Click += new System.EventHandler(this.GuardarClick);
			// 
			// Cancelar
			// 
			this.Cancelar.Location = new System.Drawing.Point(12, 354);
			this.Cancelar.Name = "Cancelar";
			this.Cancelar.Size = new System.Drawing.Size(75, 23);
			this.Cancelar.TabIndex = 3;
			this.Cancelar.Text = "CANCELAR";
			this.Cancelar.UseVisualStyleBackColor = true;
			this.Cancelar.Click += new System.EventHandler(this.CancelarClick);
			// 
			// Nuevo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(450, 389);
			this.Controls.Add(this.Cancelar);
			this.Controls.Add(this.Guardar);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Name = "Nuevo";
			this.Text = "Nuevo";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button Cancelar;
		private System.Windows.Forms.Button Guardar;
		private System.Windows.Forms.TextBox nom;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox ape;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox dir;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
	}
}
