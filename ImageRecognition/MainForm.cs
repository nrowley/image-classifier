using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alturos.Yolo;

namespace ImageRecognition
{
    public partial class MainForm : Form
    {
        bool imageUploaded = false;
        public MainForm()
        {
            InitializeComponent();
           
        }

        private void beginBtn_Click(object sender, EventArgs e)
        {
            if (imageUploaded == true)
            {
                //begin processing
                var configurationDetector = new YoloConfigurationDetector();
                var config = configurationDetector.Detect();
                using(var yoloWrapper = new YoloWrapper(config))
                {
                    using (MemoryStream memStream = new MemoryStream())
                    {
                        imageBox.Image.Save(memStream, ImageFormat.Png);
                        var items = yoloWrapper.Detect(memStream.ToArray());

                        yoloItemBindingSource.DataSource = items;

                    }
                }
            

            }
        }

        private void fileUploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Image Files (*.jpg)|*.jpg|(*.png)|*.png";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string image = openFileDialog.FileName;
                imageBox.Image = Image.FromFile(image);
                imageUploaded = true;
            }
        }
    }
}
