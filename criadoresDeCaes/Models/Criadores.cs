namespace criadoresDeCaes.Models
{
    /// <summary>
    /// descrição dos criadores 
    /// </summary>
    public class Criadores
    {
        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///nome do criador
        /// </summary>
        public string Nome { get; set; }


        /// <summary>
        /// nome comercial do criador
        /// </summary>
        public string NomeCriador { get; set;}

        /// <summary>
        /// morada
        /// </summary>
        public string Morada { get; set; }

        /// <summary>
        /// código postal
        /// </summary>
        public string codPostal { get; set; }

        /// <summary>
        /// número de telemovel
        /// </summary>
        public string Telemovel { get; set; }

        /// <summary>
        /// endereço de Email
        /// </summary>
        public string Email { get; set; }
    }
}
