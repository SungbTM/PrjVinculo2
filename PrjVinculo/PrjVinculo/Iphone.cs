namespace PrjVinculo;

public class Iphone : ContentPage
{
	public Iphone()
	{

		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};

	}
}