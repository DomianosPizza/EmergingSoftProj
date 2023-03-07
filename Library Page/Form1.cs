using System.Diagnostics;

namespace Library_Page
{
    public partial class Library : Form
    {
        public int _id;
        public int _movieId;
        public Library()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblResults.Text= string.Empty;
            bool validUID = int.TryParse(txtUID.Text, out _id);
            bool validMovieID = int.TryParse(txtMovieID.Text, out _movieId);
            if (!validUID && !validMovieID) {
                lblResults.Text = "A value you inputed was not a valid id";
            }
            else
            {
                var sampleData = new MyMachineLearning.ModelInput()
                {
                    UserId = _id,
                    MovieId = _movieId,
                };
                //Load model and predict output
                var result = MyMachineLearning.Predict(sampleData);
                Debug.WriteLine($"Predicted rating - {Math.Round(result.Score)}");
                if(result.Score >= 4.0f)
                {
                    lblResults.Text = "User " + _id + " would like enjoy this film "+_movieId;
                }
                if(result.Score < 4.0f && result.Score > 2.9f)
                {
                    lblResults.Text = "User " + _id + " would maybe like film "+_movieId;
                }
                if (result.Score < 2.9f)
                {
                    lblResults.Text = "User " + _id + " would not like film " + _movieId;
                }
            }
            
        }
    }
}