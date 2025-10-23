namespace MauiControls;

public partial class TimePickerPage : ContentPage
{
	private TimeSpan selectedTimePicker;

	public TimeSpan SelectedTimePicker
    {
		get 
		{
			return selectedTimePicker;
		}
		set
		{
			selectedTimePicker = value;
		}
	}

	public TimePickerPage()
	{
		InitializeComponent();
		this.BindingContext = this;
	}
}