using Fleck;
using System.Net.WebSockets;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace WebSocketServerTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private WebSocketServer? _server = null;
        private IDictionary<string, IWebSocketConnection> _sockets = new Dictionary<string, IWebSocketConnection>();
        private const int AutoClearCount = 1000;

        private void Form1_Load(object sender, EventArgs e)
        {
            cbx_protocol.SelectedIndex = 0;
            tbx_ip.Text = "127.0.0.1";
            tbx_port.Text = "60000";
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbx_protocol.SelectedItem == null)
                {
                    MessageBox.Show("Protocol is empty!");
                    return;
                }

                if (tbx_ip == null || tbx_ip.Text == "" || tbx_port == null || tbx_port.Text == "")
                {
                    MessageBox.Show("Ip is empty!");
                    return;
                }

                System.Net.IPAddress? ipAddress = null;
                if (!System.Net.IPAddress.TryParse(tbx_ip.Text, out ipAddress))
                {
                    MessageBox.Show("Ip string is not allowed!");
                    return;
                }

                if (tbx_port == null || tbx_port.Text == "")
                {
                    MessageBox.Show("Port is empty!");
                    return;
                }

                uint port = 0;
                if (!UInt32.TryParse(tbx_port.Text, out port))
                {
                    MessageBox.Show("Port string is not allowed!");
                    return;
                }

                string serverUrl = $"{cbx_protocol.SelectedItem.ToString()}://{tbx_ip.Text}:{tbx_port.Text}";
                _server = new WebSocketServer(serverUrl);

                _server.Start(socket =>
                {
                    socket.OnOpen = () =>
                    {
                        lBox_clientMsg.BeginInvoke(new Action(() =>
                        {
                            lBox_clientMsg.Items.Add(GetListBoxMsg("WebSocket Opened"));
                            string clientUrl = $"{socket.ConnectionInfo.ClientIpAddress}:{socket.ConnectionInfo.ClientPort}";
                            lBox_clientMsg.Items.Add(GetListBoxMsg(clientUrl));
                            _sockets.Add(clientUrl, socket);
                        }));

                        this.BeginInvoke(new Action(() =>
                        {
                            IsEnableSetControl(false);
                        }));
                    };

                    socket.OnClose = () =>
                    {
                        lBox_clientMsg.BeginInvoke(new Action(() =>
                        {
                            lBox_clientMsg.Items.Add(GetListBoxMsg("WebSocket Closed"));
                        }));

                        this.BeginInvoke(new Action(() =>
                        {
                            IsEnableSetControl(true);
                        }));
                    };

                    socket.OnMessage = message =>
                    {
                        lBox_clientMsg.BeginInvoke(new Action(() =>
                        {
                            if (lBox_clientMsg.Items.Count > AutoClearCount)
                                lBox_clientMsg.Items.Clear();

                            lBox_clientMsg.Items.Add(GetListBoxMsg($"Received message from client: {message}"));
                            lBox_clientMsg.TopIndex = lBox_clientMsg.Items.Count - 1;
                            socket.Send($"Echo: {message}");
                        }));
                    };
                });

                lBox_clientMsg.Items.Add(GetListBoxMsg($"WebSocket server started at {serverUrl}"));
            }
            catch(Exception ex)
            {
                MessageBox.Show("btn_start_Click error = " + ex.ToString());
            }
        }

        private string GetListBoxMsg(string msg)
        {
            return $"[{DateTime.Now.ToString()}]  {msg}";
        }
        
        private void IsEnableSetControl(bool isEnable)
        {
            cbx_protocol.Enabled = isEnable;
            tbx_ip.Enabled = isEnable;
            tbx_port.Enabled = isEnable;
            btn_default.Enabled = isEnable;
            btn_start.Enabled = isEnable;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (_server != null)
                {
                    foreach (var item in _sockets.Values)
                    {
                        if (item != null)
                            item.Close();
                    }
                }

                IsEnableSetControl(true);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("btn_stop_Click error = " + ex.ToString());
            }
        }

        private void btn_default_Click(object sender, EventArgs e)
        {
            cbx_protocol.SelectedIndex = 0;
            tbx_ip.Text = "127.0.0.1";
            tbx_port.Text = "60000";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lBox_clientMsg.Items.Clear();
        }        
    }
}
