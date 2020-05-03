using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_po_kriptografii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string print(int []a)
        {
            string str = "";
            for (int i = 0; i < a.Length; i++)
            {
                str += a[i].ToString();
            }


            return str;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int[] a = new int[str.Length];
            int[] b = new int[str.Length] ;
            int[] c = new int[str.Length] ;

           
            
          for (int i = 0; i < str.Length; i++)
            {
                a[i] = Convert.ToInt32(str[i].ToString());
                b[i] = 0;
                c[i] = 0;
            }
            label1.Text = label1.Text + print(b) + "\n";
            for (int i = 0; i < str.Length; i++)
            {
                if (i-2<0 && i - 6 < 0 && i - 12 < 0 )
                {
                    b[i] = a[i];
                    label1.Text = label1.Text + print(b) + "\n";
                }
                else if (i - 2 >= 0 && i - 6 < 0 && i - 12 < 0)
                {
                    b[i] = a[i] ^ b[i - 2];
                    label1.Text = label1.Text + print(b) + "\n";

                }
                else if (i - 2 >= 0 && i - 6 >= 0 && i - 12 < 0)
                {
                    b[i] = a[i] ^ b[i - 2] ^ b[i - 6];
                    label1.Text = label1.Text + print(b) + "\n";

                }
                else if (i - 2 >= 0 && i - 6 >= 0 && i - 12 >= 0)
                {
                    b[i] = a[i] ^ b[i - 2] ^ b[i - 6] ^ b[i - 12];
                    label1.Text = label1.Text + print(b) + "\n";
                }
                
            }
            label6.Text = print(b);

            label8.Text = label8.Text + print(b) + "\n";
            for (int i = 0; i < str.Length; i++)
            {
                if (i - 2 < 0 && i - 6 < 0 && i - 12 < 0)
                {
                    c[i] = b[i];
                    label8.Text = label8.Text + print(c) + "\n";
                }
                else if (i - 2 >= 0 && i - 6 < 0 && i - 12 < 0)
                {
                    c[i] = b[i] ^ b[i - 2];
                    label8.Text = label8.Text + print(c) + "\n";

                }
                else if (i - 2 >= 0 && i - 6 >= 0 && i - 12 < 0)
                {
                    c[i] = b[i] ^ b[i - 2] ^ b[i - 6];
                    label8.Text = label8.Text + print(c) + "\n";

                }
                else if (i - 2 >= 0 && i - 6 >= 0 && i - 12 >= 0)
                {
                    c[i] = b[i] ^ b[i - 2] ^ b[i - 6] ^ b[i - 12];
                    label8.Text = label8.Text + print(c) + "\n";
                }

            }
            //label6.Text = print(c);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text.Length.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
