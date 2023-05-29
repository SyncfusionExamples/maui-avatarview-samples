using System.Collections.ObjectModel;

namespace AvatarViewImageCache;

public partial class MainPage : ContentPage
{

	private ObservableCollection<String> items = new ObservableCollection<String>();

	public ObservableCollection<String> Items
	{
		get { return items; }
		set { items = value; }
	}

	public MainPage()
	{
		InitializeComponent();

	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        for (int i = 0; i < 100; i++)
        {
            items.Add("avatarviewimage.png");
        }

        this.BindingContext = this;
    }
}

