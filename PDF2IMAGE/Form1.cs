using Docnet.Core;
using Docnet.Core.Converters;
using Docnet.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF2IMAGE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_selectPDF_Click(object sender, EventArgs e)
        {
            textbox_selectedPDF.Text = getFilePath();
        }

        private void button_output_Click(object sender, EventArgs e)
        {
            textbox_output.Text = getFolderPath();
        }

        private async void button_generate_Click(object sender, EventArgs e)
        {
            button_selectPDF.Enabled = false;
            button_output.Enabled = false;
            button_generate.Enabled = false;

            var progress = new Progress<int>(value =>
            {
                progressBar1.Value = value;
            });

            await Task.Run(() => generate(progress));

            button_selectPDF.Enabled = true;
            button_output.Enabled = true;
            textbox_selectedPDF.Text = string.Empty;
            textbox_output.Text = string.Empty;
            progressBar1.Value = 0;
        }

        private void generate(IProgress<int> progress)
        {
            using var docReader = DocLib.Instance.GetDocReader(textbox_selectedPDF.Text, new PageDimensions(1080, 1920));

            var pageCount = docReader.GetPageCount();

            for (int i = 0; i < pageCount; i++)
            {
                using var pageReader = docReader.GetPageReader(i);

                var rawBytes = pageReader.GetImage();

                var width = pageReader.GetPageWidth();
                var height = pageReader.GetPageHeight();

                var characters = pageReader.GetCharacters();

                using var bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);

                AddBytes(bmp, rawBytes);
                using var stream = new MemoryStream();

                bmp.Save(stream, ImageFormat.Png);

                File.WriteAllBytes($"{textbox_output.Text}/{i}.png", stream.ToArray());
                var percentComplete = (i * 100) / pageCount;
                progress.Report(percentComplete);
            }
        }

        private static void AddBytes(Bitmap bmp, byte[] rawBytes)
        {
            var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);

            var bmpData = bmp.LockBits(rect, ImageLockMode.WriteOnly, bmp.PixelFormat);
            var pNative = bmpData.Scan0;

            Marshal.Copy(rawBytes, 0, pNative, rawBytes.Length);
            bmp.UnlockBits(bmpData);
        }
        private string getFilePath()
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select PDF";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "Pdf Files|*.pdf";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                return fdlg.FileName;
            }
            return "";
        }

        private string getFolderPath()
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                return folderDlg.SelectedPath;
            }

            return "";
        }

        private void textboxSelectedPDF_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void setButtonVisibility()
        {
            if ((textbox_selectedPDF.Text != string.Empty) && (textbox_output.Text != string.Empty))
            {
                button_generate.Enabled = true;
            }
            else
            {
                button_generate.Enabled = false;
            }
        }
    }
}
