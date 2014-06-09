/*
 * Created by SharpDevelop.
 * User: AMD
 * Date: 08/06/2014
 * Time: 11:34 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoX
{
	partial class Editar
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.nom = new System.Windows.Forms.TextBox();
			this.ape = new System.Windows.Forms.TextBox();
			this.tel = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dir = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Id = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.BtnEditar = new System.Windows.Forms.Button();
			this.BtnCancelar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Blue;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(-1, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(377, 67);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(46, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(318, 55);
			this.label1.TabIndex = 0;
			this.label1.Text = "Editar Registro";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.nom);
			this.panel2.Controls.Add(this.ape);
			this.panel2.Controls.Add(this.tel);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.dir);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.Id);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(12, 95);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(351, 313);
			this.panel2.TabIndex = 1;
			// 
			// nom
			// 
			this.nom.Location = new System.Drawing.Point(144, 71);
			this.nom.Name = "nom";
			this.nom.Size = new System.Drawing.Size(166, 20);
			this.nom.TabIndex = 9;
			// 
			// ape
			// 
			this.ape.Location = new System.Drawing.Point(144, 125);
			this.ape.Name = "ape";
			this.ape.Size = new System.Drawing.Size(166, 20);
			this.ape.TabIndex = 8;
			// 
			// tel
			// 
			this.tel.Location = new System.Drawing.Point(144, 190);
			this.tel.Name = "tel";
			this.tel.Size = new System.Drawing.Size(166, 20);
			this.tel.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(49, 128);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Apellidos:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(49, 193);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Teléfono:";
			// 
			// dir
			// 
			this.dir.Location = new System.Drawing.Point(144, 262);
			this.dir.Name = "dir";
			this.dir.Size = new System.Drawing.Size(166, 20);
			this.dir.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(49, 265);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 3;
			this.label5.Text = "Domicilio:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(49, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Nombre:";
			// 
			// Id
			// 
			this.Id.Enabled = false;
			this.Id.Location = new System.Drawing.Point(144, 18);
			this.Id.Name = "Id";
			this.Id.Size = new System.Drawing.Size(74, 20);
			this.Id.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(49, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Id:";
			// 
			// BtnEditar
			// 
			this.BtnEditar.Location = new System.Drawing.Point(288, 436);
			this.BtnEditar.Name = "BtnEditar";
			this.BtnEditar.Size = new System.Drawing.Size(75, 23);
			this.BtnEditar.TabIndex = 2;
			this.BtnEditar.Text = "Editar";
			this.BtnEditar.UseVisualStyleBackColor = true;
			this.BtnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// BtnCancelar
			// 
			this.BtnCancelar.Location = new System.Drawing.Point(12, 436);
			this.BtnCancelar.Name = "BtnCancelar";
			this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
			this.BtnCancelar.TabIndex = 3;
			this.BtnCancelar.Text = "Cancelar";
			this.BtnCancelar.UseVisualStyleBackColor = true;
			this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 22);
			this.label2.TabIndex = 4;
			this.label2.Text = "Datos";
			// 
			// Editar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(375, 477);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BtnCancelar);
			this.Controls.Add(this.BtnEditar);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Editar";
			this.Text = "Editar";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Id;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox dir;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tel;
		private System.Windows.Forms.TextBox ape;
		private System.Windows.Forms.TextBox nom;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button BtnCancelar;
		private System.Windows.Forms.Button BtnEditar;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}
