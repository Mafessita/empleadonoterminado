namespace empleados;

public partial class PerfilProducto : ContentPage
{
	public PerfilProducto()
	{
		InitializeComponent();
	}

    public string Imagen { get; internal set; }
    public string Nombre { get; internal set; }
}