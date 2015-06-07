using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CS4_DesktopFinal
{
    public class MainWindow : Window
    {

        #region Members

        private TestViewModel _vm;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            // Get and set VM
            _vm = new TestViewModel();
            this.DataContext = _vm;

            // Initialize UI
            InitializeComponent();
        }

        #endregion



    }
}
