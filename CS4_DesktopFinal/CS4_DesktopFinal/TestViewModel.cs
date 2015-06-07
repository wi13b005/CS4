using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4_DesktopFinal
{
    
    public class TestViewModel
    {

        #region Properties

        /// <summary>
        /// Gets or sets my command.
        /// </summary>
        /// <value>
        /// My command.
        /// </value>
        public TestCommand MyCommand { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TestViewModel"/> class.
        /// </summary>
        public TestViewModel()
        {
            MyCommand = new TestCommand();
        }
 




    }
}
