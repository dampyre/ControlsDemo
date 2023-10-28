namespace ControlsDemo;

public partial class InputControlsDemo : ContentPage
{
	public InputControlsDemo()
	{
		InitializeComponent();
	}

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		//se rellena el lable con el color que entrega el slider
		lblSlider.Text = slider.Value.ToString();
    }

    private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if(stepper != null)
        {
            lblSlider.Text = slider.Value.ToString();
        }
    }
}