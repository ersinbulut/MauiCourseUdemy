namespace MauiControls;

public partial class PickerPage : ContentPage
{
	public PickerPage()
	{
		InitializeComponent();
		var list=new List<string>()
		{
			"Klavye",
			"Mause",
			"Monitor",
		};
		mypicker.ItemsSource=list;
    }

    private void mypicker_SelectedIndexChanged(object sender, EventArgs e)
    {
		mypicker.SelectedItem.ToString();
    }
}