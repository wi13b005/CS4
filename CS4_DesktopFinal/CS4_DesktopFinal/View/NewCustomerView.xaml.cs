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
using System.Windows.Shapes;

namespace CS4_DesktopFinal
{
    /// <summary>
    /// Interaction logic for NewCustomer.xaml
    /// </summary>
    public partial class NewCustomer : Window
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

private void InitializeComponent()
{
 	throw new NotImplementedException();
}

     
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void CreatePatient_Click(object sender, RoutedEventArgs e)
        {
            this.Hide(); //hide the EHR page
            MainWindow NewWindow = new MainWindow();
            NewWindow.Show();
        }

        void SaveCanvasCommandExecute(object parameter)
        {
            UIElement toSave = (UIElement)parameter;
            //.. You'd probably use RenderTargetBitmap here to save toSave.
        }
    }
}





