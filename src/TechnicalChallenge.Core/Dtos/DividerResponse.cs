using System.Collections.Generic;

namespace TechnicalChallenge.Core.Dtos
{
    public class DividerResponse
    {
        public bool IsSuccess { get; set; }
        public string Error { get; set; }
        public List<long> Dividers { get; set; } = new List<long>();
        public List<long> PrimeNumbers { get; set; } = new List<long>();
    }
}
