using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PandySocial : Form
    {
        public PandySocial()
        {
            InitializeComponent();
        }

        public void readData(List<int> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                socialChart.Series["Social"].Points.AddXY(i, data.ElementAt(i));
            }
        }

    }
}
