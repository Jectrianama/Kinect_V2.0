using Microsoft.Kinect;
using Microsoft.Kinect.Wpf.Controls;
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

namespace KinectHandDetectionBug
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int conta = 0;
        public MainWindow()
        {
            InitializeComponent();
            

            KinectRegion.SetKinectRegion(this, kinectRegion);


            this.kinectRegion.KinectSensor = KinectSensor.GetDefault();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            ++conta;
            dispCont.Text = conta.ToString();
        }

        private void dispCont_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
