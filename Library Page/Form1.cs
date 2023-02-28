using System.Diagnostics;

namespace Library_Page
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtSearchByGenre.Text)) {
                string userInput = txtSearchByGenre.Text;
                var sampleData = new MyMachineLearning.ModelInput();

                sampleData.Col0 = userInput;


                //Load model and predict output
                var result = MyMachineLearning.Predict(sampleData);
                if (result.PredictedLabel == 1)
                {
                    lblResultBox.Text = "This is a positive statement";
                }
                else
                {
                    lblResultBox.Text = "This is a negative statement";
                }
                Debug.WriteLine(result.PredictedLabel);




            }
            //Load sample data
            








        }
    }
}