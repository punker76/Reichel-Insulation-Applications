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
using MahApps.Metro.Controls;
using System.Globalization;

namespace RI_Core
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            var ci = new CultureInfo("En-US");
            ci.DateTimeFormat.LongTimePattern = ci.DateTimeFormat.ShortTimePattern;

            dtPicker.Culture = ci;
            dtPicker.SelectedDate = DateTime.Now;
        }

        private void EmailBTN_Click(object sender, RoutedEventArgs e)
        {
            SupportFlyout.IsOpen = true;
        }
    }
}
