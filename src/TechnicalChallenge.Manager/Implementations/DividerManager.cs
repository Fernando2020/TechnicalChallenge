using System;
using TechnicalChallenge.Core.Dtos;
using TechnicalChallenge.Core.Entities;
using TechnicalChallenge.Manager.Interfaces;
using TechnicalChallenge.Manager.Validators;
using TechnicalChallenge.Shared.Functions;

namespace TechnicalChallenge.Manager.Implementations
{
    public class DividerManager : IDividerManager
    {
        public DividerResponse GetDividersAndPrimeNumbers(Divider divider)
        {
            var dividerRespose = new DividerResponse();

            try
            {
                var dividerValidator = new DividerValidator();
                var validate = dividerValidator.Validate(divider);
                if (!validate.IsValid)
                {
                    dividerRespose.IsSuccess = false;
                    dividerRespose.Error = validate.Errors[0].ErrorMessage;
                    return dividerRespose;
                }

                for (var i = 1; i <= divider.Number; i++)
                {
                    if (MathFunctions.IsDivider(divider.Number, i))
                    {
                        dividerRespose.Dividers.Add(i);
                    }
                }

                for (var i = 0; i < dividerRespose.Dividers.Count; i++)
                {
                    if (MathFunctions.IsPrimeNumber(dividerRespose.Dividers[i]))
                    {
                        dividerRespose.PrimeNumbers.Add(dividerRespose.Dividers[i]);
                    }
                }

                dividerRespose.IsSuccess = true;
            }
            catch (Exception e)
            {
                dividerRespose.IsSuccess = false;
                dividerRespose.Error = e.Message;
            }

            return dividerRespose;
        }
    }
}
