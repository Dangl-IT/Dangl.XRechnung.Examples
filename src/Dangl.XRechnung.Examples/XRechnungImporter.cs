﻿using Dangl.Data.Shared;
using Dangl.XRechnung.Models;

namespace Dangl.XRechnung.Examples
{
    public static class XRechnungImporter
    {
        public static async Task<RepositoryResult<Invoice>> ReadXRechnungAsync(Stream invoiceStream)
        {
            try
            {
                var invoice = await Reader.ReadXRechnungAsync(invoiceStream);
                return RepositoryResult<Invoice>.Success(invoice);
            }
            catch (Exception e)
            {
                return RepositoryResult<Invoice>.Fail(e.Message);
            }
        }
    }
}
