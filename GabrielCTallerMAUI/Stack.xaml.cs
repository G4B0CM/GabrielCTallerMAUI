namespace GabrielCTallerMAUI;

public partial class Stack : ContentPage
{
	public Stack()
	{
		InitializeComponent();
	}
    private void B1_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Flexy());
    }
}