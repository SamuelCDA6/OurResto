using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurResto
{
    internal partial class ProgressDialog : Form
    {
        public ProgressBar Progressbar { get; }

        public ProgressDialog()
        {
            InitializeComponent();
        }

        public void RunAsync(Action action)
        {
            Task.Run(action);
        }
    }
}
