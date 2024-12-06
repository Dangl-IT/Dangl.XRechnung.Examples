using Dangl.XRechnung.Models;
using Dangl.XRechnung.Models.InvoiceElements;

namespace Dangl.XRechnung.Examples
{
    public static class XRechnungPrinter
    {
        public static void PrintInvoiceInformation(Invoice invoice)
        {
            if (invoice == null)
            {
                throw new ArgumentNullException(nameof(invoice));
            }

            if (invoice.Totals != null)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Totals:");
                Console.ResetColor();

                if (invoice.Totals.AlreadyPaidTotal != null)
                {
                    Console.WriteLine($"    Already paid total: {invoice.Totals.AlreadyPaidTotal}");
                }

                if (invoice.Totals.PayableRoundingAmount != null)
                {
                    Console.WriteLine($"    Payable rounding amount: {invoice.Totals.PayableRoundingAmount}");
                }

                if (invoice.Totals.TotalAfterDeductions != null)
                {
                    Console.WriteLine($"    Total after deductions: {invoice.Totals.TotalAfterDeductions}");
                }

                if (invoice.Totals.TotalAllowances != null)
                {
                    Console.WriteLine($"    Total allowances: {invoice.Totals.TotalAllowances}");
                }

                if (invoice.Totals.TotalCharges != null)
                {
                    Console.WriteLine($"    Total charges: {invoice.Totals.TotalCharges}");
                }

                if (invoice.Totals.TotalGross != null)
                {
                    Console.WriteLine($"    Total gross: {invoice.Totals.TotalGross}");
                }

                if (invoice.Totals.TotalNet != null)
                {
                    Console.WriteLine($"    Total net: {invoice.Totals.TotalNet}");
                }

                if (invoice.Totals.TotalToBePaid != null)
                {
                    Console.WriteLine($"    Total to be paid: {invoice.Totals.TotalToBePaid}");
                }

                if (invoice.Totals.TotalVatAmount != null)
                {
                    Console.WriteLine($"    Total vat amount: {invoice.Totals.TotalVatAmount}");
                }
            }

            if (invoice.Seller != null)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Seller information:");
                Console.ResetColor();

                if (invoice.Seller.Identifier != null)
                {
                    Console.WriteLine($"    Identifier: {invoice.Seller.Identifier}");
                }

                if (invoice.Seller.Name != null)
                {
                    Console.WriteLine($"    Name: {invoice.Seller.Name}");
                }

                if (invoice.Seller.RegistrationNumber != null)
                {
                    Console.WriteLine($"    Registration number: {invoice.Seller.RegistrationNumber}");
                }

                if (invoice.Seller.VatId != null)
                {
                    Console.WriteLine($"    Vat id: {invoice.Seller.VatId}");
                }

                if (invoice.Seller.TaxId != null)
                {
                    Console.WriteLine($"    Tax id: {invoice.Seller.TaxId}");
                }

                if (invoice.Seller.Email != null)
                {
                    Console.WriteLine($"    Email: {invoice.Seller.Email}");
                }

                if (invoice.Seller.ContactPersonName != null)
                {
                    Console.WriteLine($"    Contact person name: {invoice.Seller.ContactPersonName}");
                }

                if (invoice.Seller.ContactPersonPhone != null)
                {
                    Console.WriteLine($"    Contact person phone: {invoice.Seller.ContactPersonPhone}");
                }

                if (invoice.Seller.ContactPersonEmail != null)
                {
                    Console.WriteLine($"    Contact person email: {invoice.Seller.ContactPersonEmail}");
                }

                if (invoice.Seller.Address != null)
                {
                    Console.WriteLine($"    Address: {invoice.Seller.Address}");
                }

                if (invoice.Seller.City != null)
                {
                    Console.WriteLine($"    City: {invoice.Seller.City}");
                }

                if (invoice.Seller.ZipCode != null)
                {
                    Console.WriteLine($"    ZipCode: {invoice.Seller.ZipCode}");
                }

                if (invoice.Seller.CountryCode != null)
                {
                    Console.WriteLine($"    Country code: {invoice.Seller.CountryCode}");
                }

                if (invoice.Seller.State != null)
                {
                    Console.WriteLine($"    State: {invoice.Seller.State}");
                }

                if (invoice.Seller.AdditionalLegalInformation != null)
                {
                    Console.WriteLine($"    Additional legal information: {invoice.Seller.AdditionalLegalInformation}");
                }
            }

            PrintInvoiceLineItems(invoice.LineItems, 0);
        }

        private static void PrintInvoiceLineItems(List<InvoiceLineItem> lineItems, int indentationCount)
        {
            var indentation = string.Empty;
            for (int i = 0; i < indentationCount; i++)
            {
                indentation += "    ";
            }

            if (lineItems != null && lineItems.Count > 0)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(indentation + "Line items:");
                Console.ResetColor();

                foreach (var invoiceLineItem in lineItems)
                {
                    if (invoiceLineItem.Identifier != null)
                    {
                        Console.WriteLine(indentation + $"    Identifier: {invoiceLineItem.Identifier}");
                    }

                    if (invoiceLineItem.Note != null)
                    {
                        Console.WriteLine(indentation + $"    Note: {invoiceLineItem.Note}");
                    }

                    if (invoiceLineItem.ObjectIdentifier != null)
                    {
                        Console.WriteLine(indentation + $"    Object identifier: {invoiceLineItem.ObjectIdentifier}");
                    }

                    if (invoiceLineItem.Quantity != null)
                    {
                        Console.WriteLine(indentation + $"    Quantity: {invoiceLineItem.Quantity}");
                    }

                    if (invoiceLineItem.UnitCode != null)
                    {
                        Console.WriteLine(indentation + $"    Unit code: {invoiceLineItem.UnitCode}");
                    }

                    if (invoiceLineItem.NetAmount != null)
                    {
                        Console.WriteLine(indentation + $"    Net amount: {invoiceLineItem.NetAmount}");
                    }

                    if (invoiceLineItem.PurchaseOrderReference != null)
                    {
                        Console.WriteLine(indentation + $"    Purchase order reference: {invoiceLineItem.PurchaseOrderReference}");
                    }

                    if (invoiceLineItem.LineItemPeriod != null)
                    {
                        Console.WriteLine(indentation + $"    Line item period: {invoiceLineItem.LineItemPeriod.Start} - {invoiceLineItem.LineItemPeriod.End}");
                    }

                    if (invoiceLineItem.Allowances != null && invoiceLineItem.Allowances.Count > 0)
                    {
                        Console.WriteLine(indentation + "    Allowances:");

                        foreach (var lineItemAllowance in invoiceLineItem.Allowances)
                        {
                            if (lineItemAllowance.NetAmount != null)
                            {
                                Console.WriteLine(indentation + $"        Net amount: {lineItemAllowance.NetAmount}");
                            }

                            if (lineItemAllowance.RelativeAllowanceBaseAmount != null)
                            {
                                Console.WriteLine(indentation + $"        Relative allowance base amount: {lineItemAllowance.RelativeAllowanceBaseAmount}");
                            }

                            if (lineItemAllowance.RelativeAllowancePercentage != null)
                            {
                                Console.WriteLine(indentation + $"        Relative allowance percentage: {lineItemAllowance.RelativeAllowancePercentage}");
                            }

                            if (lineItemAllowance.Reason != null)
                            {
                                Console.WriteLine(indentation + $"        Reason: {lineItemAllowance.Reason}");
                            }

                            if (lineItemAllowance.ReasonCode != null)
                            {
                                Console.WriteLine(indentation + $"        Reason code: {lineItemAllowance.ReasonCode}");
                            }

                            Console.WriteLine(indentation + "        ------------------------------");
                        }
                    }

                    if (invoiceLineItem.Charges != null && invoiceLineItem.Charges.Count > 0)
                    {
                        Console.WriteLine(indentation + "    Charges:");

                        foreach (var lineItemCharge in invoiceLineItem.Charges)
                        {
                            if (lineItemCharge.NetAmount != null)
                            {
                                Console.WriteLine(indentation + $"        Net amount: {lineItemCharge.NetAmount}");
                            }

                            if (lineItemCharge.RelativeChargeBaseAmount != null)
                            {
                                Console.WriteLine(indentation + $"        Relative charge base amount: {lineItemCharge.RelativeChargeBaseAmount}");
                            }

                            if (lineItemCharge.RelativeChargePercentage != null)
                            {
                                Console.WriteLine(indentation + $"        Relative charge percentage: {lineItemCharge.RelativeChargePercentage}");
                            }

                            if (lineItemCharge.Reason != null)
                            {
                                Console.WriteLine(indentation + $"        Reason: {lineItemCharge.Reason}");
                            }

                            if (lineItemCharge.ReasonCode != null)
                            {
                                Console.WriteLine(indentation + $"        Reason code: {lineItemCharge.ReasonCode}");
                            }

                            Console.WriteLine(indentation + "        ------------------------------");
                        }
                    }

                    if (invoiceLineItem.PriceDetails != null)
                    {
                        Console.WriteLine(indentation + "    Price details:");

                        if (invoiceLineItem.PriceDetails.NetPrice != null)
                        {
                            Console.WriteLine(indentation + $"        Net price: {invoiceLineItem.PriceDetails.NetPrice}");
                        }

                        if (invoiceLineItem.PriceDetails.AbsoluteDiscountPerItem != null)
                        {
                            Console.WriteLine(indentation + $"        Absolute discount per item: {invoiceLineItem.PriceDetails.AbsoluteDiscountPerItem}");
                        }

                        if (invoiceLineItem.PriceDetails.GrossPrice != null)
                        {
                            Console.WriteLine(indentation + $"        Gross price: {invoiceLineItem.PriceDetails.GrossPrice}");
                        }

                        if (invoiceLineItem.PriceDetails.BaseQuantity != null)
                        {
                            Console.WriteLine(indentation + $"        Base quantity: {invoiceLineItem.PriceDetails.BaseQuantity}");
                        }

                        if (invoiceLineItem.PriceDetails.BaseQuantityUnitCode != null)
                        {
                            Console.WriteLine(indentation + $"        Base quantity unit code: {invoiceLineItem.PriceDetails.BaseQuantityUnitCode}");
                        }
                    }

                    if (invoiceLineItem.VatInformation != null && invoiceLineItem.VatInformation.Count > 0)
                    {
                        Console.WriteLine(indentation + "    VatInformation:");

                        foreach (var lineItemVatInformation in invoiceLineItem.VatInformation)
                        {
                            Console.WriteLine(indentation + $"        Vat category: {lineItemVatInformation.VatCategory}");

                            if (lineItemVatInformation.VatRate != null)
                            {
                                Console.WriteLine(indentation + $"        Vat rate: {lineItemVatInformation.VatRate}");
                            }

                            Console.WriteLine(indentation + "        ------------------------------");
                        }
                    }

                    if (invoiceLineItem.ItemInformation != null)
                    {
                        Console.WriteLine(indentation + "    Item information:");

                        if (invoiceLineItem.ItemInformation.Name != null)
                        {
                            Console.WriteLine(indentation + $"        Name: {invoiceLineItem.ItemInformation.Name}");
                        }

                        if (invoiceLineItem.ItemInformation.Description != null)
                        {
                            Console.WriteLine(indentation + $"        Description: {invoiceLineItem.ItemInformation.Description}");
                        }

                        if (invoiceLineItem.ItemInformation.SellerIdentifier != null)
                        {
                            Console.WriteLine(indentation + $"        Seller identifier: {invoiceLineItem.ItemInformation.SellerIdentifier}");
                        }

                        if (invoiceLineItem.ItemInformation.BuyerIdentifier != null)
                        {
                            Console.WriteLine(indentation + $"        Buyer identifier: {invoiceLineItem.ItemInformation.BuyerIdentifier}");
                        }

                        if (invoiceLineItem.ItemInformation.StandardIdentifier != null)
                        {
                            Console.WriteLine(indentation + $"        Standard identifier: {invoiceLineItem.ItemInformation.StandardIdentifier}");
                        }

                        if (invoiceLineItem.ItemInformation.StandardSchemeId != null)
                        {
                            Console.WriteLine(indentation + $"        Standard scheme id: {invoiceLineItem.ItemInformation.StandardSchemeId}");
                        }

                        if (invoiceLineItem.ItemInformation.ClassificationIdentifiers != null && invoiceLineItem.ItemInformation.ClassificationIdentifiers.Count > 0)
                        {
                            Console.WriteLine(indentation + "        Classification identifiers:");

                            foreach (var classificationIdentifier in invoiceLineItem.ItemInformation.ClassificationIdentifiers)
                            {
                                if (!string.IsNullOrWhiteSpace(classificationIdentifier))
                                {
                                    Console.WriteLine(indentation + $"            {classificationIdentifier}");
                                }

                                Console.WriteLine(indentation + "            ------------------------------");
                            }
                        }

                        if (invoiceLineItem.ItemInformation.CountryOfOrigin != null)
                        {
                            Console.WriteLine(indentation + $"        Country of origin: {invoiceLineItem.ItemInformation.CountryOfOrigin}");
                        }

                        if (invoiceLineItem.ItemInformation.Attributes != null && invoiceLineItem.ItemInformation.Attributes.Count > 0)
                        {
                            Console.WriteLine(indentation + "        Attributes:");

                            foreach (var attribute in invoiceLineItem.ItemInformation.Attributes)
                            {
                                if (attribute.Name != null)
                                {
                                    Console.WriteLine(indentation + $"            Name: {attribute.Name}");
                                }

                                if (attribute.Value != null)
                                {
                                    Console.WriteLine(indentation + $"            Value: {attribute.Value}");
                                }

                                Console.WriteLine(indentation + "            ------------------------------");
                            }
                        }
                    }

                    if (invoiceLineItem.SubItems != null)
                    {
                        PrintInvoiceLineItems(invoiceLineItem.SubItems, indentationCount++);
                    }

                    Console.WriteLine(indentation + "------------------------------");
                }
            }
        }
    }
}
