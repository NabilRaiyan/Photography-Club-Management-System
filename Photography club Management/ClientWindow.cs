using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photography_club_Management
{
    public partial class ClientWindow : Form
    {
        public ClientWindow()
        {
            InitializeComponent();
            pnlActiveMenu.Height = btnHome.Height;
            pnlActiveMenu.Top = btnHome.Top;
            clientHome.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlActiveMenu.Height = btnHome.Height;
            pnlActiveMenu.Top = btnHome.Top;
            clientHome.BringToFront();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            pnlActiveMenu.Height = btnEvents.Height;
            pnlActiveMenu.Top = btnEvents.Top;
            photographerEventsShow.BringToFront();
        }
    }
}
