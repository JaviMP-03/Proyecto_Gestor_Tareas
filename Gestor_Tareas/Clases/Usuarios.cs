using Dapper.Contrib.Extensions;

namespace Gestor_Tareas.Clases
{
    [Table("Usuarios")]
    internal class Usuarios
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string contraseña { get; set; }

        public override string ToString()
        {
            return $"ID: {ID} | {Nombre} | {contraseña}";
        }
    }
}
