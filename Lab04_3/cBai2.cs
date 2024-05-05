using System.IO;
using System.Net;
using System.Windows.Forms.Design;

namespace Lab04
{
    public partial class cBai2 : Form
    {
        public cBai2()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();
            openFileDialog.ShowDialog();
            string path = openFileDialog.SelectedPath;
            textBox2.Text = path;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                richTextBox1.Text = DownloadFileHtml(textBox1.Text, textBox2.Text);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Url không hợp lệ hoặc website không thê kết nối được\n Vui lòng kiểm tra lại url", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string NameFile(string path)
        {
            string[] arr = path.Split('/');
            return arr[arr.Length - 1];
        }
        private string PathFolder(string nameFile, string path)
        {
            string[] arr = path.Split('/');
            //Nếu có phần tử có giá trị trùng với nameFile thì loại bỏ phần tử đó
            if (arr[arr.Length - 1] == nameFile)
            {
                Array.Resize(ref arr, arr.Length - 1);
            }
            return string.Join("/", arr) + "/" + path;
        }
        private string DownloadFileHtml(string url, string pathFile)
        {
            string nameFile = NameFile(pathFile);
            string pathFolder = PathFolder(nameFile, pathFile);
            // Create a new WebClient instance.
            WebClient client = new WebClient();
            // Download the file and return the content.
            Stream stream = client.OpenRead(url);
            // Download the Web resource and save it into the current filesystem folder.
            client.DownloadFile(url, nameFile);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            File.ReadAllText(nameFile);
            return File.ReadAllText(NameFile(pathFile));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            richTextBox1.Text = "";
        }
    }
}
