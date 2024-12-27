using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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
    /// Interaction logic for Exam.xaml
    /// </summary>
    public partial class Exam : Window
    {
        public Exam()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rbval = (RadioButton)sender;
            if(rbval.Tag.ToString()=="Y")
            {
                int val = Convert.ToInt32(lblmarks.Content);
                val=val+2;
                lblmarks.Content=val.ToString();

            }

            StackPanel stp = (StackPanel) rbval.Parent;

            int count = stp.Children.Count;

            for(int i = 0; i < count; i++)

            {
                RadioButton rbrequest = (RadioButton)stp.Children[i];
                rbrequest.IsEnabled = false;
            }

                           

        }
    }
}
