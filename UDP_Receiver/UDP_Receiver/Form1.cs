using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace UDP_Receiver
{
    public partial class Form1 : Form
    {
        // UDP RECEIVER SERVER INITIALIZING
        UdpClient receiver = new UdpClient(12345); // Port Number
        IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 12345);

        // PARAMETERS CLASS INITIALIZING
        Parameters parameters = new Parameters();

        public Form1()
        {
            InitializeComponent();
        }

        private void beginToReceive_Click(object sender, EventArgs e)
        {

            try
            {
                receiveOverUdp();
            }catch (Exception ex)
            {
                richTextBox1.Text = ex.Message.ToString();
            }
           


        }

        void receiveOverUdp()
        {
            // UDP RECEIVING
            byte[] jsonedReceivedByteData = receiver.Receive(ref endPoint);
            string jsonedString = Encoding.ASCII.GetString(jsonedReceivedByteData);

            // DESERIALIZING JSON DATA
            Parameters? parameters = JsonSerializer.Deserialize<Parameters>(jsonedString);

            richTextBox1.Text = "Received data: " + jsonedString;

        }
    }
}