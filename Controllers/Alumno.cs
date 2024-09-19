using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApi.Controllers
{
    public class Alumno
    {
        //Creando Propiedades
        string nombre;
        string Apellido;
        string dni;
        DateTime fechanacimiento;

        //Constructor sin parametros
        public Alumno()
        {
            nombre = string.Empty;
            Apellido = string.Empty;
            dni = string.Empty;
            fechanacimiento = DateTime.Now;
            
        }

        //Constructor con parametros

        public Alumno(string pNombre, string pApellido, string pdni)
        {
            nombre = pNombre;
            Apellido = pApellido;
            dni = pdni;
        }
        public Alumno(string pNombre, string pApellido, string pdni, DateTime pfechaNacimiento)
        {
            nombre = pNombre;
            Apellido = pApellido;
            dni = pdni;
            fechanacimiento = pfechaNacimiento;
        }
        public string DevolverNombreCompleto()
        {
            return nombre + " " + Apellido;
        }

        public string DevolverDni()

        {
            return dni;
        }

        public int DevolverEdad()
        {
            return DateTime.Now.Year - fechanacimiento.Year;
        }
    }
}
