namespace empleados;

public partial class Perfil : ContentPage
{
	public Perfil()
	{
		InitializeComponent();
	}


    // Bot�n Editar: Navega a la p�gina de edici�n
    private async void OnEditarClicked(object sender, EventArgs e)
    {
        // Navega a la p�gina de edici�n
        await Navigation.PushAsync(new EditarPerfil());
    }

    // Bot�n Eliminar: Cierra la p�gina actual
    private async void OnEliminarClicked(object sender, EventArgs e)
    {
        // Confirmar eliminaci�n (opcional)
        bool respuesta = await DisplayAlert("Confirmar", "�Est�s seguro de que deseas eliminar esta p�gina?", "S�", "No");

        if (respuesta)
        {
            // Elimina o cierra la p�gina actual
            await Navigation.PopAsync();
        }
    }
}

