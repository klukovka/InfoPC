using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoPC
{
 
    public partial class MainForm : Form
    {
        Point left = new Point(15, 10);
        Point right = new Point(350, 10);
        const int GB = 1073741824;
        public MainForm()
        {
            InitializeComponent();           

            PS(left, right);
        }

        private string ToGB (object obj)
        {
            return Math.Round((decimal)(Convert.ToInt64(obj) / GB), 1).ToString() + " GB";
        }

        private void LongLabel(ref Point left, ref Point right, string text = "=============================================")
        {

            MainPanel.Controls.Add(GetLabel(text, ref left, FontStyle.Bold, 18, 750));
            right.Y += 40;
        }

        private void GPU(Point left, Point right)
        {
            MainPanel.Controls.Add(GetLabel("Graphic card (GPU)", ref left, FontStyle.Bold, 20));
            right.Y += 40;

            LongLabel(ref left, ref right);

            ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");

            foreach (ManagementObject obj in myVideoObject.Get())
            {
                MainPanel.Controls.Add(GetLabel("Name", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["Name"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("Status", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["Status"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("Caption", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["Caption"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("DeviceID", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["DeviceID"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("AdapterRAM", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(ToGB(obj["AdapterRAM"]), ref right));

                MainPanel.Controls.Add(GetLabel("AdapterDACType", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["AdapterDACType"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("Monochrome", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["Monochrome"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("InstalledDisplayDrivers", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["InstalledDisplayDrivers"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("DriverVersion", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["DriverVersion"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("VideoProcessor", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["VideoProcessor"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("VideoArchitecture", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["VideoArchitecture"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("VideoMemoryType", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["VideoMemoryType"].ToString(), ref right));

                LongLabel(ref left, ref right);


            }

        }


        private void HD(Point left, Point right)
        {
            MainPanel.Controls.Add(GetLabel("Hard Drives", ref left, FontStyle.Bold, 20));   
            right.Y += 40;

            LongLabel(ref left, ref right);         


            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives) 
            {
                MainPanel.Controls.Add(GetLabel("Drive", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(d.Name, ref right));

                MainPanel.Controls.Add(GetLabel("Drive type", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(d.DriveType.ToString(), ref right));

                if (d.IsReady)
                {

                    MainPanel.Controls.Add(GetLabel("Volume label", ref left, FontStyle.Bold));
                    MainPanel.Controls.Add(GetLabel(d.VolumeLabel, ref right));


                    MainPanel.Controls.Add(GetLabel("File system", ref left, FontStyle.Bold));
                    MainPanel.Controls.Add(GetLabel(d.DriveFormat, ref right));


                    MainPanel.Controls.Add(GetLabel("Available space to current user", ref left, FontStyle.Bold));
                    MainPanel.Controls.Add(GetLabel(ToGB(d.AvailableFreeSpace), ref right));


                    MainPanel.Controls.Add(GetLabel("Total available space", ref left, FontStyle.Bold));
                    MainPanel.Controls.Add(GetLabel(ToGB(d.TotalFreeSpace), ref right));


                    MainPanel.Controls.Add(GetLabel("Total size of drive", ref left, FontStyle.Bold));
                    MainPanel.Controls.Add(GetLabel(ToGB(d.TotalSize), ref right));


                    MainPanel.Controls.Add(GetLabel("Root directory", ref left, FontStyle.Bold));
                    MainPanel.Controls.Add(GetLabel(d.RootDirectory.ToString(), ref right));

                    LongLabel(ref left, ref right);

                }
            }



        }


        private void PS(Point left, Point right)
        {
            MainPanel.Controls.Add(GetLabel("Processor(s)", ref left, FontStyle.Bold, 20));
            right.Y += 40;

            LongLabel(ref left, ref right);

            ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");

            foreach (ManagementObject obj in myProcessorObject.Get())
            {
                MainPanel.Controls.Add(GetLabel("Name", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["Name"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("DeviceID", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["DeviceID"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("Manufacturer", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["Manufacturer"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("CurrentClockSpeed", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["CurrentClockSpeed"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("Caption", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["Caption"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("NumberOfCores", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["NumberOfCores"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("NumberOfEnabledCore", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["NumberOfEnabledCore"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("NumberOfLogicalProcessors", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["NumberOfLogicalProcessors"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("Architecture", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["Architecture"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("Family", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["Family"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("ProcessorType", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["ProcessorType"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("Characteristics", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["Characteristics"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("AddressWidth", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["AddressWidth"].ToString(), ref right));

                LongLabel(ref left, ref right);

            }
        }

        private void OS (Point left, Point right)
        {
            MainPanel.Controls.Add(GetLabel("Operative system", ref left, FontStyle.Bold, 20));
            right.Y += 40;

            LongLabel(ref left, ref right);

            ManagementObjectSearcher myOperativeSystemObject = new ManagementObjectSearcher("select * from Win32_OperatingSystem");

            foreach (ManagementObject obj in myOperativeSystemObject.Get())
            {
                MainPanel.Controls.Add(GetLabel("Caption", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["Caption"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("WindowsDirectory", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["WindowsDirectory"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("ProductType", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["ProductType"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("SerialNumber", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["SerialNumber"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("SystemDirectory", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["SystemDirectory"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("CountryCode", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["CountryCode"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("CurrentTimeZone", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["CurrentTimeZone"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("EncryptionLevel", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["EncryptionLevel"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("OSType", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["OSType"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("Version", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["Version"].ToString(), ref right));

                LongLabel(ref left, ref right);

            }

        }

        private void NI(Point left, Point right)
        {
            MainPanel.Controls.Add(GetLabel("Network Interface", ref left, FontStyle.Bold, 20));
            right.Y += 40;

            LongLabel(ref left, ref right);

            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();


            MainPanel.Controls.Add(GetLabel("Interface information for", ref left, FontStyle.Bold));
            MainPanel.Controls.Add(GetLabel($"{computerProperties.HostName} {computerProperties.DomainName}", ref right));

            if (nics == null || nics.Length < 1)
            {
                MainPanel.Controls.Add(GetLabel("No network interfaces found.", ref left, FontStyle.Bold));
                LongLabel(ref left, ref right);

                return;
            }

            MainPanel.Controls.Add(GetLabel("Number of interfaces", ref left, FontStyle.Bold));
            MainPanel.Controls.Add(GetLabel(nics.Length.ToString(), ref right));

            foreach (NetworkInterface adapter in nics)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();

                MainPanel.Controls.Add(GetLabel(adapter.Description, ref left, FontStyle.Bold, 20));
                right.Y += 40;

                MainPanel.Controls.Add(GetLabel(String.Empty.PadLeft(adapter.Description.Length, '-'), ref left, FontStyle.Bold, 20));
                right.Y += 40;

                MainPanel.Controls.Add(GetLabel("Interface type", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(adapter.NetworkInterfaceType.ToString(), ref right));


                MainPanel.Controls.Add(GetLabel("Physical Address", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(adapter.GetPhysicalAddress().ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("Operational status", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(adapter.OperationalStatus.ToString(), ref right));

                string versions = "";

                if (adapter.Supports(NetworkInterfaceComponent.IPv4))
                {
                    versions = "IPv4";
                }

                if (adapter.Supports(NetworkInterfaceComponent.IPv6))
                {
                    if (versions.Length > 0)
                    {
                        versions += " ";
                    }
                    versions += "IPv6";
                }


                MainPanel.Controls.Add(GetLabel("IP version", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(versions, ref right));

                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Loopback)
                {
                    LongLabel(ref left, ref right);
                    continue;
                }

                MainPanel.Controls.Add(GetLabel("DNS suffix", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(properties.DnsSuffix, ref right));

                MainPanel.Controls.Add(GetLabel("DNS enabled", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(properties.IsDnsEnabled.ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("Dynamically configured DNS", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(properties.IsDynamicDnsEnabled.ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("Receive Only", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(adapter.IsReceiveOnly.ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("Multicast", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(adapter.SupportsMulticast.ToString(), ref right));

                LongLabel(ref left, ref right);


            }


        }
        
        private void SC(Point left, Point right)
        {
            MainPanel.Controls.Add(GetLabel("Sound card (audio devices)", ref left, FontStyle.Bold, 20, 700));
            right.Y += 40;

            LongLabel(ref left, ref right);
            ManagementObjectSearcher myAudioObject = new ManagementObjectSearcher("select * from Win32_SoundDevice");

            foreach (ManagementObject obj in myAudioObject.Get())
            {
                MainPanel.Controls.Add(GetLabel("Name", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["Name"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("ProductName", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["ProductName"].ToString(), ref right));

                try
                {
                    MainPanel.Controls.Add(GetLabel("Availability", ref left, FontStyle.Bold));
                    MainPanel.Controls.Add(GetLabel(obj["Availability"].ToString(), ref right));
                }
                catch { }

                MainPanel.Controls.Add(GetLabel("DeviceID", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["DeviceID"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("PowerManagementSupported", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["PowerManagementSupported"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("Status", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["Status"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("StatusInfo", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["StatusInfo"].ToString(), ref right));

                LongLabel(ref left, ref right);

            }


        }

        private void PR(Point left, Point right)
        {
            MainPanel.Controls.Add(GetLabel("Printers", ref left, FontStyle.Bold, 20, 700));
            right.Y += 40;

            LongLabel(ref left, ref right);

            ManagementObjectSearcher myPrinterObject = new ManagementObjectSearcher("select * from Win32_Printer");

            foreach (ManagementObject obj in myPrinterObject.Get())
            {
                MainPanel.Controls.Add(GetLabel("Name", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["Name"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("Network", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["Network"].ToString(), ref right));

                try
                {
                    MainPanel.Controls.Add(GetLabel("Availability", ref left, FontStyle.Bold));
                    MainPanel.Controls.Add(GetLabel(obj["Availability"].ToString(), ref right));
                }
                catch { }

                MainPanel.Controls.Add(GetLabel("Default", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["Default"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("DeviceID", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["DeviceID"].ToString(), ref right));

                MainPanel.Controls.Add(GetLabel("Status", ref left, FontStyle.Bold));
                MainPanel.Controls.Add(GetLabel(obj["Status"].ToString(), ref right));

                LongLabel(ref left, ref right);

            }

        }

        private Label GetLabel(string item, ref Point point, FontStyle fontStyle = FontStyle.Regular, int size = 14, int length = 300)
        {
            Label type = new Label();
            type.Size = new Size(length, 35);
            type.Location = point;
            type.Font = new Font("Trebuchet MS", size, fontStyle);
            type.ForeColor = Color.DarkRed;
            type.Text = item;
            point.Y += 40;

            return type;
        }

        private void graphicCardGPUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            GPU(left, right);
        }

        private void hardDrivesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            HD(left, right);
        }

        private void processorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            PS(left, right);

        }

        private void operativeSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            OS(left, right);
        }

        private void networkInterfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            NI(left, right);
        }

        private void soundCardaudioDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            SC(left, right);
        }

        private void printersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            PR(left, right);
        }
    }
}
