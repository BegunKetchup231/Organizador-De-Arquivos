using System.ComponentModel;
using System.Diagnostics;

namespace Organizador_de_Arquivos
{
    public partial class Form1 : Form
    {
        private string sourceFolder = "";
        private string outputFolder = "";
        private bool isDarkMode = false;

        public Form1()
        {
            InitializeComponent();

            // Definir o tamanho fixo da janela (não redimensionável)
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Configurar o BackgroundWorker para relatar progresso
            backgroundWorker1.WorkerReportsProgress = true;

            // Associar o evento DoWork ao manipulador de eventos backgroundWorker1_DoWork
#pragma warning disable CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
#pragma warning restore CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).

            // Associar o evento btnModoEscuro_Click ao manipulador de eventos btnModoEscuro_Click
#pragma warning disable CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            btnModoEscuro.Click += BtnModoEscuro_Click;
#pragma warning restore CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).

            // Chame o método para aplicar o modo inicial
            ApplyAppMode(); // Aplica o modo carregado

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Label4_Click(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                sourceFolder = dialog.SelectedPath;
                PictureBox2.Visible = true; // Mostra o ícone de "verificado"
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                outputFolder = dialog.SelectedPath;
                PictureBox3.Visible = true; // Mostra o ícone de "verificado"
            }
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            string url = "https://keepo.io/begunketchup231/";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o link: " + ex.Message);
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            var url = "https://streamelements.com/wellden840/tip";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o link: " + ex.Message);
            }
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sourceFolder))
            {
                MessageBox.Show("Selecione a pasta de entrada (Botão 1) primeiro!");
                return;
            }

            if (string.IsNullOrEmpty(outputFolder))
            {
                MessageBox.Show("Selecione a pasta de saída (Botão 2) antes de organizar.");
                return;
            }

            OrganizeFiles(sourceFolder, outputFolder);

            // Reset a ProgressBar após a organização
            progressBar1.Value = 0;
            PictureBox2.Visible = false;
            PictureBox3.Visible = false; // Esconde o ícone de "verificado"
            MessageBox.Show("Organização concluída com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset das pastas de entrada e saída
            sourceFolder = "";
            outputFolder = "";
        }

        private void OrganizeFiles(string sourceFolder, string outputFolder)
        {
            var allFiles = Directory.GetFiles(sourceFolder, "*", SearchOption.TopDirectoryOnly)
                        .Where(file => !new FileInfo(file).Attributes.HasFlag(FileAttributes.Hidden))
                        .ToArray();

            int totalFiles = allFiles.Length;
            int processedFiles = 0;

            var arquivosFolder = Path.Combine(outputFolder, "Arquivos");
            var destinationSubfolder = Path.Combine(arquivosFolder, "Arquivos.pasta");
            Directory.CreateDirectory(destinationSubfolder);

            var folders = Directory.GetDirectories(sourceFolder)
                                  .Where(folder => !new DirectoryInfo(folder).Attributes.HasFlag(FileAttributes.Hidden));

            foreach (var folder in folders)
            {
                var folderName = new DirectoryInfo(folder).Name;

                if (folderName.Equals("Arquivos"))
                    continue;

                var destinationFolder = Path.Combine(destinationSubfolder, folderName);
                Directory.Move(folder, destinationFolder);
            }

            foreach (var file in allFiles)
            {
                var extension = Path.GetExtension(file);

                if (string.IsNullOrEmpty(extension))
                {
                    continue;
                }

                var destinationFolder = Path.Combine(arquivosFolder, "Arquivos" + extension);
                Directory.CreateDirectory(destinationFolder);

                var fileName = Path.GetFileName(file);
                var destinationFile = Path.Combine(destinationFolder, fileName);

                if (File.Exists(destinationFile))
                {
                    int suffix = 1;
                    string originalFileName = Path.GetFileNameWithoutExtension(file);
                    string newFileName = $"{originalFileName}_{suffix}{extension}";

                    while (File.Exists(Path.Combine(destinationFolder, newFileName)))
                    {
                        suffix++;
                        newFileName = $"{originalFileName}_{suffix}{extension}";
                    }

                    destinationFile = Path.Combine(destinationFolder, newFileName);
                }

                File.Move(file, destinationFile);

                processedFiles++;
                int progressPercentage = processedFiles * 100 / totalFiles;
                backgroundWorker1.ReportProgress(progressPercentage);
            }
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            OrganizeFiles(sourceFolder, outputFolder);
        }
        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }
        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        private void BtnModoEscuro_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode; // Inverte o estado do modo

            // Atualiza a visibilidade das PictureBoxes
            pictureBoxClaro.Visible = !isDarkMode;
            pictureBoxEscuro.Visible = isDarkMode;

            // Atualiza o texto do botão
            btnModoEscuro.Text = isDarkMode ? "Modo Claro" : "Modo Escuro";

            // Salva o novo modo no arquivo config.txt
            string configPath = "config.txt";
            File.WriteAllText(configPath, isDarkMode ? "modo_escuro" : "modo_claro");
        }
        private void ApplyAppMode()
        {
            pictureBoxClaro.Visible = !isDarkMode;
            pictureBoxEscuro.Visible = isDarkMode;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string configPath = "config.txt";
            if (File.Exists(configPath))
            {
                string configContent = File.ReadAllText(configPath);
                isDarkMode = configContent.Trim() == "modo_escuro";
            }

            ApplyAppMode(); // Aplica o modo carregado

            // Atualiza o texto do botão de acordo com o modo
            btnModoEscuro.Text = isDarkMode ? "Modo Claro" : "Modo Escuro";
        }
        private void BtnModoEscuro_Click_1(object sender, EventArgs e)
        {
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
        }
        private void Label10_Click(object sender, EventArgs e)
        {
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/BegunKetchup231";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o link: " + ex.Message);
            }
        }
        private void PictureBox4_Click_1(object sender, EventArgs e)
        {
        }
        private void PictureBoxClaro_Click(object sender, EventArgs e)
        {

        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Button9_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/BegunKetchup231";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o link: " + ex.Message);
            }
        }
        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBoxEscuro_Click(object sender, EventArgs e)
        {

        }
    }
}