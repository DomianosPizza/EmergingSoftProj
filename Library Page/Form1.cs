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
            bool validUID = int.TryParse(txtUID.Text, out _id);
            bool validMovieID = int.TryParse(txtMovieID.Text, out _movieId);
            if (!validUID && !validMovieID) {
                lblResults.Text = "That isn't a valid userID";
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

                
            }
            
        }
    }
}