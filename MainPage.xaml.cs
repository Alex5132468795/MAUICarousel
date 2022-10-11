using MauiApp4.Model;
using System.Collections.ObjectModel;

namespace MauiApp4;


public partial class MainPage : ContentPage
{
	public ObservableCollection<Users> Users { get; set; }

	
	public MainPage()
	{
		Users = new ObservableCollection<Users> { new Users(), new Users(), new Users() };
		Users[0].Name = "1";
		Users[1].Name = "2";
		Users[2].Name = "3";
		Users[0].Id = 1;
		Users[1].Id = 2;
		Users[2].Id = 3;
		Users[0].Source = "dotnet_bot.png";
		Users[1].Source = "dotnet_bot.png";
		Users[2].Source = "dotnet_bot.png";
		BindingContext = this;
        InitializeComponent();
	}

	private void newElement(object sender, EventArgs e)
	{
		Users u = new Users();
		u.Name = Users.Count.ToString();
        u.Id = Users.Count;
        u.Source = "dotnet_bot.png";
		Users.Add(u);


    }
}

