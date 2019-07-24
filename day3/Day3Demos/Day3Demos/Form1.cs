using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day3Demos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ParseAge();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                // runs even if there was no exception
            }
        }

        /// <summary>
        /// This method parses the age
        /// </summary>
        private void ParseAge()
        {
            int age = int.Parse(txtAge.Text);

            if (age < 0)
            {
                throw new FormatException("Age can not be negative");
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            //FileStream stream = null;
            //try
            //{
            //    // unmanaged resources
            //    stream = File.Open("data.txt", FileMode.OpenOrCreate);

            //    StreamReader reader = new StreamReader(stream);

            //    string fileContent = reader.ReadToEnd();

            //    txtFile.Text = fileContent;

            //    // boooom
            //}
            //finally
            //{
            //    stream?.Close();
            //}

            // Dispose pattern
            using (FileStream stream = File.Open("data.txt", FileMode.OpenOrCreate))
            {
                StreamReader reader = new StreamReader(stream);

                string fileContent = reader.ReadToEnd();

                txtFile.Text = fileContent;

                // boooom
            }
        }

        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            using (FileStream stream = File.Open("data.txt", FileMode.Truncate))
            {
                StreamWriter writer = new StreamWriter(stream, Encoding.UTF8);

                writer.Write(txtFileSaveContent.Text);
                writer.Flush();
            }
        }

        private void BtnStartTcpServer_Click(object sender, EventArgs e)
        {
            tcpListenerBackgroundWorker.RunWorkerAsync();
        }

        private delegate void ShowReveicedMessageDelegate(string text);

        private void TcpListenerBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Any, 8080);

            tcpListener.Start();

            TcpClient tcpClient = tcpListener.AcceptTcpClient();

            using (NetworkStream stream = tcpClient.GetStream())
            {
                StreamReader reader = new StreamReader(stream);

                string message = reader.ReadToEnd();

                Invoke(new ShowReveicedMessageDelegate(ShowReceivedMessage), message);
            }
        }

        void ShowReceivedMessage(string message)
        {
            txtTcpReceived.Text = message;
        }

        private void BtnBeginAcceptTcpServer_Click(object sender, EventArgs e)
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Any, 8080);

            tcpListener.Start();

            tcpListener.BeginAcceptTcpClient(TcpClientConnected, tcpListener);
        }

        void TcpClientConnected(IAsyncResult asyncResult)
        {
            TcpListener tcpListener = (TcpListener)asyncResult.AsyncState;

            TcpClient tcpClient = tcpListener.EndAcceptTcpClient(asyncResult);

            using (NetworkStream stream = tcpClient.GetStream())
            {
                StreamReader reader = new StreamReader(stream);

                string message = reader.ReadToEnd();

                Invoke(new ShowReveicedMessageDelegate(ShowReceivedMessage), message);
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient("127.0.0.1", 8081);

            using (Stream stream = client.GetStream())
            {
                var writer = new StreamWriter(stream);
                writer.Write(txtMessageToSend.Text);
                writer.Flush();
            }
        }
    }
}
