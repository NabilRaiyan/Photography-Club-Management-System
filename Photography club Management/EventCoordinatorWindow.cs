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
    public partial class EventCoordinatorWindow : Form
    {
        public EventCoordinatorWindow()
        {
            InitializeComponent();
            pnlActiveMenu.Height = btnHome.Height;
            pnlActiveMenu.Top = btnHome.Top;
            eventCoordinatorHome.BringToFront();
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            notificationsWindow.BringToFront();
            notificationsWindow.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlActiveMenu.Height = btnHome.Height;
            pnlActiveMenu.Top = btnHome.Top;
            eventCoordinatorHome.BringToFront();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            pnlActiveMenu.Height = btnEvents.Height;
            pnlActiveMenu.Top = btnEvents.Top;
            eventsWindows.BringToFront();
        }

        private void btnEventsBudget_Click(object sender, EventArgs e)
        {
            pnlActiveMenu.Height = btnEventsBudget.Height;
            pnlActiveMenu.Top = btnEventsBudget.Top;
            eventsBudget.BringToFront();
        }

        private void btnTrackAttendance_Click(object sender, EventArgs e)
        {
            pnlActiveMenu.Height = btnTrackAttendance.Height;
            pnlActiveMenu.Top = btnTrackAttendance.Top;
            attendance.BringToFront();
        }
    }
}
