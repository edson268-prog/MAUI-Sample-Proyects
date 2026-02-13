using MAUI_Sample_Proyects.Perfect_Pay;

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
            return new Window(new PerfectPay());
        }
    }
}