
using MC.Modelo;

namespace MC.Servicios
{
    public interface IRickAndMortyService
    {
        public Task<List<PersonajesResponse>> Obtener();

    }
}
