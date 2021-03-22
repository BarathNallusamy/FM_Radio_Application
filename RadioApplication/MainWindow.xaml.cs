using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Threading;

namespace RadioApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        private ObservableCollection<MediaElement> channels = new ObservableCollection<MediaElement>();

        private Radio radio = new Radio();

        public MainWindow()
        {

            InitializeComponent();

            channels.Add(bbcOne);
            channels.Add(bbcTwo);
            channels.Add(bbcThree);
            channels.Add(bbcFour);

        }

        private void btnBBCOne_Click(object sender, RoutedEventArgs e)
        {
            PowerButtonChecked(1, txtResult.Text);
        }

        private void btnBBCTwo_Click(object sender, RoutedEventArgs e)
        {
            PowerButtonChecked(2, txtResult.Text);
        }

        private void btnBBCThree_Click(object sender, RoutedEventArgs e)
        {
            PowerButtonChecked(3, txtResult.Text);
        }

        private void btnBBCFour_Click(object sender, RoutedEventArgs e)
        {
            PowerButtonChecked(4, txtResult.Text);
        }

        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.IsChecked == true)
            {
                foreach (var item in channels)
                {
                    item.Stop();
                }
            }
            
            
            
        }

        public void PowerButtonChecked(int channelNum, string status)
        {
            if (ONButton.IsChecked == true)
            {
                foreach (var item in channels)
                {
                    item.Pause();
                }
                radio.Channel = channelNum;
                radio.TurnOn();
                txtResult.Text = radio.Play();
                channels.ElementAt(channelNum - 1).Play();
            }
            else
            {
                radio.TurnOff();
                txtResult.Text = radio.Play();
            }
        }

        private void Grid_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            
             bbcOne.Volume += (e.Delta > 0) ? 0.1 : -0.1;
            
            
        }


    }
}
