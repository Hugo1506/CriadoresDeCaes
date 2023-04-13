using System.ComponentModel.DataAnnotations.Schema;

namespace criadoresDeCaes.Models
{
    /// <summary>
    /// descrição dos animais
    /// </summary>
    public class Animais
    {

        public Animais()
        {
            ListaFotografias = new HashSet<Fotografias>();
        }
        public int Id { get; set; }


        /// <summary>
        /// nome do animal
        /// </summary>
        public string Nome { get; set; }


        /// <summary>
        /// data de nascimento do animal
        /// </summary>
        public DateTime DataNascimento { get; set; }


        /// <summary>
        /// data da compra do animal
        /// </summary>
        public DateTime DataCompra { get; set; }  


        /// <summary>
        /// sexo do animal
        /// F - Fêmea
        /// M - Macho
        /// </summary>
        public string Sexo { get; set; }

        /// <summary>
        /// número de registo no LOP
        /// </summary>
        public int NumLOP { get; set;}

        //***********************************************************************

        /// <summary>
        /// lista das fototgrafias asociadas a um animal
        /// </summary>
        public ICollection<Fotografias> ListaFotografias { get; set; }

        [ForeignKey(nameof(RacaFK))]
        public int RacaFK { get; set; }
        public Racas Racas { get; set; }

        /// <summary>
        /// fk para o criador
        /// </summary>
        [ForeignKey(nameof(Criador))]
        public int CriadorFK { get; set; }  
        public Criadores Criador { get; set; }
    }
}
