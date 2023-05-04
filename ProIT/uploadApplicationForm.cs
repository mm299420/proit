using System;
using System.Windows.Forms;
using System.Text;
using System.Drawing;
using System.IO;
using Tesseract;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;
using PdfPigPage = UglyToad.PdfPig.Content.Page;

namespace ProIT
{
    public partial class uploadApplicationForm : Form
    {
        public string path { get; set; }
        public uploadApplicationForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Image files ( *.pdf, *.jpg, *.jpeg, *.png, *.bmp)|*.pdf;*.jpg;*.jpeg;*.png;*.bmp;"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in openFileDialog.FileNames)
                {
                    listBoxFiles.Items.Add(filePath);
                }
            }
        }
        private string ProcessImage(string imagePath)
        {
            try
            {
                using (var engine = new TesseractEngine("./tessdata", "eng", EngineMode.Default))
                {
                    using (var img = Pix.LoadFromFile(imagePath))
                    {
                        using (var page = engine.Process(img))
                        {
                            var text = page.GetText();
                            return text;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        private string ProcessPdf(string pdfPath)
        {
            StringBuilder sb = new StringBuilder();

            using (PdfDocument document = PdfDocument.Open(pdfPath))
            {
                for (int i = 0; i < document.NumberOfPages; i++)
                {
                    PdfPigPage page = document.GetPage(i + 1);
                    sb.AppendLine(page.Text);
                }
            }

            return sb.ToString();
        }

        private void uploadApplicationForm_Load(object sender, EventArgs e)
        {
            // Remove this line to avoid runtime errors
            // throw new System.NotImplementedException();
        }

        /*private void btnAnalyse_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < listBoxFiles.Items.Count; i++)
            {
                string filePath = listBoxFiles.Items[i].ToString();
                string extension = Path.GetExtension(filePath).ToLower();

                string extractedText = null;

                if (extension == ".pdf")
                {
                    extractedText = ProcessPdf(filePath);
                }
                else if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".bmp")
                {
                    extractedText = ProcessImage(filePath);
                }

                if (extractedText != null)
                {
                    sb.AppendLine($"File: {filePath}\nExtracted text:\n{extractedText}\n");
                    listBoxFiles.SetSelected(i, true);
                }
            }
            txtResult.Text = sb.ToString();
        }*/
        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < listBoxFiles.Items.Count; i++)
            {
                string filePath = listBoxFiles.Items[i].ToString();
                string extension = Path.GetExtension(filePath).ToLower();

                string extractedText = null;

                if (extension == ".pdf")
                {
                    extractedText = ProcessPdf(filePath);
                }
                else if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".bmp")
                {
                    extractedText = ProcessImage(filePath);
                }

                if (extractedText != null)
                {
                    sb.AppendLine($"File: {filePath}\nExtracted text:\n{extractedText}\n");
                    listBoxFiles.SetSelected(i, true);
                }
            }

            txtResult.Text = sb.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var deleteDialog = new CustomDeleteDialog())
            {
                var result = deleteDialog.ShowDialog();
                if (result == DialogResult.Yes) // Delete files from disk
                {
                    for (int i = listBoxFiles.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        string filePath = listBoxFiles.SelectedItems[i].ToString();

                        try
                        {
                            File.Delete(filePath);
                            listBoxFiles.Items.Remove(listBoxFiles.SelectedItems[i]);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting file: " + filePath + "\n" + ex.Message);
                        }
                    }
                }
                else if (result == DialogResult.No) // Remove file paths from list only
                {
                    for (int i = listBoxFiles.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        listBoxFiles.Items.Remove(listBoxFiles.SelectedItems[i]);
                    }
                }
            }
        }
        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string filePath in listBoxFiles.SelectedItems)
            {
                string extension = Path.GetExtension(filePath).ToLower();
                string extractedText = null;
                if (extension == ".pdf")
                {
                    extractedText = ProcessPdf(filePath);
                }
                else if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".bmp")
                {
                    extractedText = ProcessImage(filePath);
                }
                if (extractedText != null)
                {
                    sb.AppendLine($"File: {filePath}\nExtracted text:\n{extractedText}\n");
                }
            }
            txtResult.Text = sb.ToString();
        }
    }
}
