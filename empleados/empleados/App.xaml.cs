namespace empleados
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Inicio();
        }

        public static Inicio FlyoutPage { get; internal set; }
    }
}
