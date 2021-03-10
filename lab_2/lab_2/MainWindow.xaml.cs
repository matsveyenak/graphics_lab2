using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Windows.Media;

namespace lab_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] formats = { ".jpg", ".gif", ".tif", ".bmp", ".png", ".pcx" };
        public class ImageInfo
        {
            public string Name { get; set; }
            public string Size { get; set; }
            public string DPI { get; set; }
            public int Depth { get; set; }
            public string Compression { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            warning_textbox.Foreground = System.Windows.Media.Brushes.Gray;
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            List<ImageInfo> users = new List<ImageInfo>();

            if (openFileDialog.ShowDialog() == true)
            {
                string fileName = openFileDialog.FileName;
                string name = System.IO.Path.GetFileName(fileName);
                string ext = Path.GetExtension(fileName);

                if (formats.Contains(ext))
                {
                    string size = "N/A", dpi = "N/A", compression = "N/A";
                    int depth = 0;
                    if (ext.Equals(".pcx"))
                    {
                        IEnumerable<MetadataExtractor.Directory> directories = ImageMetadataReader.ReadMetadata(fileName);
                        foreach (var directory in directories)
                        {
                            foreach (var tag in directory.Tags)
                            {
                                if (tag.Name.Equals("Bits Per Pixel"))
                                    depth = Convert.ToInt32(tag.Description);
                                else if (tag.Name.Equals("X Max"))
                                    size = tag.Description + "x";
                                else if (tag.Name.Equals("Y Max"))
                                    size += tag.Description;
                                else if (tag.Name.Equals("Horizontal DPI"))
                                    dpi = tag.Description + "x";
                                else if (tag.Name.Equals("Vertical DPI"))
                                    dpi += tag.Description;
                                else if (tag.Name.Equals("Compression"))
                                    compression = tag.Description;
                            }
                        }
                    }
                    else
                    {
                        Image img = Image.FromFile(fileName);

                        size = img.Width + "x" + img.Height;
                        dpi = img.HorizontalResolution + "x" + img.VerticalResolution;
                        depth = Image.GetPixelFormatSize(img.PixelFormat);

                        IEnumerable<MetadataExtractor.Directory> directories = ImageMetadataReader.ReadMetadata(fileName);
                        foreach (var directory in directories)
                        {
                            foreach (var tag in directory.Tags)
                            {
                                if (tag.Name.Equals("Compression"))
                                    compression = tag.Description;
                            }
                        }
                    }

                    users.Add(new ImageInfo() { Name = name, Size = size, DPI = dpi, Depth = depth, Compression = compression });
                }
                else
                    warning_textbox.Foreground = System.Windows.Media.Brushes.OrangeRed;

                gridList.ItemsSource = users;
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            warning_textbox.Foreground = System.Windows.Media.Brushes.Gray;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            List<ImageInfo> users = new List<ImageInfo>();

            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;

                foreach (string fileName in System.IO.Directory.GetFiles(folderPath))
                {
                    string name = System.IO.Path.GetFileName(fileName);
                    string ext = Path.GetExtension(fileName);

                    if (formats.Contains(ext))
                    {
                        string size = "N/A", dpi = "N/A", compression = "N/A";
                        int depth = 0;
                        if (ext.Equals(".pcx"))
                        {
                            IEnumerable<MetadataExtractor.Directory> directories = ImageMetadataReader.ReadMetadata(fileName);
                            foreach (var directory in directories)
                            {
                                foreach (var tag in directory.Tags)
                                {
                                    if (tag.Name.Equals("Bits Per Pixel"))
                                        depth = Convert.ToInt32(tag.Description);
                                    else if (tag.Name.Equals("X Max"))
                                        size = tag.Description + "x";
                                    else if (tag.Name.Equals("Y Max"))
                                        size += tag.Description;
                                    else if (tag.Name.Equals("Horizontal DPI"))
                                        dpi = tag.Description + "x";
                                    else if (tag.Name.Equals("Vertical DPI"))
                                        dpi += tag.Description;
                                    else if (tag.Name.Equals("Compression"))
                                        compression = tag.Description;
                                }
                            }
                        }
                        else
                        {
                            Image img = Image.FromFile(fileName);

                            size = img.Width + "x" + img.Height;
                            dpi = img.HorizontalResolution + "x" + img.VerticalResolution;
                            depth = Image.GetPixelFormatSize(img.PixelFormat);

                            IEnumerable<MetadataExtractor.Directory> directories = ImageMetadataReader.ReadMetadata(fileName);
                            foreach (var directory in directories)
                            {
                                foreach (var tag in directory.Tags)
                                {
                                    if (tag.Name.Equals("Compression"))
                                        compression = tag.Description;
                                }
                            }
                        }

                        users.Add(new ImageInfo() { Name = name, Size = size, DPI = dpi, Depth = depth, Compression = compression });
                    }
                    else
                        warning_textbox.Foreground = System.Windows.Media.Brushes.OrangeRed;
                }
                gridList.ItemsSource = users;
            }
        }
    }
}
