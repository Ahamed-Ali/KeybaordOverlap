namespace KeyBoardOverlap
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
          
        }

        private void TransferOutClicked_Clicked(object sender, EventArgs e)
        {
            contentView.TranslationX = DeviceDisplay.Current.MainDisplayInfo.Width - 970;
        }

        private void TransferTo0_Clicked(object sender, EventArgs e)
        {
            contentView.TranslationX = 0;
        }
    }

}
