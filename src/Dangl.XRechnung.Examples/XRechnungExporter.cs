using Dangl.XRechnung.Models;
using Dangl.XRechnung.Models.InvoiceElements;
using System;
using System.Collections.Generic;
using System.IO;

namespace Dangl.XRechnung.Examples
{
    public static class XRechnungExporter
    {
        public static MemoryStream ExportInvoiceToStream()
        {
            var invoice = new Invoice
            {
                InvoiceNumber = "1234567",
                Buyer = new Organization
                {
                    Identifier = "123",
                    Name = "BuyerName",
                    RegistrationNumber = "12345-12345",
                    VatId = "DE12345ABC",
                    TaxId = null,
                    Email = "sometestemail@test.de",
                    ContactPersonName = "BuyerContactPersonName",
                    ContactPersonPhone = "111-222-333",
                    ContactPersonEmail = "someanothertestemail@test.de",
                    Address = "Address st. 111",
                    City = "BuyerCity",
                    ZipCode = "098765",
                    CountryCode = "DE",
                    State = "BuyerState",
                    AdditionalLegalInformation = null
                },
                Seller = new Organization
                {
                    Identifier = "456",
                    Name = "SellerName",
                    RegistrationNumber = "67890-67890",
                    VatId = "EN67890DEF",
                    TaxId = null,
                    Email = "itstestemail@test.de",
                    ContactPersonName = "SellerContactPersonName",
                    ContactPersonPhone = "444-555-777",
                    ContactPersonEmail = "itsanothertestemail@test.de",
                    Address = "Address st. 222",
                    City = "SellerCity",
                    ZipCode = "1234567",
                    CountryCode = "EN",
                    State = "SellerState",
                    AdditionalLegalInformation = null
                },
                Totals = new InvoiceTotals
                {
                    TotalNet = 46723,
                    TotalAllowances = 0,
                    TotalCharges = 0,
                    TotalAfterDeductions = 46723,
                    TotalVatAmount = 1145,
                    TotalGross = 47868,
                    AlreadyPaidTotal = 0,
                    PayableRoundingAmount = null,
                    TotalToBePaid = 47868
                },
                LineItems = new List<InvoiceLineItem>
                {
                    new InvoiceLineItem
                    {
                        Identifier = "1",
                        Note = "NoteNoteNote",
                        ObjectIdentifier = "AAA987654321",
                        Quantity = 30,
                        UnitCode = "AAA",
                        NetAmount = 506070,
                        PurchaseOrderReference = "8754687",
                        LineItemPeriod = new Models.InvoiceElements.InvoicePeriod
                        {
                            Start = new DateTime(2024, 10, 15),
                            End = new DateTime(2024, 12, 25)
                        },
                        Allowances = new List<LineItemAllowance>
                        {
                            new LineItemAllowance
                            {
                                NetAmount = 0,
                                RelativeAllowanceBaseAmount = 0,
                                RelativeAllowancePercentage = 0,
                                Reason = "AllowanceReason",
                                ReasonCode = "111"
                            }
                        },
                        Charges = new List<LineItemCharge>
                        {
                            new LineItemCharge
                            {
                                NetAmount = 0,
                                RelativeChargeBaseAmount = 0,
                                RelativeChargePercentage = 0,
                                Reason = "ChargeReason",
                                ReasonCode = "222"
                            }
                        },
                        PriceDetails = new LineItemPriceDetail
                        {
                            NetPrice = 42342,
                            AbsoluteDiscountPerItem = 0,
                            GrossPrice = null,
                            BaseQuantity = null,
                            BaseQuantityUnitCode = null
                        },
                        VatInformation = new List<LineItemVatInformation>
                        {
                            new LineItemVatInformation
                            {
                                VatCategory = VatCategory.Unknown,
                                VatRate = 2
                            }
                        },
                        ItemInformation = new LineItemInformation
                        {
                            Name = "ItemInformationName",
                            Description = "ItemInformationDescription",
                            SellerIdentifier = "1234",
                            BuyerIdentifier = "5678",
                            StandardIdentifier = "5050",
                            StandardSchemeId = "4545",
                            ClassificationIdentifiers = new List<string>
                            {
                                "534796",
                                "907979"
                            },
                            CountryOfOrigin = "DE",
                            Attributes = new List<LineItemAttribute>
                            {
                                new LineItemAttribute
                                {
                                    Name = "AttributeName",
                                    Value = "AttributeValue"
                                }
                            }
                        },
                        SubItems = null
                    }
                }
            };

            var export = XRechnungWriter.GetStream(invoice);
            return export;
        }
    }
}
