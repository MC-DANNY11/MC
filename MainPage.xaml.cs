using MC.Servicios;

namespace MC
{
    public partial class MainPage : ContentPage
    {
        private readonly IRickAndMortyService _rickAndMortyService;

        public MainPage(IRickAndMortyService service)
        {
            InitializeComponent();
            _rickAndMortyService = service;

            // Cargar personajes cuando la página se inicializa
            CargarPersonaje();
        }

        public async void CargarPersonaje()
        {
            try
            {
                // Llama al servicio para obtener los personajes
                var data = await _rickAndMortyService.Obtener();

                // Asigna los datos al ListView
                listViewPersonajes.ItemsSource = data;
            }
            catch (Exception ex)
            {
                // Manejo básico de errores
                await DisplayAlert("Error", $"No se pudieron cargar los personajes: {ex.Message}", "OK");
            }
        }
    }
}
