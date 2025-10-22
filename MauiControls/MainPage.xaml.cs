namespace MauiControls
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            DisplayAlert("Tapped", "Label was tapped!", "OK");
        }
    }
}
