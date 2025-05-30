using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox4.Focus();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox5.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox curretcell = sender as TextBox;

            if (char.IsControl(e.KeyChar))
            {
                return; // Permitir teclas de control como Backspace
            }
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Evitar caracteres que no sean letras
            }

            if (curretcell.TextLength == curretcell.MaxLength && curretcell.SelectionLength == 0)
            {
                curretcell.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {

                string palabra = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text;
                char[] palabraChar = palabra.ToCharArray();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData); // Llama al método base para manejar otras teclas
        }
    }
}
