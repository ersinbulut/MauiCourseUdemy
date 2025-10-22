namespace MauiControls;

public partial class SwitchPage : ContentPage
{
	public SwitchPage()
	{
		InitializeComponent();
	}

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
		if(this.@switch.IsToggled)
		{
			DisplayAlert("Bilgilendirme", "Switch Onaylandý", "OK");
        }
		else
		{

		}
    }
}