using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaschenRechner
{
    public partial class Form1 : Form
    {
        private double zahl;
        private double puffer;
        private double ergebnis;
        private Button firstClick;
        private String currentOperation = "Current Operation: ";

        private double plus(double zahl1, double zahl2)
        {
            return zahl1 + zahl2;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void plus()
        {
            double.TryParse(textBoxZahl.Text, out puffer);
            ergebnis = zahl + puffer;
            textBoxErgebnis.Text = ergebnis.ToString();
            zahl = ergebnis;
            puffer = zahl;

        }

        private void minus()
        {
            double.TryParse(textBoxZahl.Text, out puffer);
            ergebnis = zahl - puffer;
            textBoxErgebnis.Text = ergebnis.ToString();
            zahl = ergebnis;
            puffer = zahl;
        }

        private void divi()
        {
            double.TryParse(textBoxZahl.Text, out puffer);
            ergebnis = zahl / puffer;
            textBoxErgebnis.Text = ergebnis.ToString();
            zahl = ergebnis;
            puffer = zahl;
        }

        private void multi()
        {
            double.TryParse(textBoxZahl.Text, out puffer);
            ergebnis = zahl * puffer;
            textBoxErgebnis.Text = ergebnis.ToString();
            zahl = ergebnis;
            puffer = zahl;

        }

        private void buttonErgebnis_Click(object sender, EventArgs e)
        {
            if (firstClick != null)
            {
                if(firstClick.Text == "+")
                {
                    plus();
                }
                else if (firstClick.Text =="-")
                {
                    minus();
                }
                else if (firstClick.Text =="*")
                {
                    multi();
                }
                else if(firstClick.Text == "/")
                {
                    divi();
                }
            }
            firstClick = null;
            textBoxZahl.Text = "";
            labelCurrentOperation.Text = "";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstClick == null)
                {
                    double.TryParse(textBoxZahl.Text, out zahl);
                    firstClick = buttonPlus;
                }
                else
                    plus();
                currentOperation = "Current Operation: +";
                labelCurrentOperation.Text = currentOperation;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstClick == null)
                {
                    double.TryParse(textBoxZahl.Text, out zahl);
                    firstClick = buttonMinus;
                }
                else
                
                    minus();

                currentOperation = "Current Operation: -";
                labelCurrentOperation.Text = currentOperation;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void buttonDivi_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstClick == null)
                {
                    double.TryParse(textBoxZahl.Text, out zahl);
                    firstClick = buttonDivi;
                }
                else
                    divi();

                currentOperation = "Current Operation: /";
                labelCurrentOperation.Text = currentOperation;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstClick == null)
                {
                    double.TryParse(textBoxZahl.Text, out zahl);
                    firstClick = buttonMulti;
                }
                else
                    multi();

                currentOperation = "Current Operation: *";
                labelCurrentOperation.Text = currentOperation;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
