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
    /// Interaction logic for LOGIN_FORM.xaml
    /// </summary>
    public partial class LOGIN_FORM : Window
    {
        string username = "Ayesha";
        string password = "Umar";
        int chances=1;
        
        
        
        public LOGIN_FORM()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            errusername.Content="";
           if (string.IsNullOrEmpty(txtusername.Text) || string.IsNullOrEmpty(pwpassword.Password))
            

                {
                    errusername.Content = ("please enter username & password");
                      
                }

                      
                                                        
            else


            {
                if (username == txtusername.Text && password == pwpassword.Password)
               
                {
                    MessageBox.Show("valid user & password");

                }
                else
                { 
                                        
                        if (chances == 1)
                        {

                            MessageBox.Show("Invalid user & password");
                            

                    }
                        else if (chances == 2)
                        {
                            MessageBox.Show("Alert!!You have oonly one login attempt remaining.please ensure your credentials are correct.if you fail this attempt,your account will be locked for security resons");
                        
                    }
                        else if (chances == 3)
                        {
                            MessageBox.Show("Your account has been Locked due to too many attempts");
                            btn_login.IsEnabled = false;
                            txtusername.IsReadOnly = true;
                            pwpassword.IsEnabled = false;
                           

                        }
                    chances++;



                }


            }
            
              
        }

        private void rejister_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnreset_Click(object sender, RoutedEventArgs e)
        {
            
            
                MessageBox.Show("Your account has been reactivated");
                chances = 1;
                txtusername.IsReadOnly = false;
                pwpassword.IsEnabled = true;
                btn_login.IsEnabled = true;



        }
    }
}
