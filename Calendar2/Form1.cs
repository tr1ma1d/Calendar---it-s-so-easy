using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar2
{
    
    public partial class Form1 : Form
    {
        public int month, years;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayOfDays();
        }
        private void DisplayOfDays()
        {
            
            DateTime now = DateTime.Now;

            years = now.Year;       // get now Date
            month = now.Month;

            DateTime startofthemonth = new DateTime(years, month, 1); // we get a first day of the month

            int days = DateTime.DaysInMonth(years, month);                           //1.get count days of the month
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));    //2.convert startofthemonth(29) to integer

           for (int i = 0; i < dayoftheweek; i++)                              
           {
                UserControlBl ucblank = new UserControlBl();              //create a blank for write
                daycontainer.Controls.Add(ucblank);
           }
           for (int i = 0; i <= days - 1; i++)                                
           {
                UserControlDays ucdays = new UserControlDays();          //create a blank for number
                ucdays.days(i + 1);
                daycontainer.Controls.Add(ucdays);
           }

        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            month--;
            //clear of the date
            daycontainer.Controls.Clear();
            DateTime startofthemonth = new DateTime(years, month, 1); // we get a first day of the month

            int days = DateTime.DaysInMonth(years, month);                           //1.get count days of the month
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));    //2.convert startofthemonth(29) to integer

            for (int i = 0; i < dayoftheweek; i++)
            {
                UserControlBl ucblank = new UserControlBl();              //create a blank for write
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 0; i <= days - 1; i++)
            {
                UserControlDays ucdays = new UserControlDays();          //create a blank for number
                ucdays.days(i + 1);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            month++;
            //clear of the date
            daycontainer.Controls.Clear();
            DateTime startofthemonth = new DateTime(years, month, 1); // we get a first day of the month

            int days = DateTime.DaysInMonth(years, month);                           //1.get count days of the month
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));    //2.convert startofthemonth(29) to integer

            for (int i = 0; i < dayoftheweek; i++)
            {
                UserControlBl ucblank = new UserControlBl();              //create a blank for write
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 0; i <= days - 1; i++)
            {
                UserControlDays ucdays = new UserControlDays();          //create a blank for number
                ucdays.days(i + 1);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
