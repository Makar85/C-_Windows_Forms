using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSCourse.WFAppLab1._5
{
    public partial class EllipseForm : Form
    {
        public EllipseForm()
        {
            InitializeComponent();
        }

        private void EllipseForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath =
             new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(new Rectangle(new Point(0, 0), this.ClientSize));
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void CloseMe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
