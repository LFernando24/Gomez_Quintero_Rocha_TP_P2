using SistemaGimnasio.Modelos;
using SistemaGimnasio.Models;
using SistemaGimnasio.Servicios;
using SistemaGimnaso.Modelos;
using System;

namespace SistemaGimnasio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE GIMNASIO");

            // 1. Registrar un usuario
            Usuario usuario = new Usuario("Luis Fernando", 21, "Ganar masa muscular");

            // 2. Registrar ejercicios (3) y crear una rutina personalizada
            Ejercicio ej1 = new Ejercicio("Press de Banca", 12, 4, "90 seg");
            Ejercicio ej2 = new Ejercicio("Sentadilla", 10, 4, "120 seg");
            Ejercicio ej3 = new Ejercicio("Peso Muerto", 8, 4, "120 seg");

            Rutina rutinaFuerza = new Rutina("Rutina de Fuerza Base", "60 min");
            rutinaFuerza.AgregarEjercicio(ej1);
            rutinaFuerza.AgregarEjercicio(ej2);
            rutinaFuerza.AgregarEjercicio(ej3);

            // 3. Asignar la rutina al usuario
            AsignadorRutinas servicioAsignacion = new AsignadorRutinas();
            servicioAsignacion.AsignarRutinaAUsuario(usuario, rutinaFuerza);

            // 4. Registrar un entrenador
            Entrenador entrenador = new Entrenador("Carlos Pérez", "Acondicionamiento Físico");

            // 5. Asignar al entrenador un usuario
            servicioAsignacion.AsignarEntrenadorAUsuario(usuario, entrenador);

            // 6. Mostrar un resumen para verificación
            Console.WriteLine("--- RESUMEN DE ASIGNACIONES ---");
            Console.WriteLine($"Usuario: {usuario.Nombre} | Edad: {usuario.Edad} | Objetivo: {usuario.Objetivo}");
            Console.WriteLine($"Entrenador: {usuario.EntrenadorAsignado.Nombre} (Especialidad: {usuario.EntrenadorAsignado.Especialidad})");
            Console.WriteLine($"Rutina: {usuario.RutinaAsignada.Nombre} (Duración: {usuario.RutinaAsignada.Duracion})\n");

            Console.WriteLine("Ejercicios:");
            foreach (var ejercicio en usuario.RutinaAsignada.Ejercicios)
            {
                Console.WriteLine($"- {ejercicio.Nombre}: {ejercicio.Series} series de {ejercicio.Repeticiones} repeticiones. Descanso: {ejercicio.TiempoDescanso}");
            }
        }
    }
}