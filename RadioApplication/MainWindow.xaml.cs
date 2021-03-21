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

namespace RadioApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ObservableCollection<Radio> radioChannels = new ObservableCollection<Radio>();
        private Radio radio = new Radio();
        public MainWindow()
        {
            

            InitializeComponent();

            radioChannels.Add(new Radio() { Channel = 1 });
            radioChannels.Add(new Radio() { Channel = 2 });
            radioChannels.Add(new Radio() { Channel = 3 });
            radioChannels.Add(new Radio() { Channel = 4 });

        }

        private void btnBBCOne_Click(object sender, RoutedEventArgs e)
        {
            if(ONButton.IsChecked == true)
            {
                radio.Channel = 1;
                radio.TurnOn();
                MessageBox.Show(radio.Play());
            }
            else
            {
                radio.TurnOff();
                MessageBox.Show(radio.Play());
            }
            
        }

        private void btnBBCTwo_Click(object sender, RoutedEventArgs e)
        {
            if (ONButton.IsChecked == true)
            {
                radio.Channel = 2;
                radio.TurnOn();
                
                MessageBox.Show(radio.Play());

            }
            else
            {
                radio.TurnOff();
                MessageBox.Show(radio.Play());
            }
        }

        private void btnBBCThree_Click(object sender, RoutedEventArgs e)
        {
            if (ONButton.IsChecked == true)
            {
                radio.Channel = 3;
                radio.TurnOn();
                MessageBox.Show(radio.Play());
            }
            else
            {
                radio.TurnOff();
                MessageBox.Show(radio.Play());
            }
        }

        private void btnBBCFour_Click(object sender, RoutedEventArgs e)
        {
            if (ONButton.IsChecked == true)
            {
                radio.Channel = 4;
                radio.TurnOn();
                MessageBox.Show(radio.Play());
            }
            else
            {
                radio.TurnOff();
                MessageBox.Show(radio.Play());
            }
        }

        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            
        }


    }
}
