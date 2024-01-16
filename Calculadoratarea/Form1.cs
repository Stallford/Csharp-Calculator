namespace Calculadoratarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string op = "";
        double n1 = 0;
        double n2 = 0;
        //Comentario solo para generar un cambio y probar github
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtres.Text == "0")
            {
                txtres.Text = "1";
            }
            else
            {
                txtres.Text = txtres.Text + "1";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtres.Text = "0";
            n1 = 0;
            n2 = 0;
            op = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txtres.TextLength == 1)
            {
                txtres.Text = "0";
            }
            else
            {
                txtres.Text = txtres.Text.Substring(0, txtres.TextLength - 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtres.Text == "0")
            {
                txtres.Text = "2";
            }
            else
            {
                txtres.Text = txtres.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtres.Text == "0")
            {
                txtres.Text = "3";
            }
            else
            {
                txtres.Text = txtres.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtres.Text == "0")
            {
                txtres.Text = "4";
            }
            else
            {
                txtres.Text = txtres.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtres.Text == "0")
            {
                txtres.Text = "5";
            }
            else
            {
                txtres.Text = txtres.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtres.Text == "0")
            {
                txtres.Text = "6";
            }
            else
            {
                txtres.Text = txtres.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtres.Text == "0")
            {
                txtres.Text = "7";
            }
            else
            {
                txtres.Text = txtres.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtres.Text == "0")
            {
                txtres.Text = "8";
            }
            else
            {
                txtres.Text = txtres.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtres.Text == "0")
            {
                txtres.Text = "9";
            }
            else
            {
                txtres.Text = txtres.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtres.Text = txtres.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtres.Text = txtres.Text + ",";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            op = "+";
            n1 = Convert.ToDouble(txtres.Text);
            txtres.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            op = "-";
            n1 = Convert.ToDouble(txtres.Text);
            txtres.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            op = "*";
            n1 = Convert.ToDouble(txtres.Text);
            txtres.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            op = "/";
            n1 = Convert.ToDouble(txtres.Text);
            txtres.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                n2 = Convert.ToDouble(txtres.Text);
                if (op != null)
                {
                    switch (op)
                    {
                        case "+":
                            txtres.Text = $"{n1 + n2}";
                            break;
                        case "-":
                            txtres.Text = $"{n1 - n2}";
                            break;
                        case "*":
                            txtres.Text = $"{n1 * n2}";
                            break;
                        case "/":
                            if (n2 != 0)
                            {
                                txtres.Text = $"{n1 / n2}";
                            }
                            else
                            {
                                throw new DivideByZeroException("Error");
                            }
                            break;
                    }
                }
            }
            catch (Exception)
            {
                txtres.Text = "Error";
            }
        }
    }
}