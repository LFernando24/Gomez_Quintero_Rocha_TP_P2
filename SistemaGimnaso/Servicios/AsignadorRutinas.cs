using SistemaGimnasio.Gestores;
using SistemaGimnasio.Modelos;
using SistemaGimnaso.Modelos;
namespace SistemaGimnasio.Servicios
{
    public class AgregadorRutinas
    {
        private GestorRutinas gestorRutinas;
        public AgregadorRutinas(GestorRutinas gestor)
        {
            gestorRutinas = gestor;
        }
        public void AsignarRutinaUsuario(Usuario usuario, Rutina rutina)
        {
            usuario.AsignarRutina(rutina)
        }
        public void AsignarUsuarioAlEntrenador(Entrenador entrenador, Usuario usuario)
        {
            entrenador.AsignarUsuario(usuario);
        }
    }
}