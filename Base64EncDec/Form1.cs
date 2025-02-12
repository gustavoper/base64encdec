using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64EncDec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnEncDec_Click(object sender, EventArgs e)
        {
            var optEncDec = "Encode";
            var txtResult = "";
            var previousData = rtbResult.Text;
            if (rtbData.Text != null)
            {
                if (listBox1.Text != null)
                {
                    optEncDec = listBox1.Text;
                }
                
                switch (optEncDec)
                {
                    case "Encode":
                        txtResult = encode(rtbData.Text, previousData);
                        break;
                    case "Decode":
                        txtResult = decode(rtbData.Text, previousData);
                        break;
                    default:
                        MessageBox.Show("Selecione uma opção!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                rtbResult.Text = txtResult;
            }
        }

        private String encode(String input, string previousData)
        {
            try {
                var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(input);
                return System.Convert.ToBase64String(plainTextBytes);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return previousData; 
            }
        }

        private String decode(String input, string previousData)
        {
            try
            {
                var base64EncodedBytes = System.Convert.FromBase64String(input);
                return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return previousData;
            }
        }

        private void rtbResult_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void rtbData_TextChanged(object sender, EventArgs e)
        {
        }
    }
}