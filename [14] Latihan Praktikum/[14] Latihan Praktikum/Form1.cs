using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14__Latihan_Praktikum
{
    public partial class FormCekPalindrom : Form
    {
        public FormCekPalindrom()
        {
            InitializeComponent();
        }

        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonOK_Click(sender, e);
                textBoxInput.Text = "";
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {          
            string input = textBoxInput.Text;
            string cek = "";
            for (int i= input.Length-1; i>=0; i--)
            {
                cek = cek + input[i];
            }
            if (input == cek)
            {
                label1.Text = "Palindrom";
            }
            else
            {
                label1.Text = "Bukan Palindrom";
            }
        }
    }
}
