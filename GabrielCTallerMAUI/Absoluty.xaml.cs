namespace GabrielCTallerMAUI;

public partial class Absoluty : ContentPage
{
	public Absoluty()
	{
		InitializeComponent();
	}
    private void B1_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}