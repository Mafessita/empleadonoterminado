namespace empleados;

public partial class Perfil : ContentPage
{
	public Perfil()
	{
		InitializeComponent();
	}


    // Botón Editar: Navega a la página de edición
    private async void OnEditarClicked(object sender, EventArgs e)
    {
        // Navega a la página de edición
        await Navigation.PushAsync(new EditarPerfil());
    }

    // Botón Eliminar: Cierra la página actual
    private async void OnEliminarClicked(object sender, EventArgs e)
    {
        // Confirmar eliminación (opcional)
        bool respuesta = await DisplayAlert("Confirmar", "¿Estás seguro de que deseas eliminar esta página?", "Sí", "No");

        if (respuesta)
        {
            // Elimina o cierra la página actual
            await Navigation.PopAsync();
        }
    }
}

