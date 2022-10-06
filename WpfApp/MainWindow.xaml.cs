using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string fn = txtFN.Text;
            if (fn == "")
                fn = "Anonymous";
            string sn = txtSn.Text;
            if (sn == "")
                sn = "Anonymous";
            string dob = dtpDob.Text.ToString();
            if (dob == "")
                dob = "Unknown";
            string message = txtMessage.Text;
            if(message == "")
                message = "NO MESSAGE";

            MessageBox.Show($"Mr. {sn.ToUpper()}, {fn}\nBorn in {dob}\nSent the following message:\n\t{message}");
        }

    
    }
}
