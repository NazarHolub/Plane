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

namespace planeTask
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

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.W && Canvas.GetTop(gridPlane) > 5)
                Canvas.SetTop(gridPlane, Canvas.GetTop(gridPlane) - 5);

            else if (e.Key == Key.S && Canvas.GetTop(gridPlane) < 310)
                Canvas.SetTop(gridPlane, Canvas.GetTop(gridPlane) + 5);

            else if (e.Key == Key.A && Canvas.GetLeft(gridPlane) > 5)
                Canvas.SetLeft(gridPlane, Canvas.GetLeft(gridPlane) - 5);

            else if (e.Key == Key.D && Canvas.GetLeft(gridPlane) < 650)
                Canvas.SetLeft(gridPlane, Canvas.GetLeft(gridPlane) + 5);
        }
    }
}
