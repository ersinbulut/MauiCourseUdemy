namespace MauiControls;

public partial class ActivityIndicatorPage : ContentPage
{
	public ActivityIndicatorPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		myImage.Source = "https://resimakademi.com.tr/uploads/2023/04/resim-cizmek.jpg";
		
	}
}