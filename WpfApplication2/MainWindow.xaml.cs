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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2
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

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCong_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            a = int.Parse(txtSoThu1.Text);
            b = int.Parse(txtSoThu2.Text);
            c = a + b;
            txtKetQua.Text = c.ToString();
            txtKetQua.Text = String.Format("{0:0.0}", c);
        }

        private void btnTru_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            a = int.Parse(txtSoThu1.Text);
            b = int.Parse(txtSoThu2.Text);
            c = a - b;
            txtKetQua.Text = c.ToString();
            txtKetQua.Text = String.Format("{0:0.0}", c);
        }

        private void btnNhan_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            a = int.Parse(txtSoThu1.Text);
            b = int.Parse(txtSoThu2.Text);
            c = a * b;
            txtKetQua.Text = c.ToString();
            txtKetQua.Text = String.Format("{0:0.0}", c);
        }

        private void btnChia_Click(object sender, RoutedEventArgs e)
        {
            float a, b, c;
            a = float.Parse(txtSoThu1.Text);
            b = float.Parse(txtSoThu2.Text);
            if (b == 0)
            {
                MessageBox.Show("KHÔNG CHIA ĐƯỢC");
            }
            else
            {
                c = a / b;
                //txtKetQua.Text = c.ToString();
                txtKetQua.Text = String.Format("{0:0.0}", c);
            }
        }

       
    }
}
