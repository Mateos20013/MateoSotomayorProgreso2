using MateoSotomayorProgreso2.Interfaces;
using MateoSotomayorProgreso2.Models;
using MateoSotomayorProgreso2.Repositories;

namespace MateoSotomayorProgreso2;

public partial class Recarga : ContentPage
{
    public Recarga recarga;
    IRecarga _recargaRepository;
    public List<Recarga> recargaList;
    public string _fileName = Path.Combine(FileSystem.AppDataDirectory, "CrhystelVelasco.txt");
    public Recarga()
    {
        InitializeComponent();
        recarga = new Recarga();
        BindingContext = recarga;
        _recargaRepository = new RecargaRepository();

    }


    private async void Buton1_Clicked(object sender, EventArgs e)
    {
        var nuevaRecarga = new Recarga
        {
            Nombre = Mateo_SotomayorEntry1.Text,
            NumeroTelefono = Mateo_SotomayorEntry.Text,
            MensajeResultado = "Recarga exitosa"
        };

        if (_recargaRepository.CrearRecarga(nuevaRecarga))
        {
            Mateo_sotomayorLabel2.Text = "Recarga guardada con éxito.";
            CargarRecargas();
            await DisplayAlert("Alert", "Recarga guardada con éxito.\"", "OK");
        }
        else
        {
            await DisplayAlert("Alert", "Error al guardar la recarga.\"", "OK");
            Mateo_sotomayorLabel2.Text = "Error al guardar la recarga.";
        }



    }
    private void CargarRecargas()
    {

        var recargas = _recargaRepository.DevuelveListRecarga();


        var recargasTexto = string.Join("\n", recargas.Select(r => $"{r.Nombre} - {r.NumeroTelefono}"));

        Mateo_sotomayorLabel2.Text = recargasTexto;
    }
    private void Buton2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Grid());

    }
}









