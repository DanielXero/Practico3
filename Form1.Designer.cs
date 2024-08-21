using System.Drawing;
using System.Windows.Forms;

namespace Practico3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TTelefono = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TDni = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LModificar = new System.Windows.Forms.Label();
            this.LNya = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RBMujer = new System.Windows.Forms.RadioButton();
            this.RBVaron = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TSalir = new System.Windows.Forms.Button();
            this.TEliminar = new System.Windows.Forms.Button();
            this.TGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TTelefono);
            this.panel1.Controls.Add(this.LTelefono);
            this.panel1.Controls.Add(this.TApellido);
            this.panel1.Controls.Add(this.TNombre);
            this.panel1.Controls.Add(this.TDni);
            this.panel1.Controls.Add(this.LApellido);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Controls.Add(this.LDni);
            this.panel1.Controls.Add(this.LModificar);
            this.panel1.Controls.Add(this.LNya);
            this.panel1.Location = new System.Drawing.Point(21, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 307);
            this.panel1.TabIndex = 0;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(121, 256);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(46, 17);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "Visa";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(121, 277);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(79, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Mastercard";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(121, 234);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Naranja";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tarjeta de Creditos:";
            // 
            // TTelefono
            // 
            this.TTelefono.Location = new System.Drawing.Point(71, 193);
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(86, 20);
            this.TTelefono.TabIndex = 9;
            this.TTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TTelefono_KeyPress);
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(21, 196);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(49, 13);
            this.LTelefono.TabIndex = 8;
            this.LTelefono.Text = "Telefono";
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(70, 158);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(86, 20);
            this.TApellido.TabIndex = 7;
            this.TApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellido_KeyPress);
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(70, 126);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(86, 20);
            this.TNombre.TabIndex = 6;
            this.TNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNombre_KeyPress);
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(70, 94);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(86, 20);
            this.TDni.TabIndex = 5;
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(21, 160);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(51, 13);
            this.LApellido.TabIndex = 4;
            this.LApellido.Text = "* Apellido";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(21, 126);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(51, 13);
            this.LNombre.TabIndex = 3;
            this.LNombre.Text = "* Nombre";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(34, 94);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(33, 13);
            this.LDni.TabIndex = 2;
            this.LDni.Text = "* DNI";
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.ForeColor = System.Drawing.Color.Red;
            this.LModificar.Location = new System.Drawing.Point(121, 33);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(50, 13);
            this.LModificar.TabIndex = 1;
            this.LModificar.Text = "Modificar";
            // 
            // LNya
            // 
            this.LNya.AutoSize = true;
            this.LNya.Location = new System.Drawing.Point(21, 33);
            this.LNya.Name = "LNya";
            this.LNya.Size = new System.Drawing.Size(95, 13);
            this.LNya.TabIndex = 0;
            this.LNya.Text = "Nombre y Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(150, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 45);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nuevo Cliente";
            // 
            // RBMujer
            // 
            this.RBMujer.AutoSize = true;
            this.RBMujer.Location = new System.Drawing.Point(383, 160);
            this.RBMujer.Name = "RBMujer";
            this.RBMujer.Size = new System.Drawing.Size(51, 17);
            this.RBMujer.TabIndex = 14;
            this.RBMujer.Text = "Mujer";
            this.RBMujer.UseVisualStyleBackColor = true;
            this.RBMujer.CheckedChanged += new System.EventHandler(this.RBMujer_CheckedChanged);
            // 
            // RBVaron
            // 
            this.RBVaron.AutoSize = true;
            this.RBVaron.Checked = true;
            this.RBVaron.Location = new System.Drawing.Point(297, 160);
            this.RBVaron.Name = "RBVaron";
            this.RBVaron.Size = new System.Drawing.Size(53, 17);
            this.RBVaron.TabIndex = 13;
            this.RBVaron.TabStop = true;
            this.RBVaron.Text = "Varon";
            this.RBVaron.UseVisualStyleBackColor = true;
            this.RBVaron.CheckedChanged += new System.EventHandler(this.RBVaron_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practico3.Properties.Resources.hombre;
            this.pictureBox1.Location = new System.Drawing.Point(326, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // TSalir
            // 
            this.TSalir.Image = global::Practico3.Properties.Resources.salir;
            this.TSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TSalir.Location = new System.Drawing.Point(411, 397);
            this.TSalir.Name = "TSalir";
            this.TSalir.Size = new System.Drawing.Size(85, 36);
            this.TSalir.TabIndex = 11;
            this.TSalir.Text = "Salir";
            this.TSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TSalir.UseVisualStyleBackColor = true;
            this.TSalir.Click += new System.EventHandler(this.TSalir_Click);
            // 
            // TEliminar
            // 
            this.TEliminar.Image = global::Practico3.Properties.Resources.eliminar;
            this.TEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TEliminar.Location = new System.Drawing.Point(141, 397);
            this.TEliminar.Name = "TEliminar";
            this.TEliminar.Size = new System.Drawing.Size(85, 36);
            this.TEliminar.TabIndex = 9;
            this.TEliminar.Text = "Eliminar";
            this.TEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TEliminar.UseVisualStyleBackColor = true;
            this.TEliminar.Click += new System.EventHandler(this.TEliminar_Click);
            // 
            // TGuardar
            // 
            this.TGuardar.Image = global::Practico3.Properties.Resources.guardar;
            this.TGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TGuardar.Location = new System.Drawing.Point(21, 397);
            this.TGuardar.Name = "TGuardar";
            this.TGuardar.Size = new System.Drawing.Size(85, 36);
            this.TGuardar.TabIndex = 8;
            this.TGuardar.Text = "Guardar";
            this.TGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TGuardar.UseVisualStyleBackColor = true;
            this.TGuardar.Click += new System.EventHandler(this.TGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 435);
            this.Controls.Add(this.RBMujer);
            this.Controls.Add(this.RBVaron);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TEliminar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TGuardar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequeño Formulario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label LNya;
        private Label LModificar;
        private Label LApellido;
        private Label LNombre;
        private Label LDni;
        private TextBox TApellido;
        private TextBox TNombre;
        private TextBox TDni;
        private Button TEliminar;
        private Button TGuardar;
        private Label label1;
        private TextBox TTelefono;
        private Label LTelefono;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label2;
        private Button TSalir;
        private RadioButton RBMujer;
        private RadioButton RBVaron;
        private PictureBox pictureBox1;
    }
}

