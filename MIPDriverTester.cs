using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoOS.Platform.Data;
using VideoOS.Platform.Metadata;


namespace MIPDriverTester
{
    public partial class MIPDriverTester : Form
    {
        public MIPDriverTester()
        {
            InitializeComponent();
            Task t = new Task(() => UpdateStatus());
            t.Start();

        }



        private void startButton_Click(object sender, EventArgs e)
        {
            String userName = userName_TextBox.Text;
            String password = password_TextBox.Text;
            String port = port_TextBox.Text;
            String MAC = MACAddress_TextBox.Text;
            OpenHTTPService(userName, password, port, MAC);



        }

        private void UpdateStatus()
        {
            while (true)
            {

                if (_metadataProviderChannel != null)
                {
                    SetText(_metadataProviderChannel.ActiveSessions.ToString());
                    SetText2(_metadataProviderChannel.IsConnected.ToString());
                    SetText3((_metadataProviderService != null).ToString());
                } 
                else { 
                SetText("0");
                SetText2("False");
                SetText3("False");
                }
                Thread.Sleep(2000);
            }
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if (this.activeSessions_TextBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.activeSessions_TextBox.Text = text;
            }
        }

        delegate void SetTextCallback2(string text);

        private void SetText2(string text)
        {
            if (this.IsConnected_TextBox.InvokeRequired)
            {
                SetTextCallback2 d = new SetTextCallback2(SetText2);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.IsConnected_TextBox.Text = text;
            }
        }

        delegate void SetTextCallback3(string text);

        private void SetText3(string text)
        {
            if (this.started_TextBox.InvokeRequired)
            {
                SetTextCallback3 d = new SetTextCallback3(SetText3);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.started_TextBox.Text = text;
            }
        }







        private MediaProviderService _metadataProviderService;
        private MetadataProviderChannel _metadataProviderChannel;
        private readonly MetadataSerializer _metadataSerializer = new MetadataSerializer();


        internal void OpenHTTPService(string userName, string password, string port, string mac)
        {
            outout_TextBox.Text = "Ininitalizing HTTP Metadata Channel" + System.Environment.NewLine;
            // Open the HTTP Service
            if (_metadataProviderService == null)
            {
                var hardwareDefinition = new HardwareDefinition(
                    PhysicalAddress.Parse(mac),
                    "MetadataProvider")
                {
                    Firmware = "v10",
                    MetadataDevices = { MetadataDeviceDefintion.CreateBoundingBoxDevice() }
                };

                _metadataProviderService = new MediaProviderService();
                int _port = int.Parse(port);
                _metadataProviderService.Init(_port, password, hardwareDefinition); ;
                outout_TextBox.Text += "Listening on port: " + port + System.Environment.NewLine;

            }
            // Create a provider to handle channel 1
            _metadataProviderChannel = _metadataProviderService.CreateMetadataProvider(1);
            outout_TextBox.Text += "Channel created: " + _metadataProviderChannel.Channel;


        }

        internal string SendMetadataBox()
        {
            try
            {
                OnvifObject blob = new OnvifObject(1)
                {
                    Appearance = new VideoOS.Platform.Metadata.Appearance
                    {
                        Description = new DisplayText
                        {
                            Value = "This is a text sent to the metadata channel"
                        },
                    }
                };

                MetadataStream metadata = new MetadataStream
                {
                    VideoAnalyticsItems =
                {
                    new VideoAnalytics
                    {
                        Frames =
                        {
                            new Frame(DateTime.UtcNow)
                            {
                                Objects =
                                {
                                         blob
                                }
                            }
                        }
                    }
                }
                };

                var result = _metadataProviderChannel.QueueMetadata(metadata, DateTime.UtcNow);
                if (result == false)
                    return (string.Format("{0}: Failed to write to channel", DateTime.UtcNow));
                else
                {
                    return _metadataSerializer.WriteMetadataXml(metadata);
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        private void sendMetadataTest_button_Click(object sender, EventArgs e)
        {
            outout_TextBox.Text = SendMetadataBox();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (_metadataProviderService != null)
            {
                _metadataProviderService.RemoveMetadataProvider(_metadataProviderChannel);
                _metadataProviderService.Close();
                _metadataProviderService = null;
            }
        }


    }

}
