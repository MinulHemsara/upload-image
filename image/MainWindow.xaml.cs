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
using Microsoft.Win32; // to get open file dialogue control

namespace image
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

        private void btn_upload_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                if (open.ShowDialog() == true)
                {
                    Uri file = new Uri(open.FileName);
                    img_profile.Source = new BitmapImage(file);
                }
            }
            catch (NotSupportedException)
            {
                MessageBox.Show("Not supported image please check again","ERROR",MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }
    }
}
