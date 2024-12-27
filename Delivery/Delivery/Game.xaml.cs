using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
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
    public partial class Window1 : Window
    {
        bool start = false;
        int count = 0;
        public Window1()
        {
            InitializeComponent();
        }

        private void btnstart_Click(object sender, RoutedEventArgs e)
        {
            start = true;
            MessageBox.Show("game started!!Have a lucky Day");
        }

        private void btnexit_Click(object sender, RoutedEventArgs e)
        {

            if (start == true)
            {
                MessageBoxResult msg = MessageBox.Show("Are you want to exit the game?", "luckyprice", MessageBoxButton.YesNo);

                if (msg == MessageBoxResult.Yes)
                {
                    start = false;
                    lblcash.Content = 0;
                    count = 0;

                }
            }
            else
            {
                MessageBox.Show("please click on start before exit the game");
            }

        }

        private void number_Click(object sender, RoutedEventArgs e)

        {
            if (start == true)
                
            {
                if(count >= 3)

                {  
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Your three chance is over!your cash price");
                    sb.Append (lblcash.Content);
                    MessageBox.Show(sb.ToString());
                }

                else
                {
                    Button btn = (Button)sender;
                    if(btn.Background != Brushes.Blue)
                    {
                        btn.Content = btn.Tag;
                        btn.Background = Brushes.Blue;
                        btn.IsEnabled = true;
                        count = count + 1;
                        int value = Convert.ToInt32(lblcash.Content);
                        value = value + Convert.ToInt32(btn.Tag);
                        lblcash.Content = value;
                    }
                   else
                    {
                        MessageBox.Show("This box already selected!select another one");
                    }
                }
                
               

            }

            else
            {

                MessageBox.Show("Before enter into the GAME,please click on start");

            }





        }

        private void btnew_Click(object sender, RoutedEventArgs e)
        {
          UIElementCollection buttons = mainstack.Children;
          int count = buttons.Count;
           for (int i = 0; i < count; i++)
           {
              if (buttons [i] is Button) 
              {
                Button btn = (Button)buttons[i];
                btn.Content = btn.Tag;
                string val= btn.Tag.ToString();
                MessageBox.Show(val);
                btn.Background = Brushes.Blue;
                btn.IsEnabled = true;
              
              }
                start = false;
                lblcash.Content= 0;

           }
          
           

        }
    }

}