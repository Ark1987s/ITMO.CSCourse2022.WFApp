using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSCourse2022.WFApp.Lab02.Ex09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        List<Item> its = new List<Item>();
        public string Author
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }        
        public string PublishHouse
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public int Page
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int InvNumber
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
        public bool Existence
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        public bool SortInvNumber
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }
        public bool ReturnTime
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        public int PeriodUse
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse,
                Page, Year, InvNumber, Existence);
            if (ReturnTime)
                b.ReturnSrok();
            b.PriceBook(PeriodUse);
            its.Add(b);

            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 2000;
            Existence = ReturnTime = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
                its.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();
            if (SortInvNumber)
                its.Sort();
            StringBuilder sb_mag = new StringBuilder();
            foreach (Item item in its)
            {
                sb_mag.Append("\n" + item.ToString());
            }
            richTextBox1.Text = sb_mag.ToString();
        }

        public string Title_mag
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }
        public string Volume_mag
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public int Number_mag
        {
            get { return (int)numericUpDown10.Value; }
            set { numericUpDown10.Value = value; }
        }
        public int Year_mag
        {
            get { return (int)numericUpDown8.Value; }
            set { numericUpDown8.Value = value; }
        }
        public int InvNumber_mag
        {
            get { return (int)numericUpDown6.Value; }
            set { numericUpDown6.Value = value; }
        }
        public bool ReturnTime_mag
        {
            get { return checkBox5.Checked; }
            set { checkBox5.Checked = value; }
        }
        public int PeriodUse_mag
        {
            get { return (int)numericUpDown5.Value; }
            set { numericUpDown5.Value = value; }
        }
        public bool Existence_mag
        {
            get { return checkBox4.Checked; }
            set { checkBox4.Checked = value; }
        }
        public bool Paid_mag
        {
            get { return checkBox6.Checked; }
            set { checkBox6.Checked = value; }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Magazine m = new Magazine(Title_mag, Number_mag, Volume_mag,
                Year_mag, InvNumber_mag, Existence);
            if (ReturnTime)
                m.ReturnSrok_mag();
         //   m.PeriodUse_mag;
            its.Add(m);

            Title_mag = Volume_mag= "";
            Number_mag = Page = InvNumber_mag = PeriodUse_mag = 0;
            Year_mag = 2000;
            Existence_mag = ReturnTime_mag = false;
        }
    }
}
