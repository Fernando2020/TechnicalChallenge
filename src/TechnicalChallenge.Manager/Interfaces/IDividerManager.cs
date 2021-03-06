using TechnicalChallenge.Core.Dtos;
using TechnicalChallenge.Core.Entities;

namespace TechnicalChallenge.Manager.Interfaces
{
    public interface IDividerManager
    {
        DividerResponse GetDividersAndPrimeNumbers(Divider divider);
    }
}
