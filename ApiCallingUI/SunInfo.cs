using ApiCallingLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiCallingUI
{
    public partial class SunInfo : Form
    {
        public SunInfo()
        {
            InitializeComponent();
        }

        private async void btnLoadSunInfo_Click(object sender, EventArgs e)
        {
            var sunInfo = await SunProcessor.LoadSunInformation();

            lblSunrise.Text = $"Sunrise is at { sunInfo.Sunrise.ToLocalTime().ToShortTimeString() }";
            lblSunset.Text = $"Sunset is at { sunInfo.Sunset.ToLocalTime().ToShortTimeString() }";
        }
    }
}
