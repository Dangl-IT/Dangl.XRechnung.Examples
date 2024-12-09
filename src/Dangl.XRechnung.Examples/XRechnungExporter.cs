using Dangl.XRechnung.Models;
using System.IO;

namespace Dangl.XRechnung.Examples
{
    public static class XRechnungExporter
    {
        public static MemoryStream ExportInvoiceToStream()
        {
            var invoice = new Invoice
            {
                InvoiceNumber = "InvoiceNumber"
            };

            var export = XRechnungWriter.GetStream(invoice);
            return export;
        }
    }
}
