using System.Collections.ObjectModel;

namespace MauiControls;

public partial class RefreshViewPage : ContentPage
{
    ObservableCollection<sahCollection> liste;

    public RefreshViewPage()
    {
        InitializeComponent();

        liste = new ObservableCollection<sahCollection>()
        {
            new sahCollection{Title="resim1", ImageSource="https://resimakademi.com.tr/uploads/2023/04/resim-yapmanin-faydalari-1.jpg"},
            new sahCollection{Title="resim2", ImageSource="https://blog.koctas.com.tr/wp-content/uploads/2022/04/resim-hobisi.jpg"},
            new sahCollection{Title="resim3", ImageSource="https://resimakademi.com.tr/uploads/2023/04/resim-cizmek.jpg"},
            new sahCollection{Title="resim4", ImageSource="https://cdn.iha.com.tr/Contents/images/2022/23/4811686.jpg"},
            new sahCollection{Title="resim5", ImageSource="https://cdn.akmistanbul.gov.tr/other/sir-sergi-yatay.jpg"},
        };

        myCollection.ItemsSource = liste;
    }

    private async void RefreshView_Refreshing(object sender, EventArgs e)
    {
        // Simülasyon: yenileme süresi
        await Task.Delay(1500);

        liste.Clear();

        liste.Add(new sahCollection { Title = "Yeni Resim 1", ImageSource = "https://picsum.photos/400/200?random=1" });
        liste.Add(new sahCollection { Title = "Yeni Resim 2", ImageSource = "https://picsum.photos/400/200?random=2" });
        liste.Add(new sahCollection { Title = "Yeni Resim 3", ImageSource = "https://picsum.photos/400/200?random=3" });

        myRefreshView.IsRefreshing = false;
    }
}

public class sahCollection
{
    public string ImageSource { get; set; }
    public string Title { get; set; }
}
