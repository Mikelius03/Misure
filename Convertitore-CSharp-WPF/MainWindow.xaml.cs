using System.Windows;
using Misure;
using System;
using System.Drawing;

namespace ConvertitoreMisure
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Primo(object sender, RoutedEventArgs e)
        {

        }

        private void Loading(object sender, RoutedEventArgs e)
        {
            foreach (string scaleTerm in Temperature.NameUnitTemp)
            {
                ComboSelect.Items.Add(scaleTerm);
            }



        }

        private void AggiaornaLabel(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            string simbolo = Temperature.SimbolUnitTemp[ComboSelect.SelectedIndex];
            lblValueOutput.Content = txtbValueInput.Text.ToString()+" "+simbolo;
        }
    }
}
