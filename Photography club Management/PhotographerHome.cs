using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Photography_club_Management
{
    public partial class PhotographerHome : UserControl
    {
        public PhotographerHome()
        {
            InitializeComponent();
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "jpg Files(*.jpg)|*.jpg|Png files(*.png)|*.png";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string imageLocation = openFileDialog.FileName;
                    picBoxUploadPhoto.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Upload Unsuccessful", "Error", MessageBoxButton.OKCancel);
            }
        }

        private void btnUploadPortfolio_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
                bool? response = openFileDialog.ShowDialog();

                if (response == true)
                {
                    string message = "Upload Succesfully";
                    System.Windows.MessageBox.Show(message);


                }
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Upload Unsuccessful", "Error", MessageBoxButton.OKCancel);
            }

        }
    }
}
