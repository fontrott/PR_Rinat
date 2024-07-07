using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PR_19
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void CommunicationWithSupportClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://mail.google.com/mail/u/0/#inbox?compose=new",
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);
        }

        private void closeClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
