using Dangl.Data.Shared;
using Dangl.XRechnung.Validation;

namespace Dangl.XRechnung.Examples
{
    public static class XRechnungValidator
    {
        public static async Task<RepositoryResult> ValidateXRechnungFileAsync(Stream invoiceStream)
        {
            var result = await XRechnungSchemaValidator.ValidateXRechnungFileAsync(invoiceStream);
            if (result != null && result.IsSchemaCompliant)
            {
                return RepositoryResult.Success();
            }
            else
            {
                Console.WriteLine("Validation of the file found the following errors:");

                foreach (var error in result.Errors)
                {
                    Console.WriteLine($"Id: {error.Id}. Error message: {error.ErrorMessage}. LineNumber: {error.LineNumber}. LinePosition: {error.LinePosition}.");
                }

                return RepositoryResult.Fail();
            }
        }
    }
}
