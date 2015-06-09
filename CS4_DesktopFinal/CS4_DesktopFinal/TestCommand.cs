using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CS4_DesktopFinal
{
    
    public class TestCommand : ICommand

    {

        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        public virtual void Execute(object parameter)
        {
            // We shouldn't put message boxes in commands normally, but we will for this test.
            MessageBox.Show("Image Clicked!",
                "Double-Click Test", MessageBoxButton.OK);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }



    }
}
