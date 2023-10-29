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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            pnlActiveMenu.Height = btnHome.Height;
            pnlActiveMenu.Top = btnHome.Top;
            homeWindow.BringToFront();
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlActiveMenu.Height = btnHome.Height;
            pnlActiveMenu.Top = btnHome.Top;
            homeWindow.BringToFront();
        }


        private void btnMembers_Click(object sender, EventArgs e)
        {
            pnlActiveMenu.Height = btnMembers.Height;
            pnlActiveMenu.Top = btnMembers.Top;
            membersWindow.BringToFront();
        }

       
        private void btnEvents_Click(object sender, EventArgs e)
        {
            pnlActiveMenu.Height = btnEvents.Height;
            pnlActiveMenu.Top = btnEvents.Top;
            eventsWindows.BringToFront();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

            pnlActiveMenu.Height = btnCustomer.Height;
            pnlActiveMenu.Top = btnCustomer.Top;
            customersWindow.BringToFront();
        }

        private void btnResources_Click(object sender, EventArgs e)
        {
            pnlActiveMenu.Height = btnResources.Height;
            pnlActiveMenu.Top = btnResources.Top;
            resourcesWindow.BringToFront();
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            notificationsWindow.BringToFront();
            notificationsWindow.Show();
        }

        
    }
}
