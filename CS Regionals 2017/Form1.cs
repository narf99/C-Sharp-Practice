using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Regionals_2017
{
    public partial class Form1 : Form
    {
        string month;
        static readonly string[] months = {"January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
        int monthInt;
        string stringYear;
        int year;
        bool validYear = false;
        bool paydays;
        bool firstBuisness;
        bool lastBuisness;

        public Form1()
        {
            InitializeComponent();
        }

        private void MonthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            month = MonthBox.SelectedItem.ToString();
        }

        private void YearBox_TextChanged(object sender, EventArgs e)
        {
            stringYear = YearBox.Text;

            try
            {
                if (stringYear.Length == 4)
                {
                    year = Convert.ToInt32(stringYear);

                    if (year >= 2010 && year <= 2300)
                    {
                        validYear = true;
                    }
                    else
                    {
                        validYear = false;
                        YearBox.Text = "";
                        year = 0;
                    }
                }
                else
                {
                    Convert.ToInt32(stringYear);
                }
            }
            catch (FormatException)
            {
                YearBox.Text = "";
            }
        }

        private void PaydaysCheckBox_CheckedChanged(object sender, EventArgs e) => paydays = ToggleCheckBox(paydays);

        private void FirstDay_CheckedChanged(object sender, EventArgs e) => firstBuisness = ToggleCheckBox(firstBuisness);

        private void LastDay_CheckedChanged(object sender, EventArgs e) => lastBuisness = ToggleCheckBox(lastBuisness);

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Output.Text = "";
            YearBox.Text = "";
            MonthBox.SelectedIndex = 0;
            PaydaysCheckBox.Checked = false;
            FirstDay.Checked = false;
            LastDay.Checked = false;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            if (validYear && month != string.Empty && (paydays || firstBuisness || lastBuisness))
            {
                Output.Text = "";

                // this converts the string month to an integer
                for (int i = 0; i < 12; i++)
                {
                    if (month == months[i])
                    {
                        monthInt = i+1;
                        break;
                    }
                }

                DateTime thisMonth = new DateTime(year, monthInt, 1);

                // this finds the first buisness day
                if (firstBuisness)
                {
                    // this works by going through a month and searching for the first day that isn't a weekend


                    for (int i = 0; i < DateTime.DaysInMonth(year, monthInt); i++)
                    {
                        if (thisMonth.DayOfWeek != DayOfWeek.Sunday && thisMonth.DayOfWeek != DayOfWeek.Saturday)
                        {
                            Output.Text += "The first buisness day of the month is " + thisMonth.ToString("d") + "\n";
                            break;
                        }

                        thisMonth = thisMonth.AddDays(1);
                    }
                }

                // this finds the paydays
                if (paydays)
                {
                    // this works by finding all of the fridays but only doing things on the first and third fridays
                    int numOfFridaysFound = 0;
                    thisMonth = new DateTime(year, monthInt, 1); // declare a new date and time at the begining of the month

                    // move through the month
                    for (int i = 0; i < DateTime.DaysInMonth(year, monthInt); i++)
                    {
                        if (thisMonth.DayOfWeek == DayOfWeek.Friday)
                        {
                            numOfFridaysFound += 1;

                            if (numOfFridaysFound == 1)
                            {
                                Output.Text += "The first pay day of the month is " + thisMonth.ToString("d") + "\n";
                            }
                            else if (numOfFridaysFound == 3)
                            {
                                Output.Text += "The second pay day of the month is " + thisMonth.ToString("d") + "\n";
                                break;
                            }
                        }

                        // move forward a day
                        thisMonth = thisMonth.AddDays(1);
                    }
                }

                // this finds the last buisness day
                if (lastBuisness)
                {
                    // this works the same as the first buisness day just in reverse

                    thisMonth = new DateTime(year, monthInt, DateTime.DaysInMonth(year, monthInt)); // declare a new date and time at the end of the month

                    for (int i = DateTime.DaysInMonth(year, monthInt); i > 0; i--)
                    {
                        // check to see if today is a week day
                        if (thisMonth.DayOfWeek != DayOfWeek.Sunday && thisMonth.DayOfWeek != DayOfWeek.Saturday)
                        {
                            Output.Text += "The last buisness day of the month is " + thisMonth.ToString("d") + "\n";
                            break;
                        }

                        thisMonth = thisMonth.AddDays(-1);
                    }
                }
            }
        }

        private bool ToggleCheckBox(bool checkBox)
        {
            if (checkBox)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
