using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
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
    /// Interaction logic for Substring.xaml
    /// </summary>
    public partial class Substring : Window
    {
        public Substring()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            erruser.Content ="";
            if (txtpass.Text.Length < 8)
            {
                erruser.Content = ("Password should be in 8 char & must have one special character");
                erruser.Foreground = Brushes.Red;
            }
            else
            {
                erruser.Content = ("Valid password");
                erruser.Foreground = Brushes.Green;
                
            }
        }

       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            char[] val = txtentername.Text.ToCharArray();
            if (val.Length > 0)
            {
                string first = val[0].ToString().ToUpper();
                string remain = "";
                if (val.Length > 1)
                {
                    remain = txtentername.Text.Substring(1).ToLower();

                }
                txtentername.Text = first + remain;

            }
           



            }
    }
}
