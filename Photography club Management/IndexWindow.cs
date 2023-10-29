using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;



namespace Photography_club_Management
{
    public partial class IndexWindow : Form
    {
        public IndexWindow()
        {
            InitializeComponent();
        }

        private void IndexWindow_Load(object sender, EventArgs e)
        {
            btnLogin.Parent = picBoxIndexHeading;
            btnLogin.BackColor = Color.GhostWhite;
            

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
