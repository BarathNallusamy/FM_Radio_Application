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
        

        private Queue<MediaElement> channels = new Queue<MediaElement>();

        private Radio radio = new Radio();

        public MainWindow()
        {

            InitializeComponent();

            channels.Enqueue(bbcOne);
            channels.Enqueue(bbcTwo);
            channels.Enqueue(bbcThree);
            channels.Enqueue(bbcFour);
        }

        private void btnBBCOne_Click(object sender, RoutedEventArgs e)
        {
            PowerButtonChecked(1, txtResult.Text);
            channels.Peek().Stop();
            bbcOne.Play();

        }

        private void btnBBCTwo_Click(object sender, RoutedEventArgs e)
        {
            PowerButtonChecked(2, txtResult.Text);
            channels.Peek().Stop();
            bbcTwo.Play();
        }

        private void btnBBCThree_Click(object sender, RoutedEventArgs e)
        {
            PowerButtonChecked(3, txtResult.Text);
            channels.Peek().Stop();
            bbcThree.Play();
        }

        private void btnBBCFour_Click(object sender, RoutedEventArgs e)
        {
            PowerButtonChecked(4, txtResult.Text);
            channels.Peek().Stop();
            bbcFour.Play();
        }

        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            
        }

        public void PowerButtonChecked(int channelNum, string status)
        {
            if (ONButton.IsChecked == true)
            {
                radio.Channel = channelNum;
                radio.TurnOn();
                txtResult.Text = radio.Play();
            }
            else
            {
                radio.TurnOff();
                txtResult.Text = radio.Play();
            }
        }



    }
}
