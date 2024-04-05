namespace Images
{
    public partial class MainPage : ContentPage
    {
        List<string> imagePaths = new List<string> {
            "dotnet_bot.png",
            "mauii.jpg",
            "spongbob.png",
            "mix.png"
        };

        Random random = new Random();

        public MainPage()
        {
            InitializeComponent();
        }

        private void clickme_Clicked(object sender, EventArgs e)
        {
            ShuffleImages();
        }

        private void ShuffleImages()
        {
            List<string> shuffledPaths = new List<string>(imagePaths);
            for (int i = 0; i < shuffledPaths.Count; i++)
            {
                int randomIndex = random.Next(i, shuffledPaths.Count);
                string temp = shuffledPaths[i];
                shuffledPaths[i] = shuffledPaths[randomIndex];
                shuffledPaths[randomIndex] = temp;
            }

            img1.Source = shuffledPaths[0];
            img2.Source = shuffledPaths[1];
            img3.Source = shuffledPaths[2];
            img4.Source = shuffledPaths[3];
        }
    }
}


