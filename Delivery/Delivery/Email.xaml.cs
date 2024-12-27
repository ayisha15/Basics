using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Delivery
{
    /// <summary>
    /// Interaction logic for Email.xaml
    /// </summary>
    public partial class Email : Window
    {
        public Email()
        {
            InitializeComponent();
            //string[] country = { "Afghanistan", "Belgium", "india", "USA", "UAE" };
            //cmbcountry.ItemsSource = country;
            cmbcountry.Items.Add("India");
            cmbcountry.Items.Add("USA");
            cmbcountry.Items.Add("UAE");
            cmbcountry.Items.Add("Thaiwan");


        }

        private void btnsend_Click(object sender, RoutedEventArgs e)
        {
            string[] email = txtTo.Text.Split(";");
            int count = email.Length;
            for (int i = 0; i < count; i++)
            {
                MessageBox.Show(email[i]);
            }

        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            string[] product = txtpro.Text.Split("\r\n");
            int count = product.Length;
            for (int i = 0; i < count; i++)
            {
                string[] qty = product[i].Split(",");
                string val = $"product name {qty[0]} number of qty{qty[1]}";
                MessageBox.Show(val);
            }

        }

        private void btnload_Click(object sender, RoutedEventArgs e)
        {
            string[] Skills = { "MS EXCEL", "C", "C++", "JAVA", "Python" };
            lstskills.ItemsSource = Skills;
        }

        private void btnadd2_Click(object sender, RoutedEventArgs e)
        {
            cmbcountry.Items.Add(txtname.Text);
        }

        private void btninsert_Click(object sender, RoutedEventArgs e)
        {
            cmbcountry.Items.Insert(0,txtname.Text);
        }

        private void btnremove_Click(object sender, RoutedEventArgs e)
        {
            cmbcountry.Items.Remove("India");
        }

        private void btnremoveat_Click(object sender, RoutedEventArgs e)
        {
            cmbcountry.Items.RemoveAt(0);
        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            cmbcountry.Items.Clear();
        }
    }
}