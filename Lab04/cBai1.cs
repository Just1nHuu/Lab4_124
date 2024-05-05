using System.Net;

namespace Lab04
{
    public partial class cBai1 : Form
    {
        public cBai1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ContextWebHtml(textBox1.Text);
        }

        private string ContextWebHtml(string url)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(url);
            // Get the response.
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Close the response.
            response.Close();
            return responseFromServer;
        }
    }
}
