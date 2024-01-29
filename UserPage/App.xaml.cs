using UserPage.Views;

namespace UserPage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginView();

        }
    }
}