using Dapper.Contrib.Extensions;

namespace Gestor_Tareas.Clases
{
    [Table("Tareas")]
    internal class Tareas
    {
        [Key]
        public int ID { get; set; }
        public int ID_Usuario { get; set; }
        public string Descripcion { get; set; }
        public bool terminada { get; set; }

        public override string ToString()
        {
            return $"{Descripcion}";
        }
    }
}
