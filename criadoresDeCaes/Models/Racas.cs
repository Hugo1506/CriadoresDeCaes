namespace criadoresDeCaes.Models
{
    /// <summary>
    /// Designação das raças
    /// </summary>
    public class Racas
    {
        public Racas()
        {
            ListaAnimais= new HashSet<Animais>();
        }
        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Designação da raça
        /// </summary>
        public string nome { get; set;}
        /// <summary>
        /// lista dos animais que são de uma raça 
        /// </summary>
        public ICollection<Animais> ListaAnimais { get; set;}

    }
}
