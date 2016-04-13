using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Management;
using System.Web;
using ZeroconfService;

namespace AirMagicWindows
{
    
    public partial class Form1 : Form
    {
        NetServiceBrowser nsBrowser = new NetServiceBrowser();
        List<NetService> devices = new List<NetService>();
        bool mBrowsing = false;
        string osbuild;
        string osversion;
        string atvAddress;
        Logger theLogger;
        public static string enteredText;
        public Form1()
        {
            InitializeComponent();
            Debug.WriteLine(String.Format("{0} Browser()", System.Threading.Thread.CurrentThread.ManagedThreadId));
            //this.KeyDown += new KeyEventHandler(onButtonKeyDown);
            //this.KeyUp += new KeyEventHandler(onButtonKeyUp);
           // this.KeyPress += new KeyPressEventHandler(onKeyPress);
            nsBrowser.InvokeableObject = this;
            nsBrowser.DidFindService += new NetServiceBrowser.ServiceFound(nsBrowser_DidFindService);
            nsBrowser.DidRemoveService += new NetServiceBrowser.ServiceRemoved(nsBrowser_DidRemoveService);
            nsBrowser.DidFindDomain += new NetServiceBrowser.DomainFound(nsBrowser_DidFindDomain);
            nsBrowser.SearchForRegistrationDomains();
            startBrowsing();
       
        }

   

        void nsBrowser_DidFindDomain(NetServiceBrowser browser, string domainName, bool moreComing)
        {
            Debug.WriteLine(browser, domainName);
        }

        void nsBrowser_DidRemoveService(NetServiceBrowser browser, NetService service, bool moreComing)
        {
            Debug.WriteLine(String.Format("{0}: nsBrowser_DidRemoveService: {1}", System.Threading.Thread.CurrentThread.ManagedThreadId, service.Name));
            
         
            service.Dispose();
        }

        ArrayList waitingAdd = new ArrayList();
        void nsBrowser_DidFindService(NetServiceBrowser browser, NetService service, bool moreComing)
        {
            Debug.WriteLine(String.Format("{0}: nsBrowser_DidFindService: {1}", System.Threading.Thread.CurrentThread.ManagedThreadId, service.Name));

            service.DidUpdateTXT += new NetService.ServiceTXTUpdated(ns_DidUpdateTXT);
            service.DidResolveService += new NetService.ServiceResolved(ns_DidResolveService);

            service.StartMonitoring();

            ListViewItem item = new ListViewItem(service.Name);
            item.Tag = service;

            if (!devices.Contains(service))
            {
                devices.Add(service);
            }
            if (moreComing)
            {
          //      devices.Add(service);
             //   waitingAdd.Add(item);
            }
            else
            {
                comboBox1.Invoke(new Action(() => comboBox1.Items.Clear()));
                foreach (NetService s in devices)
                {
                    if (!comboBox1.Items.Contains(s.Name))
                    {
                        comboBox1.Invoke(new Action(() => comboBox1.Items.Add(s.Name)));
                    }
            
                }
            
                 
            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    sendNavigationCommand("remoteCommand=left");
                    return true;
           
                case Keys.Right:

                    sendNavigationCommand("remoteCommand=right");
                    return true;

                case Keys.Down:

                    sendNavigationCommand("remoteCommand=down");
                    return true;

                case Keys.Up:

                    sendNavigationCommand("remoteCommand=up");
                    return true;

                case Keys.Return:

                    sendNavigationCommand("remoteCommand=select");
                    return true;

                case Keys.T:

                    showTextEntryForm();
                    return true;

                case Keys.Space:

                    sendNavigationCommand("remoteCommand=play");
                    return true;

                case Keys.Escape:

                    sendNavigationCommand("remoteCommand=menu");
                    return true;

            }
           
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void startBrowsing()
        {
            if (!mBrowsing)
            {
                try
                {
                    Debug.WriteLine(String.Format("Bonjour Version: {0}", NetService.DaemonVersion));
                }
                catch (Exception ex)
                {
                    String message = ex is DNSServiceException ? "Bonjour is not installed!" : ex.Message;
                    MessageBox.Show(message, "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }

            if (!mBrowsing)
            {
                string service = "_airmagic._tcp";
                try
                {
                    nsBrowser.SearchForService(service, "");
                    mBrowsing = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Critical Error");
                }
            }
            else
            {
                nsBrowser.Stop();

                if (resolvingService != null)
                {
                    resolvingService.Stop();
                    resolvingService = null;
                }
          
       
                mBrowsing = false;
            }

            if (mBrowsing)
            {
               
            }
            else
            {
              
            }
        }

   
        NetService resolvingService = null;
        private void Resolve(NetService service)
        {
            if (resolvingService != null)
            {
                resolvingService.Stop();
            }
            resolvingService = service;
            service.ResolveWithTimeout(5);
        }

        void ns_DidResolveService(NetService service)
        {
         //   Debug.WriteLine(String.Format("Did Resolve Service: {0}", service.Name), "**************");
            string host = comboBox1.SelectedItem.ToString();
            if (service.Name == host)
            {
                if (service.Addresses == null)
                {
                    return;
                }
                else
                {
                    atvAddress = service.Addresses[0].ToString();
                    ipAddressField.Text = atvAddress;
                }
            }
            else
            {
                return;
            }

        }

        void ns_DidUpdateTXT(NetService service)
        {
            Debug.WriteLine(String.Format("Did Update TXT Record: {0}", service.Name), "**************");

        }


        private bool sendNavigationCommand(string navCommand)
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://" + atvAddress  + "/" + navCommand))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        private void menuButton_Click(object sender, EventArgs e)
        {
            sendNavigationCommand("remoteCommand=menu");
        }

     
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string host = comboBox1.SelectedItem.ToString();
            foreach (NetService s in devices)
            {
                if (s.Name == host)
                {
                    //Debug.WriteLine(String.Format("{0} matches {1}", host, s.Name ));
                    Resolve(s);
                    updateFieldsForService(s);
                }
            }
        }

        private void updateFieldsForService(NetService service)
        {
       
            byte[] txt = service.TXTRecordData;
            IDictionary dict = NetService.DictionaryFromTXTRecordData(txt);

            if (dict == null)
            {
             //   txtRecordLabel.Text = String.Format("No TXT Record Available");
             
            }
            else
            {
          
                foreach (DictionaryEntry kvp in dict)
                {
                    String key = (String)kvp.Key;
                    byte[] value = (byte[])kvp.Value;

                    // If you were creating your own service, or browsing a known service,
                    // then you'd know what kind of data to expect as the value.
                    // But we don't here, so we assume UTF8 strings.

                    string valueStr;
                    try
                    {
                        valueStr = Encoding.UTF8.GetString(value);
                    }
                    catch
                    {
                        valueStr = "[Binary Data]";
                    }

                    if (key == "osbuild")
                    {
                      //  Debug.WriteLine(String.Format("found osbuild {0}", valueStr));
                        osbuild = valueStr;
                    }

                    if (key == "osversion")
                    {
                        //Debug.WriteLine(String.Format("found osversion {0}", valueStr));
                        osversion = valueStr;
                    }

                    if (key == "apiversion")
                    {
                        Debug.WriteLine(String.Format("found apiversion {0}", valueStr));
                        apiVersionField.Text = valueStr;
                    }
            
                }
                if (osversion != "" && osbuild != "")
                {
                    iosVersionField.Text = osversion + " (" + osbuild + ")";
                }

            }
        }

        private void showTextEntryForm()
        {
            DialogResult result = CYMessageBox.Show("Enter text to appear in current field on your AppleTV 4", "Text entry", CYMessageBox.CYButtons.OKCancel, CYMessageBox.CYIcon.Question);
            switch (result)
            {
                case DialogResult.OK:

                     
                    Debug.WriteLine(String.Format("entered text: {0}", Global.GlobalVar));
                    sendNavigationCommand("enterText=" + Uri.EscapeDataString(Global.GlobalVar) + "");
                    break;
            }

        }

        private void textButton_Click(object sender, EventArgs e)
        {
            showTextEntryForm();
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            sendNavigationCommand("remoteCommand=up");
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            sendNavigationCommand("remoteCommand=left");
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            sendNavigationCommand("remoteCommand=select");
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            sendNavigationCommand("remoteCommand=right");
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            sendNavigationCommand("remoteCommand=play");
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            sendNavigationCommand("remoteCommand=down");
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            sendNavigationCommand("remoteCommand=play");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = !comboBox1.Enabled;

        }


    }

    

    public class PeerData
    {
        public uint InterfaceIndex;
        public String Name;
        public String Type;
        public String Domain;
        public IPAddress Address;
        public int Port;
    }
}
