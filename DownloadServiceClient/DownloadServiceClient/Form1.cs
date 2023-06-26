using System;
using System.Windows.Forms;

namespace DownloadServiceClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDownloadFile_Click(object sender, EventArgs e)
        {
            DownloadService.DownladServiceClient client = new DownloadService.DownladServiceClient();

            DownloadService.File file =  client.DownloadDocument();

            System.IO.File.WriteAllBytes(@"D:\Data\Downloaded\" + file.Name, file.Content);

            MessageBox.Show(file.Name + " is downloaded");


        }
    }
}
