using MAUI_Sample_Proyects.Code_Quotes;
using MAUI_Sample_Proyects.ExternalResources;
using MAUI_Sample_Proyects.Pages;

namespace MAUI_Sample_Proyects
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage());
        }
    }
}