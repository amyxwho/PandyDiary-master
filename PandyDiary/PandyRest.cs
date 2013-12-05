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
    public partial class PandyRest : Form
    {
        public PandyRest()
        {
            InitializeComponent();
        }

        public void readData(List<int> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                restChart.Series["Series1"].Points.AddXY(i, data.ElementAt(i));
            }
        }

    }
}
