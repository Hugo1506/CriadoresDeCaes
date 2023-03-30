using System.ComponentModel.DataAnnotations.Schema;

namespace criadoresDeCaes.Models
{
    /// <summary>
    /// fotografia associada aos cães
    /// </summary>
    public class Fotografias
    {

        public int Id { get; set; }

        /// <summary>
        /// nome do documento com a fotografia do cão
        /// </summary>
        public string NomeFicheiro { get; set; }


        /// <summary>
        /// data em que a fotografia foi tirada
        /// </summary>
        public DateTime data { get; set; }


        /// <summary>
        /// local onde a fotografia foi tirada
        /// </summary>
        public string local { get; set; }


        [ForeignKey(nameof(Animal))] // foreignKey("Animal")
        public int AnimalFK { get; set; }
        public Animais Animal { get; set; }
    }
}
