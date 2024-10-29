namespace empleados;

public partial class Maestro : ContentPage
{
    public Maestro()
    {
        InitializeComponent();
    }
    private void InicioEmpleado(object sender, EventArgs e)
    {
        NavigationToPage(new InicioEmpleado());
    }

    private void Calendario(object sender, EventArgs e)
    {
        NavigationToPage(new Calendario());
    }

    private void Servicios(object sender, EventArgs e)
    {
        NavigationToPage(new Servicios());
    }

    private void Citas(object sender, EventArgs e)
    {
    }

    private void Historial(object sender, EventArgs e)
    {
        NavigationToPage(new Historial());
    }

    private void Perfil(object sender, EventArgs e)
    {
        NavigationToPage(new Perfil());
    }

    private void NavigationToPage(ContentPage page)
    {
        App.FlyoutPage.Detail.Navigation.PushAsync(page);
        App.FlyoutPage.IsPresented = false;
    }

}