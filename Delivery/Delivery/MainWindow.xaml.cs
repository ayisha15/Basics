using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Delivery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void O_MouseEnter(object sender, MouseEventArgs e)
        {
            Main.Background = O.Background;

        }

        private void O_MouseLeave(object sender, MouseEventArgs e)
        {
            O.Background = Brushes.Orange;
        }

        private void G_MouseEnter(object sender, MouseEventArgs e)
        {
            Main.Background = G.Background;

        }

        private void G_MouseLeave(object sender, MouseEventArgs e)
        {
            G.Background = Brushes.Green;
        }

        private void R_MouseEnter(object sender, MouseEventArgs e)
        {
            Main.Background = R.Background;

        }

        private void R_MouseLeave(object sender, MouseEventArgs e)
        {
            R.Background = Brushes.Red;

        }

        private void V_MouseEnter(object sender, MouseEventArgs e)
        {
            Main.Background = V.Background;

        }
        private void V_MouseLeave(object sender, MouseEventArgs e)
        {
            V.Background = Brushes.Violet;

        }

        private void Main_MouseEnter(object sender, MouseEventArgs e)
        {
            Main.Background = Main.Background;
        }

        private void Main_MouseLeave(object sender, MouseEventArgs e)
        {
            Main.Background = Brushes.DarkSlateGray;
        }

        private void F_MouseEnter(object sender, MouseEventArgs e)
        {
            Main.Background = F.Background;
        }

        private void F_MouseLeave(object sender, MouseEventArgs e)
        {
            F.Background = Brushes.Fuchsia;

        }

        private void NW_MouseEnter(object sender, MouseEventArgs e)
        {
            Main.Background = NW.Background;
        }

        private void NW_MouseLeave(object sender, MouseEventArgs e)
        {
            NW.Background = Brushes.NavajoWhite;

        }

        private void BA_MouseEnter(object sender, MouseEventArgs e)
        {
            Main.Background = BA.Background;
        }

        private void BA_MouseLeave(object sender, MouseEventArgs e)
        {
            BA.Background = Brushes.BlanchedAlmond;

        }

        private void T_MouseLeave(object sender, MouseEventArgs e)
        {
            T.Background = Brushes.Turquoise;

        }

        private void T_MouseEnter(object sender, MouseEventArgs e)
        {
            Main.Background = T.Background;
        }

        private void P_MouseEnter(object sender, MouseEventArgs e)
        {
            Main.Background = P.Background;
        }

        private void Y_MouseEnter(object sender, MouseEventArgs e)
        {
            Main.Background = Y.Background;
        }

        private void B_MouseEnter(object sender, MouseEventArgs e)
        {
            Main.Background = B.Background;
        }

        private void B2_MouseEnter(object sender, MouseEventArgs e)
        {
            Main.Background = B2.Background;
        }

        private void B2_MouseLeave(object sender, MouseEventArgs e)
        {
            B2.Background = Brushes.Brown;

        }

        private void B_MouseLeave(object sender, MouseEventArgs e)
        {
            B.Background = Brushes.Blue;

        }

        private void Y_MouseLeave(object sender, MouseEventArgs e)
        {
            Y.Background = Brushes.Yellow;

        }

        private void P_MouseLeave(object sender, MouseEventArgs e)
        {
            P.Background = Brushes.Pink;

        }
    }
}