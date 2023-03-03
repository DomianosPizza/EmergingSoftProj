using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Page
{
    public partial class Images : Form
    {
        Random rImage = new Random();

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

        }

        private void btnImageSummon_Click(object sender, EventArgs e)
        {
            rImage.Next();
        }
    }
}
