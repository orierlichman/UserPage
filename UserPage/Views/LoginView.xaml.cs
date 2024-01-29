using UserPage.ViewModels;

namespace UserPage.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
		BindingContext = new LoginViewModel();


    }
}