using CommandLine.Text;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Dangl.XRechnung.Examples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var optionsParser = new OptionsParser(args);
            if (optionsParser.IsValid)
            {
                Console.WriteLine(HeadingInfo.Default);
                Console.WriteLine(CopyrightInfo.Default);
                try
                {
                    var filePath = Path.GetFullPath(optionsParser.Result.InputFilePath);
                    using (var fileStream = File.OpenRead(filePath))
                    {
                        var validationResult = await XRechnungValidator.ValidateXRechnungFileAsync(fileStream);
                        fileStream.Position = 0;
                        if (validationResult.IsSuccess)
                        {
                            var invoiceResult = await XRechnungImporter.ReadXRechnungAsync(fileStream);
                            if (!invoiceResult.IsSuccess)
                            {
                                Console.WriteLine("During file reading next error was occurred:");
                                Console.WriteLine(invoiceResult.ErrorMessage);
                            }
                            else
                            {
                                XRechnungPrinter.PrintInvoiceInformation(invoiceResult.Value);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    DisplayExceptionDetails(e);
                }
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void DisplayExceptionDetails(Exception e)
        {
            Console.Write(e.ToString());
            Console.WriteLine();
        }
    }
}
