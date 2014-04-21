using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace childrensCalculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            InsertDateTimeDefaultValues();
        }

        private void DigitsClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string toDisplay;

            if (is_operator(button.Text))
            {
                toDisplay = button.Text;
            }
            else
            {
                toDisplay = button.Text;
            }
            UpdateDisplay(toDisplay);
        }

        private void UpdateDisplay(string update, Boolean replace = false)
        {
            if (txtOutput.Text == "0" || replace)
            {
                txtOutput.Text = update;
            }
            else
            {
                txtOutput.Text += update;
            }
        }

        private void AddToScreenClicked(object sender, EventArgs e)
        {
            UpdateDisplay(System.Convert.ToString(numUpDown.Value));
        }

        public bool is_operator(string operators)
        {
            var operands = new string[] { "+", "-", "*", "/", "^" };

            return operands.Contains(operators);
        }

        private void CalculateButton(object sender, EventArgs e)
        {
            var input = txtOutput.Text;

            if (input.Contains('^'))
            {
                var index = input.IndexOf('^');
                {
                    var num1 = System.Convert.ToDouble(input.Substring(0, index));
                    var num2 = System.Convert.ToDouble(input.Substring(index + 1));
                    txtOutput.Text = System.Convert.ToString(Math.Pow(num1, num2));
                }
            }
            else
            {
                var something = new DataTable().Compute(input, null);
                txtOutput.Text = System.Convert.ToString(something);
            }
        }

        public void DeleteWasClicked(object sender, EventArgs e)
        {
            var actually_deleted_something = false;

            while (txtOutput.Text.Length > 0)
            {
                var nextChar = txtOutput.Text.Substring(txtOutput.Text.Length - 1);
                if (nextChar != " ")
                {
                    if (actually_deleted_something == true)
                    {
                        break;
                    }
                    actually_deleted_something = true;
                }
                txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.Text.Length - 1);
            }

            if (txtOutput.Text.Length == 0)
            {
                txtOutput.Text = "0";
            }
        }

        public String[] Months()
        {
            var days = new String[12];
            for (var i = 1; i <= 12; i++)
            {
                if ((i - 1) < 10)
                {
                    days[i - 1] = "0" + System.Convert.ToString(i);
                }
                else
                {
                    days[i - 1] = System.Convert.ToString(i);
                }
            }
            return days;
        }

        public String[] Years()
        {
            return Days();
        }

        public String[] Days()
        {
            var days = new String[31];
            for (var i = 1; i <= 31; i++)
            {
                if ((i - 1) < 10)
                {
                    days[i - 1] = "0" + System.Convert.ToString(i);
                }
                else
                {
                    days[i - 1] = System.Convert.ToString(i);
                }
            }
            return days;
        }

        public String[] Hours()
        {
            var hours = new String[12];
            for (var i = 1; i <= 12; i++)
            {
                hours[i - 1] = System.Convert.ToString(i);
            }
            return hours;
        }

        public string[] Minutes()
        {
            var minutes = new string[60];
            for (var i = 0; i <= 59; i++)
            {
                if (i < 10)
                {
                    minutes[i] = "0" + System.Convert.ToString(i);
                }
                else
                {
                    minutes[i] = System.Convert.ToString(i);
                }
            }
            return minutes;
        }

        private void InsertDateTimeDefaultValues()
        {
            this.startMinute.Items.AddRange(Minutes());
            this.finishMinute.Items.AddRange(Minutes());
            this.startHour.Items.AddRange(Hours());
            this.finishHour.Items.AddRange(Hours());
            this.startDay.Items.AddRange(Days());
            this.finishDay.Items.AddRange(Days());
            this.startMonth.Items.AddRange(Months());
            this.finishMonth.Items.AddRange(Months());
            this.startYear.Items.AddRange(Years());
            this.finishYear.Items.AddRange(Years());

            var current = DateTime.Now;
            var year = current.Year;
            var month = current.Month;
            var day = current.Day;
            var hour = current.Hour;
            var minute = current.Minute;

            var ampm = "";
            if (hour >= 12)
            {
                ampm = "P.M.";
            }
            else
            {
                ampm = "A.M.";
            }

            if (year < 10)
            {
                startYear.SelectedItem = "0" + System.Convert.ToString(year).Substring(2);
            }
            else
            {
                startYear.SelectedItem = "" + System.Convert.ToString(year).Substring(2);
            }
           
            if (month < 10)
            {
                startMonth.SelectedItem = "0" + System.Convert.ToString(month);
            }
            else
            {
                startMonth.SelectedItem = "" + System.Convert.ToString(month);
            }
            
            if (day < 10)
            {
                startDay.SelectedItem = "0" + System.Convert.ToString(day);
            }
            else
            {
                startDay.SelectedItem = "" + System.Convert.ToString(day);
            }
            startHour.SelectedItem = System.Convert.ToString(hour);
            
            if (minute < 10)
            {
                startMinute.SelectedItem = "0" + System.Convert.ToString(minute);
            }
            else
            {
                startMinute.SelectedItem = "" + System.Convert.ToString(minute);
            }
            startTime.SelectedItem = ampm;

            var span = new TimeSpan(0, 5, 0, 0);
            var future = DateTime.Now.Add(span);
            year = future.Year;
            month = future.Month;
            day = future.Day;
            hour = future.Hour;
            minute = future.Minute;

            if (hour >= 12)
            {
                ampm = "P.M.";
            }
            else
            {
                ampm = "A.M.";
            }

            if (hour == 0)
            {
                hour = 12;
            }
            else
            {
                hour %= 12;
            }

            
            if (year < 10)
            {
                finishYear.SelectedItem = "0" + System.Convert.ToString(year).Substring(2);
            }
            else
            {
                finishYear.SelectedItem = "" + System.Convert.ToString(year).Substring(2);
            }
            
            if (month < 10)
            {
                finishMonth.SelectedItem = "0" + System.Convert.ToString(month);
            }
            else
            {
                finishMonth.SelectedItem = "" + System.Convert.ToString(month);
            }
           
            if (day < 10)
            {
                finishDay.SelectedItem = "0" + System.Convert.ToString(day);
            }
            else
            {
                finishDay.SelectedItem = "" + System.Convert.ToString(day);
            }

            if (minute < 10)
            {
                finishMinute.SelectedItem = "0" + System.Convert.ToString(minute);
            }
            else
            {
                finishMinute.SelectedItem = "" + System.Convert.ToString(minute);
            }

            finishHour.SelectedItem = System.Convert.ToString(hour);
            finishTime.SelectedItem = ampm;
        }

        private void CalculateTimeClick(object sender, EventArgs e)
        {
            var output = "";
            var startYear = System.Convert.ToInt32("20" + this.startYear.SelectedItem);
            var startMonth = System.Convert.ToInt32(this.startMonth.SelectedItem);
            var startDay = System.Convert.ToInt32(this.startDay.SelectedItem);
            var startHour = System.Convert.ToInt32(this.startHour.SelectedItem);
            var startMinute = System.Convert.ToInt32(this.startMinute.SelectedItem);

            var finishYear = System.Convert.ToInt32("20" + this.finishYear.SelectedItem);
            var finishMonth = System.Convert.ToInt32(this.finishMonth.SelectedItem);
            var finishDay = System.Convert.ToInt32(this.finishDay.SelectedItem);
            var finishHour = System.Convert.ToInt32(this.finishHour.SelectedItem);
            var finishMinute = System.Convert.ToInt32(this.finishMinute.SelectedItem);

            if (startHour < 12 && startTime.SelectedItem == "P.M.")
            {
                startHour += 12;
            }
            else if (startHour == 12 && startTime.SelectedItem == "A.M.")
            {
                startHour = 0;
            }

            if (finishHour < 12 && finishTime.SelectedItem == "P.M.")
            {
                finishHour += 12;
            }
            else if (finishHour == 12 && finishTime.SelectedItem == "A.M.")
            {
                finishHour = 0;
            }
            var start = new DateTime(startYear, startMonth, startDay, startHour, startMinute, 0);
            var finish = new DateTime(finishYear, finishMonth, finishDay, finishHour, finishMinute, 0);
            var delta = finish.Subtract(start);
            output = System.Convert.ToString(delta.Days + " : " + delta.Hours + " : " + delta.Minutes);
            textBox2.Text = output;
        }

        private void CalculateUnitsClick(object sender, EventArgs e)
        {
            var unit = System.Convert.ToDouble(numUnits.Value);
            var from = fromUnit.Text;
            var to = toUnit.Text;
            if (from == "" || to == "")
            {
                MessageBox.Show("Please select from and to units");
            }
            else
            {
                var answer = this.Convert(unit, from, to);
                outputUnits.Text = System.Convert.ToString(answer).Substring(0, 10);

                units.Text = to;
            }
        }

        public double Convert(double unit, String from, String to)
        {
            var answers = new Dictionary<string, double>();
            switch (from)
            {
                case "Kilometers":
                    answers["Kilometers"] = unit;
                    break;

                case "Meters":
                    answers["Kilometers"] = unit / 1000.0;
                    break;

                case "Centimeters":
                    answers["Kilometers"] = unit / 1000.0 / 100.0;
                    break;

                case "Millimeters":
                    answers["Kilometers"] = unit / 1000.0 / 100.0 / 10;
                    break;

                case "Inches":
                    answers["Kilometers"] = unit / 1000.0 / 100.0 * 2.54;
                    break;

                case "Feet":
                    answers["Kilometers"] = unit / 1000.0 / 100.0 * 2.54 * 12.0;
                    break;

                case "Yards":
                    answers["Kilometers"] = unit / 1000.0 / 100.0 * 2.54 * 12.0 * 3.0;
                    break;

                case "Miles":
                    answers["Kilometers"] = unit / 1000.0 / 100.0 * 2.54 * 12.0 * 3.0 * 1760.0;
                    break;
                defualt:
                    Console.WriteLine("DEFAULTED!!");
                    break;
            }
            answers["Meters"] = answers["Kilometers"] * 1000.0;
            answers["Centimeters"] = answers["Meters"] * 100.0;
            answers["Millimeters"] = answers["Centimeters"] * 10.0;
            answers["Inches"] = answers["Centimeters"] / 2.54;
            answers["Feet"] = answers["Inches"] / 12.0;
            answers["Yards"] = answers["Feet"] / 3.0;
            answers["Miles"] = answers["Yards"] / 1760.0;
            return answers[to];
        }
    }
}