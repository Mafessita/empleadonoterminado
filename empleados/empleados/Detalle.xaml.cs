using System.Collections.ObjectModel;
using empleados.Model;


namespace empleados;
public partial class Detalle : ContentPage
{
    public ObservableCollection<Citas> Citas { get; set; }
    public ObservableCollection<Servicio> servicio { get; set; }

    public Detalle()
    {
        InitializeComponent();

        // Inicialización de colecciones
        Citas = new ObservableCollection<Citas>();
        servicio = new ObservableCollection<Servicio>();

        // Agregando servicios
        servicio.Add(new Servicio
        {
            Nombre = "Degradado",
            Imagen = "degradado.jpg",
            Calificacion = "\u2605\u2605\u2605\u2605\u2606",
        });

       servicio.Add(new Servicio
        {
            Nombre = "Taper",
            Imagen = "corte_peinado.png",
            Calificacion = "\u2605\u2605\u2605\u2605\u2606",
        });

        servicio.Add(new Servicio
        {
            Nombre = "Mohicano",
            Imagen = "mohicano.jpg",
            Calificacion = "\u2605\u2605\u2605\u2605\u2606",
        });

        servicio.Add(new Servicio
        {
            Nombre = "Fade V",
            Imagen = "fade_v.jpg",
            Calificacion = "\u2605\u2605\u2605\u2605\u2606",
        });

        ColeccionServicio.ItemsSource = servicio;

        // Agregando citas
        Citas.Add(new Citas
        {
            Nombre = "Espuma",
            Imagen = "producto_1.jpg",
            Descripcion = "Lorem",
        });

        Citas.Add(new Citas
        {
            Nombre = "Gel",
            Imagen = "producto_2.jpg",
            Descripcion = "Lorem",
        });

        ProductosInicio.ItemsSource = Citas;
    }

    private async void OnCartTapped(object sender, EventArgs e)
    {
        // Simula un efecto de "presionado" reduciendo el tamaño y volviendo a su estado original
        await CarritoFrame.ScaleTo(0.9, 100);  // Reducción de tamaño al presionar
        await CarritoFrame.ScaleTo(1, 100);    // Regresa al tamaño original

        // Navega a la página del carrito
    }

    private async void VerMaServicios(object sender, EventArgs e)
    {
        // Navegar a la página de servicios
        await Navigation.PushAsync(new Servicios());
    }

    private async void VerMasProductos(object sender, EventArgs e)
    {
        // Aquí puedes navegar a la página de productos, por ejemplo:
        // await Navigation.PushAsync(new ProductosPage());
    }

    private void IrServicio(object sender, TappedEventArgs e)
    {
        var frame = (Frame)sender;
        var itemSelected = frame.BindingContext as Servicio;

        if (itemSelected != null)
        {
            // Navegar a la página "General" pasando el objeto seleccionado
            // Ejemplo: Navigation.PushAsync(new DetalleServicioPage(itemSelected));
        }
    }

    private void NavigationToPage(ContentPage page)
    {
        if (App.FlyoutPage != null)
        {
            App.FlyoutPage.Detail.Navigation.PushAsync(page);
            App.FlyoutPage.IsPresented = false;
        }
    }
}
