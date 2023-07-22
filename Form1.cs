using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculateyourdateofbirth
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
        

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime Date = new DateTime();
            
            dateTimePickerBirthdate.MaxDate = DateTime.Today;
           
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime birthdate = dateTimePickerBirthdate.Value;
            DateTime today = DateTime.Today;
            int ageInDays = (today - birthdate).Days;
            int ageInYear;
            int ageInMonth;
            int NumberInMonth;
            NumberInMonth = DateTime.DaysInMonth(birthdate.Year, birthdate.Month);
            if (DateTime.IsLeapYear(birthdate.Year))
            {              
                ageInYear = ageInDays / 366;
            }
            else
            {
                ageInYear = ageInDays / 365;
            }
            ageInMonth = ageInDays / NumberInMonth;
            int ageInHours = ageInDays * 24;
            int ageInMinute = ageInHours * 60;
            int ageInSecond = ageInMinute * 60;
            MessageBox.Show("عمرك بالسنوات : " + ageInYear.ToString() + "\n عمرك بالاشهر : " + ageInMonth.ToString()
                +"\n" + "عمرك بالايام : " + ageInDays.ToString() + "\n" + "عمرك بالساعات : " + ageInHours.ToString()
                + "\n" + "عمرك الدقائق : " + ageInMinute.ToString() + "\n" + "عمرك بالثواني : " + ageInSecond.ToString(), "Detals", MessageBoxButtons.OK) ;
        }

        private void dateTimePickerBirthdate_ValueChanged(object sender, EventArgs e)
        {
            txtDate.Text = dateTimePickerBirthdate.Value.ToString();
        }
    }
}
