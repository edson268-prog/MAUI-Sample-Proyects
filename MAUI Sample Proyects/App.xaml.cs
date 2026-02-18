using MAUI_Sample_Proyects.ExternalResources;

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
            return new Window(new ExternalResources.ExternalResources());
        }
    }
}