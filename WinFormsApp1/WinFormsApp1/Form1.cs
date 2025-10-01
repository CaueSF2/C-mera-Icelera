namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo start = new System.Diagnostics.ProcessStartInfo();
            start.FileName = @"C:\Users\caues\AppData\Local\Programs\Python\Python313\python.exe";  // ajuste se necessário
            start.Arguments = @"C:\Users\caues\OneDrive\Documentos\Icelera\camera\camera\camera.py"; // ajuste para o caminho do seu script
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;
            start.CreateNoWindow = true;

            using (System.Diagnostics.Process process = System.Diagnostics.Process.Start(start))
            {
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                if (!string.IsNullOrWhiteSpace(output))
                    MessageBox.Show("Saída:\n" + output);

                if (!string.IsNullOrWhiteSpace(error))
                    MessageBox.Show("Erro:\n" + error);
            }
        }



    }
}
