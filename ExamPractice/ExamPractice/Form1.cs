using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamPractice
{
    public partial class Form1 : Form
    {
        List<Person> person = new List<Person>()
        {
            new Person("Jacob", "Johnson", "Abbotsford"),
            new Person("Michael", "Williams", "Aberdeen"),
            new Person("Joshua", "Brown", "Abilene"),
            new Person("Mathew", "Jones", "Aberdeen")
        };
        public Form1()
        {
            BackColor = Color.LightBlue;
            InitializeComponent();
            listBox1.DataSource = person;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;

            var selPersons = (from p in person
                                  where p.City == city
                                  select p).ToList();//city lookup

            listBox2.DataSource = selPersons;
        }

    }
}
