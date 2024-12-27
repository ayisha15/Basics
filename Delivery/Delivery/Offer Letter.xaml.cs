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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Delivery
{
    /// <summary>
    /// Interaction logic for Offer_Letter.xaml
    /// </summary>
    public partial class Offer_Letter : Window
    {
        public Offer_Letter()
        {
            InitializeComponent();
        }

        private void btnaccept_Click(object sender, RoutedEventArgs e)
        {
            string wel = $"{txtlogo.Text}\r\n \r\n\r\n \r\n{txttitle.Text}\r\n \r\nDear {txtname.Text}, \r\n\r\nCongratulations! We are pleased to confirm that you have been selected to work for {txtcname.Text}. We are delighted to make you the following job offer. \r\n \r\nThe position we are offering you is that of {txtjtitle.Text} at a monthly salary of {txtmonthly.Text} with an annual cost to company {txtCTC.Text}. This position reports to {txtsprtitle.Text}, {txtsprname.Text}. \r\n \r\nBenefits for the position include: (Use if relevant to the position)\r\n•\t[Casual Leave of 12 days per annum]\r\n•\t[Employer State Insurance Corporation ESIC Coverage]\r\n•\t[Health insurance];\r\n•\t[Pension plan];\r\n•\t[Life insurance];\r\n•\t[Disability insurance]\r\n•\r\n\r\n•\t\r\n\r\nWe would like you to start work on {txtstartingdate.Text} at {txtstartingtime.Text}. Please report to {txtreportperson.Text}, for documentation and orientation. If this date is not acceptable, please contact me immediately. \r\n \r\nPlease sign the enclosed copy of this letter and return it to me by {txtlastacceptancedate.Text} to indicate your acceptance of this offer. \r\n \r\nWe are confident you will be able to make a significant contribution to the success of our {txtcname.Text} and look forward to working with you. \r\n \r\nSincerely, \r\n \r\n\r\n\r\n{txtauthorizedperson.Text} \r\n{txtsprtitle}\r\n{txtcname.Text}\r\n";


            //wel = wel.Replace("[Logo]", txtlogo.Text);
            //wel = wel.Replace("[Tittle]", txttitle.Text);
            //wel = wel.Replace("[Name]",txtname.Text);
            //wel = wel.Replace("[Company Name]",txtcname.Text);
            //wel = wel.Replace("[Job Title]",txtjtitle.Text);
            //wel = wel.Replace("[Salary per month]",txtmonthly.Text);
            //wel = wel.Replace("[Annual CTC]",txtCTC.Text);
            //wel = wel.Replace("[Supervisor Title]",txtsprtitle.Text);
            //wel = wel.Replace("[Supervisor Name]",txtsprname.Text);
            //wel = wel.Replace("[Desired starting date]",txtstartingdate.Text);
            //wel = wel.Replace("[Desired starting time]",txtstartingtime.Text);
            //wel = wel.Replace("[Name of person to report on start date]",txtreportperson.Text);
            //wel = wel.Replace("[Last date for offer acceptance]", txtlastacceptancedate.Text);
            //wel = wel.Replace("[Name of person authorized to make offer]", txtauthorizedperson.Text);

            txtoffer.Text = wel;
        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("clear");
        }

        private void txtlogo_TextChanged(object sender, TextChangedEventArgs e)
        {
            lbllen.Content = $"your total length{50-txtlogo.Text.Length}/50";

            if(txtlogo.Text.Length > 40)
            {
                lbllen.Foreground = Brushes.Red;
            }

        }
    } 
}
