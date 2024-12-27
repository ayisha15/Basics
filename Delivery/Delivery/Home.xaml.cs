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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Home : Window
    {
        string output = "";
        string firstnumber = "";
        string secondnumber = "";
        int result = 0;
        string oper = "";


        public Home()
        {
            InitializeComponent();
        }

        private void oper_Click(object sender, RoutedEventArgs e)
        {
            Button button= (Button)sender;
            oper = button.Content.ToString();
            output = output + oper;
            txtresult.Text = output;

        }

        

        private void number_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
           
            if (oper == "")
            {
                firstnumber = firstnumber + button.Content;
                output = firstnumber;
                txtresult.Text = output;
            }
            else
            {
               //if(secondnumber=="")
               // {
               //     output = output + "\n";
               // }
                                              
                secondnumber = secondnumber + button.Content;
                output = output+button.Content;
                txtresult.Text = output;
            }
        }
     
        private void Btdequl_Click(object sender, RoutedEventArgs e)
        {

            int first = Convert.ToInt32(firstnumber);
            int second = Convert.ToInt32(secondnumber);
            output = output+"=\n";
            if (oper == "+") 
            {

                result = first + second;
            }
            else if(oper == "-")
            {

                result = first - second;
            }

            else if (oper == "*")
            {

                result = first * second;
            }

            else if (oper == "/")
            {

                result = first / second;
            }

            output = output+result.ToString();
            txtresult.Text = output;



        }
        private void Btdclear_Click(object sender, RoutedEventArgs e)
        {
            firstnumber ="";
            secondnumber ="";
            oper ="";
            output="";
            txtresult.Text ="";
        }

       
    }



}
