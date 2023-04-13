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
            ListaCriadores = new HashSet<Criadores>();
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
        /// <summary>
        /// n-M
        /// Lista dos Criadores de uma determinada raça
        /// </summary>
        public ICollection<Criadores> ListaCriadores { get; set;}

    }
}
