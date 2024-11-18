namespace GabrielCTallerMAUI;

public partial class Flexy : ContentPage
{
	public Flexy()
	{
		InitializeComponent();
	}
    private void B1_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Flexy());
    }
}