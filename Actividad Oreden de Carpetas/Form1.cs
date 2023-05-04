using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using File = System.IO.File;

namespace Actividad_Oreden_de_Carpetas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSortfiles_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta de la carpeta seleccionada
                string selectedPath = folderDialog.SelectedPath;

                // Crear carpetas para cada tipo de archivo
                string imagesFolder = Path.Combine(selectedPath, "Imágenes");
                if (!Directory.Exists(imagesFolder))
                {
                    Directory.CreateDirectory(imagesFolder);
                }
                string videosFolder = Path.Combine(selectedPath, "Videos");
                if (!Directory.Exists(videosFolder))
                {
                    Directory.CreateDirectory(videosFolder);
                }
                string musicFolder = Path.Combine(selectedPath, "Música");
                if (!Directory.Exists(musicFolder))
                {
                    Directory.CreateDirectory(musicFolder);
                }
                string othersFolder = Path.Combine(selectedPath, "Otros");
                if (!Directory.Exists(othersFolder))
                {
                    Directory.CreateDirectory(othersFolder);
                }
                // Obtener una lista de todos los archivos en la carpeta seleccionada
                string[] files = Directory.GetFiles(selectedPath);

                // Mover los archivos a las carpetas correspondientes
                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file);
                    string fileName = Path.GetFileName(file);

                    if (extension.Equals(".jpg") || extension.Equals(".jpeg") || extension.Equals(".png") || extension.Equals(".gif"))
                    {
                        string destFile = Path.Combine(imagesFolder, fileName);
                        File.Move(file, destFile);
                    }
                    else if (extension.Equals(".mp4") || extension.Equals(".avi") || extension.Equals(".mov") || extension.Equals(".wmv"))
                    {
                        string destFile = Path.Combine(videosFolder, fileName);
                        File.Move(file, destFile);
                    }
                    else if (extension.Equals(".mp3") || extension.Equals(".wav") || extension.Equals(".flac"))
                    {
                        string destFile = Path.Combine(musicFolder, fileName);
                        File.Move(file, destFile);
                    }
                    else
                    {
                        string destFile = Path.Combine(othersFolder, fileName);
                        File.Move(file, destFile);
                    }
                }
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (btnReproducir.Text == "Pause")
            {
                vlcControl1.Pause();
                btnReproducir.Text = "Play";
            }
            else
            {
                vlcControl1.Play();
                btnReproducir.Text = "Pause";
            }
        }

       
        private void btnPlayfiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos multimedia|*.*";
            DialogResult result = openFileDialog.ShowDialog();

            try
            {
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
                {
                    string filePath = openFileDialog.FileName;
                    vlcControl1.Play(new Uri(filePath));
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            vlcControl1.Audio.Volume = trackBar2.Value * 10;
        }
    }
}


