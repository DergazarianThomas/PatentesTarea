using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Patentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPatente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPatente.Text.Length < 2)
            {
                if ((!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))) 
                {
                    MessageBox.Show("Formato equivocado, solo se permiten letras", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }

                if (txtPatente.Text.Length == 3)
                {
                    if ((!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)))
                    {
                        if (txtPatente.Text.Length < 2)
                        {
                            if ((!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)))
                            {
                                MessageBox.Show("Formato equivocado, solo se permiten letras", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                e.Handled = true;
                                return;
                            }
                        }

                        if (txtPatente.Text.Length > 1 && txtPatente.Text.Length < 5)
                        {
                            if ((!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar)))
                            {
                                MessageBox.Show("Formato equivocado, solo se permiten numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                e.Handled = true;
                                return;
                            }
                        }

                        if (txtPatente.Text.Length > 4)
                        {
                            if ((!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)))
                            {
                                MessageBox.Show("Formato equivocado, solo se permiten Letras", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                e.Handled = true;
                                return;
                            }
                        }
                    }
                }

                if (txtPatente.Text.Length == 2)
                {
                    if ((!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar)))
                    {

                        txtPatente.MaxLength = 6;
                        if (txtPatente.Text.Length < 3)
                        {
                            if ((!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)))
                            {
                                MessageBox.Show("Formato equivocado, solo se permiten letras", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                e.Handled = true;
                                return;
                            }
                        }

                        if (txtPatente.Text.Length > 2)
                        {
                            if ((!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar)))
                            {
                                MessageBox.Show("Formato equivocado, solo se permiten numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                e.Handled = true;
                                return;
                            }
                        }
                    }
                }
            }
        }

        private void txtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("Formato equivocado, solo se permiten Numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnCuit_Click(object sender, EventArgs e)
        {
            if (txtCuit.Text.Length != 11)
            {
                MessageBox.Show("Debe ingresar un CUIT completo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            lblDni.Text = txtCuit.Text.Substring(2, 8);

            lblCuit.Text = txtCuit.Text.Substring(0, 2) + "-" + txtCuit.Text.Substring(2, 8) + "-" + txtCuit.Text.Substring(10, 1); ;
        }

        private void btnPatente_Click(object sender, EventArgs e)
        {
            if (rbFormato1.Checked)
            {
                if(txtPatente.Text.Length != 7) 
                {
                    MessageBox.Show("Complete la patente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (rbFormato2.Checked)
            {
                if (txtPatente.Text.Length != 6)
                {
                    MessageBox.Show("Complete la patente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            lblPatente.Text = txtPatente.Text;
        }

        private void rbFormato1_CheckedChanged(object sender, EventArgs e)
        {
            txtPatente.Text = "";
        }

        private void rbFormato2_CheckedChanged(object sender, EventArgs e)
        {
            txtPatente.Text = "";
        }
    }
}
