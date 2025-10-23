namespace MauiControls;

public partial class DatePickerPage : ContentPage
{
    public DatePickerPage()
    {
        InitializeComponent();
    }

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        var control = (Microsoft.Maui.Controls.DatePicker)sender; // ✅ Doğru tür
        DateTime result = control.Date;

        TimeSpan span = result - datepickerfirst.Date;
        DisplayAlert("Gün Farkı", $"{span.Days} gün", "Tamam");
    }
}
