using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using WindowsPortableDevicesLib;
using WindowsPortableDevicesLib.Domain;

namespace WPDSampleApp
{
    public partial class FrmMain : Form
    {
        StandardWindowsPortableDeviceService service = new StandardWindowsPortableDeviceService();
        PortableDeviceFolder currentFolder = null;
        IList<PortableDeviceObject> currentContent = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            IList<WindowsPortableDevice> devices = service.Devices;

            devices.ToList().ForEach(device =>
            {
                device.Connect();
                var contents = device.GetContents();
                cmbDevices.Items.Add(contents.Files.First().Name + " " + device.FriendlyName);
                device.Disconnect();
            });

            if (devices.Count > 0)
            {
                cmbDevices.SelectedIndex = 0;
            }

            this.btnDiscover.Enabled = devices.Count > 0;
        }

        private void btnDiscover_Click(object sender, EventArgs e)
        {
            var device = service.Devices[this.cmbDevices.SelectedIndex];
            device.Connect();

            if (currentFolder == null)
            {
                var rootFolder = device.GetContents().Files;
                currentFolder = device.GetContents((PortableDeviceFolder)rootFolder.First());
                BindList();
            }

            device.Disconnect();
        }

        private void lstContents_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lnkCurrentSelection.Text = this.lstContents.SelectedValue.ToString();
        }

        private void lstContents_DoubleClick(object sender, EventArgs e)
        {
            var device = service.Devices[this.cmbDevices.SelectedIndex];
            device.Connect();

            if (this.currentContent[this.lstContents.SelectedIndex] is PortableDeviceFolder)
            {
                this.currentFolder = device.GetContents((PortableDeviceFolder)this.currentContent[this.lstContents.SelectedIndex]);
                this.BindList();
            }
            else if (this.currentContent[this.lstContents.SelectedIndex] is PortableDeviceFile)
            {
                var file = this.currentContent[this.lstContents.SelectedIndex] as PortableDeviceFile;
                Process.Start(file.Id);
            }
            
            device.Disconnect();
        }

        private void BindList()
        {
            this.currentContent             = currentFolder.Files;
            this.lstContents.DataSource     = this.currentContent;
            this.lstContents.DisplayMember  = "Name";
            this.lstContents.ValueMember    = "Id";
        }
    }
}
