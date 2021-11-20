using System.Collections.Generic;

namespace TechnicalChallenge.Core.Dtos
{
    /// <summary>
    /// Objeto responsável pelo retorno das listas de divisores e números primos dos divisores.
    /// </summary>
    public class DividerResponse
    {
        /// <summary>
        /// Sucesso da operação.
        /// </summary>
        /// <example>true</example>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// Menssagem de erro se houver.
        /// </summary>
        public string Error { get; set; }
        /// <summary>
        /// Lista de divisores.
        /// </summary>
        public List<long> Dividers { get; set; } = new List<long>();
        /// <summary>
        /// Lista de números primos da lista de divisores.
        /// </summary>
        public List<long> PrimeNumbers { get; set; } = new List<long>();
    }
}
