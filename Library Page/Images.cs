using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Tensorflow.Operations.Initializers;
using Tensorflow;
using NumSharp.Extensions;

namespace Library_Page
{
    public partial class Images : Form
    {
        Random ranImage = new Random();
        List<Image> proImages = new List<Image>();
        //private string[] aryImages = Directory.GetFiles("Project Images").OrderBy(f => f).ToArray();

        public Images()
        {
            InitializeComponent();
        }

        private void Images_Load(object sender, EventArgs e)
        {

            //Load sample data
            var imageBytes = File.ReadAllBytes(@"C:\Users\jbursi\source\repos\EmergingSoftProj\Library Page\Project Images\Cat Images\Cat 1.jpg");
            ImageMachine.ModelInput sampleData = new ImageMachine.ModelInput()
            {
                ImageSource = imageBytes,
            };

            //Load model and predict output
            var result = ImageMachine.Predict(sampleData);

            proImages.Add(Properties.Resources.Cat_1);
            proImages.Add(Properties.Resources.Cat_2);
            proImages.Add(Properties.Resources.Cat_3);
            proImages.Add(Properties.Resources.Cat_4);
            proImages.Add(Properties.Resources.Cat_5);
            proImages.Add(Properties.Resources.Cat_6);
            proImages.Add(Properties.Resources.Cat_7);
            proImages.Add(Properties.Resources.Cat_8);
            proImages.Add(Properties.Resources.Cat_9);
            proImages.Add(Properties.Resources.Cat_10);
            proImages.Add(Properties.Resources.Cat_11);
            proImages.Add(Properties.Resources.Cat_12);
            proImages.Add(Properties.Resources.Cat_13);
            proImages.Add(Properties.Resources.Cat_14);
            proImages.Add(Properties.Resources.Cat_15);
            proImages.Add(Properties.Resources.Cat_16);
            proImages.Add(Properties.Resources.Cat_17);
            proImages.Add(Properties.Resources.Cat_18);
            proImages.Add(Properties.Resources.Cat_19);
            proImages.Add(Properties.Resources.Cat_20);
            proImages.Add(Properties.Resources.Cat_21);
            proImages.Add(Properties.Resources.Cat_22);
            proImages.Add(Properties.Resources.Cat_23);
            proImages.Add(Properties.Resources.Cat_24);
            proImages.Add(Properties.Resources.Cat_25);
            proImages.Add(Properties.Resources.Cat_26);
            proImages.Add(Properties.Resources.Cat_27);
            proImages.Add(Properties.Resources.Cat_28);
            proImages.Add(Properties.Resources.Cat_29);
            proImages.Add(Properties.Resources.Cat_30);

            proImages.Add(Properties.Resources.Dog_1);
            proImages.Add(Properties.Resources.Dog_2);
            proImages.Add(Properties.Resources.Dog_3);
            proImages.Add(Properties.Resources.Dog_4);
            proImages.Add(Properties.Resources.Dog_5);
            proImages.Add(Properties.Resources.Dog_6);
            proImages.Add(Properties.Resources.Dog_7);
            proImages.Add(Properties.Resources.Dog_8);
            proImages.Add(Properties.Resources.Dog_9);
            proImages.Add(Properties.Resources.Dog_10);
            proImages.Add(Properties.Resources.Dog_11);
            proImages.Add(Properties.Resources.Dog_12);
            proImages.Add(Properties.Resources.Dog_13);
            proImages.Add(Properties.Resources.Dog_14);
            proImages.Add(Properties.Resources.Dog_15);
            proImages.Add(Properties.Resources.Dog_16);
            proImages.Add(Properties.Resources.Dog_17);
            proImages.Add(Properties.Resources.Dog_18);
            proImages.Add(Properties.Resources.Dog_19);
            proImages.Add(Properties.Resources.Dog_20);
            proImages.Add(Properties.Resources.Dog_21);
            proImages.Add(Properties.Resources.Dog_22);
            proImages.Add(Properties.Resources.Dog_23);
            proImages.Add(Properties.Resources.Dog_24);
            proImages.Add(Properties.Resources.Dog_25);
            proImages.Add(Properties.Resources.Dog_26);
            proImages.Add(Properties.Resources.Dog_27);
            proImages.Add(Properties.Resources.Dog_28);
            proImages.Add(Properties.Resources.Dog_29);
            proImages.Add(Properties.Resources.Dog_30);


        }

        private void btnImageSummon_Click(object sender, EventArgs e)
        {
            //picImage.Image = Image.FromFile(aryImages[0]);
            picImage.Image = proImages[ranImage.Next(0, proImages.Count)];

            picImage.SizeMode = PictureBoxSizeMode.StretchImage;


        }
    }
}
