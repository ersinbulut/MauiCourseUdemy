using System.Threading.Tasks;

namespace MauiControls;

public partial class CheckBoxPage : ContentPage
{
	public CheckBoxPage()
	{
		InitializeComponent();
	}

    private async void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if(checkbox.IsChecked)
		{
			await DisplayAlert("CheckBox", "Ýþlem Onaylandý.", "OK");
        }
		else
		{

		}
    }
}