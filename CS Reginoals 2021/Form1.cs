using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Reginoals_2021
{
    public partial class Form1 : Form
    {
        // chain operations between types of operations don't work
        public Form1()
        {
            InitializeComponent();
        }

        List<object> equation = new List<object> { };

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            equation = new List<object> { };
            CaculatorOutput.Text = "";
        }

        private void Btn0_Click(object sender, EventArgs e) => CaculatorOutput.Text += "0";

        private void DecimalBtn_Click(object sender, EventArgs e) => CaculatorOutput.Text += ".";

        private void EqualsBtn_Click(object sender, EventArgs e)
        {
            equation.Add(CaculatorOutput.Text);
            int finalIndex = 0;
            for (int i = 1; i < equation.Count; i += 2)
            {
                if (equation[i].ToString() == "+")
                {
                    equation[i + 1] = Convert.ToDouble(equation[i - 1]) + Convert.ToDouble(equation[i + 1]);
                }
                else if (equation[i].ToString() == "-")
                {
                    equation[i + 1] = Convert.ToDouble(equation[i - 1]) - Convert.ToDouble(equation[i + 1]);
                }
                else if (equation[i].ToString() == "*")
                {
                    equation[i + 1] = Convert.ToDouble(equation[i - 1]) * Convert.ToDouble(equation[i + 1]);
                }
                else if (equation[i].ToString() == "/")
                {
                    equation[i + 1] = Convert.ToDouble(equation[i - 1]) / Convert.ToDouble(equation[i + 1]);
                }
                finalIndex = i + 1;
            }
            CaculatorOutput.Text = equation[finalIndex].ToString();
            equation = new List<object> { };
        }

        private void PlusBtn_Click(object sender, EventArgs e) => GetEquationPart("+");

        private void Btn1_Click(object sender, EventArgs e) => CaculatorOutput.Text += "1";

        private void Btn2_Click(object sender, EventArgs e) => CaculatorOutput.Text += "2";

        private void Btn3_Click(object sender, EventArgs e) => CaculatorOutput.Text += "3";

        private void MinusBtn_Click(object sender, EventArgs e) => GetEquationPart("-");

        private void Btn4_Click(object sender, EventArgs e) => CaculatorOutput.Text += "4";

        private void Btn5_Click(object sender, EventArgs e) => CaculatorOutput.Text += "5";

        private void Btn6_Click(object sender, EventArgs e) => CaculatorOutput.Text += "6";

        private void BtnX_Click(object sender, EventArgs e) => GetEquationPart("*");

        private void Btn7_Click(object sender, EventArgs e) => CaculatorOutput.Text += "7";

        private void Btn8_Click(object sender, EventArgs e) => CaculatorOutput.Text += "8";

        private void Btn9_Click(object sender, EventArgs e) => CaculatorOutput.Text += "9";

        private void SlashBtn_Click(object sender, EventArgs e) => GetEquationPart("/");

        private void GetEquationPart(string operation)
        {
            try
            {
                equation.Add(Convert.ToDouble(CaculatorOutput.Text));
                equation.Add(operation);
                CaculatorOutput.Text = "";
            }
            catch (FormatException)
            {
                Console.WriteLine();
            }
        }

        // tab divider
        double principle;
        double inrestRate;
        int years;
        int numOfCompounds = 12;

        private void PrincipleBox_TextChanged(object sender, EventArgs e)
        {
            if (PrincipleBox.Text != string.Empty)
            {
                try
                {
                    principle = Convert.ToDouble(PrincipleBox.Text);
                }
                catch (FormatException)
                {
                    PrincipleBox.Text = string.Empty;
                    MessageBox.Show("Not a number", "warning", MessageBoxButtons.OK);
                }
            }
        }

        private void IntrestRateBox_TextChanged(object sender, EventArgs e)
        {
            if (IntrestRateBox.Text != string.Empty)
            {
                try
                {
                    inrestRate = Convert.ToDouble(IntrestRateBox.Text);
                }
                catch (FormatException)
                {
                    IntrestRateBox.Text = string.Empty;
                    MessageBox.Show("Not a number", "warning", MessageBoxButtons.OK);
                }
            }
        }

        private void TimeBox_TextChanged(object sender, EventArgs e)
        {
            if (TimeBox.Text != string.Empty)
            {
                try
                {
                    years = Convert.ToInt32(TimeBox.Text);
                }
                catch (FormatException)
                {
                    TimeBox.Text = string.Empty;
                    MessageBox.Show("Not a number", "Warning", MessageBoxButtons.OK);
                }
            }
        }

        private void MonthlyCompound_CheckedChanged(object sender, EventArgs e) => numOfCompounds = (numOfCompounds != 12) ? 12 : 0;

        private void QuartarlyCompound_CheckedChanged(object sender, EventArgs e) => numOfCompounds = (numOfCompounds != 4) ? 4 : 0;

        private void SemiAnualCompound_CheckedChanged(object sender, EventArgs e) => numOfCompounds = (numOfCompounds != 2) ? 2 : 0;

        private void AnuallyCompound_CheckedChanged(object sender, EventArgs e) => numOfCompounds = (numOfCompounds != 1) ? 1 : 0;

        private void CaculateBtn_Click(object sender, EventArgs e)
        {
            double value = principle * Math.Pow(1 + (inrestRate/100 / numOfCompounds), numOfCompounds * years);
            value = Math.Round(value, 2);

            InterestOutput.Text = "$" + value.ToString();
        }
    }
}
