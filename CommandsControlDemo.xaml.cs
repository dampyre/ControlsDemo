namespace ControlsDemo;

public partial class CommandsControlDemo : ContentPage
{
	public CommandsControlDemo()
	{
		InitializeComponent();
	}

    private void btnTest_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("ALertaaaa", "Este es un mensaje de alerta", "Cancelar");
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        DisplayAlert("Radio button", $"Changed:{e.Value}", "OK");
    }

    private void searchControl_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("Eats buscando", $"Buscando:{searchControl.Text}", "OK");
    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Swipeview", $"Element tapped", "OK");
    }
}