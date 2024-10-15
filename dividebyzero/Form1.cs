using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace dividebyzero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double täljare = double.Parse(textBox1.Text);
                double nämnare = double.Parse(textBox2.Text);

                double svar = Divide(täljare, nämnare);

                MessageBox.Show("svaret är " + svar);
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("skriv in ett tall pucko!");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("dela inte med noll!");
            }


/*            if (textBox1.Text is string || textBox2.Text is string)
            {
                throw new Exception("Du måste skriva ett tal!");
            }
            
            Divide(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
*/        }

        private double Divide(double täljare, double nämnare)
        {
            if (nämnare == 0)
            {
                throw new DivideByZeroException("Du kan inte dela med noll!");
            }
            return täljare / nämnare;
        }
    }
}
