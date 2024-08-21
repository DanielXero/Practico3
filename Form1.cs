using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.hombre;
        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.mujer__2_;
        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            /// Permite solo n�meros y teclas de control
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                /// Cancela el evento si se ingresa un car�cter no permitido
                e.Handled = true;
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, espacios y teclas de control
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, espacios y teclas de control
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            /// Permite solo n�meros y teclas de control
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                /// Cancela el evento si se ingresa un car�cter no permitido
                e.Handled = true;
            }
        }

        private void TGuardar_Click(object sender, EventArgs e)
        {
            DialogResult ask; // es para c#

            if (TDni.Text == "" || TNombre.Text == "" || TApellido.Text == "")
            {

                MessageBox.Show("Debe Completar todos los campo,", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
            else
            {
                LModificar.Text = $"{TNombre.Text} {TApellido.Text}";

                ask = MessageBox.Show("Seguro que desea insertar un nuevo Cliente?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    MessageBox.Show($"El Cliente: {TNombre.Text} {TApellido.Text} se insertó Correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
        }

        private void TEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ask;
            if (!(TDni.Text == "") && !(TNombre.Text == "") && !(TApellido.Text == ""))
            {

                ask = MessageBox.Show($"Está apunto de eliminar el Cliente: {TNombre.Text} {TApellido.Text}", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                // MessageBoxDefaultButton.Button2 -> cambia el focus del boton
                if (ask == DialogResult.Yes)
                {
                    TDni.Clear();
                    TNombre.Clear();
                    TApellido.Clear();
                    TTelefono.Clear();
                    LModificar.ResetText();
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    RBVaron.Checked = true;


                    MessageBox.Show($"El Cliente: {TNombre.Text} {TApellido.Text} se elimino correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
        }
    }
}
