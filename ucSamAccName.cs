using System;
using System.Windows.Forms;

namespace ResoNote_Tool_v2
{
    public partial class ucSamAccName : UserControl
    {
        public ucSamAccName()
        {
            InitializeComponent();
        }

        public String samValue
        {
            get { return tboxSamaccname.Text; }
            set { tboxSamaccname.Text = value; }
        }
    }
}
