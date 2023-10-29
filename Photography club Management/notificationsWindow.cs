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
    public partial class notificationsWindow : UserControl
    {
        public notificationsWindow()
        {
            InitializeComponent();
        }

        private void btnCloseNotification_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void notificationsWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
