using Logistics.Services.Unleashed.Dtos;
using System.Text.Json;
using Xunit;

namespace Logistics.Tests
{
    public class UnleashedApiClientTests
    {
        [Fact]
        public void DeserialiseSalesOrderWithNullPaymentDueDateTest()
        {
            // Previously there was an issue encountered with deserializing null datetimes from Microsoft values.
            // This test has been added to ensure the issue doesn't creep back in.

            string jsonSalesOrder = @"{
                ""SalesOrderLines"": [],
                ""OrderNumber"": ""SO-00010863"",
                ""OrderDate"": ""/Date(1590620551321)/"",
                ""RequiredDate"": ""/Date(1590620551321)/"",
                ""CompletedDate"": null,
                ""OrderStatus"": ""Parked"",
                ""Customer"": {
                    ""CustomerCode"": ""XXXX"",
                    ""CustomerName"": ""Some Company Ltd"",
                    ""CurrencyId"": 110,
                    ""Guid"": ""00877ec7-aaaa-4d6f-ab83-be43056cf298"",
                    ""LastModifiedOn"": ""/Date(1589407497756)/""
                },
                ""CustomerRef"": null,
                ""Comments"": null,
                ""Warehouse"": {
                    ""WarehouseCode"": ""MET"",
                    ""WarehouseName"": ""Method"",
                    ""IsDefault"": true,
                    ""StreetNo"": null,
                    ""AddressLine1"": null,
                    ""AddressLine2"": null,
                    ""Suburb"": null,
                    ""City"": null,
                    ""Region"": null,
                    ""Country"": null,
                    ""PostCode"": null,
                    ""PhoneNumber"": null,
                    ""FaxNumber"": null,
                    ""MobileNumber"": null,
                    ""DDINumber"": null,
                    ""ContactName"": null,
                    ""Obsolete"": false,
                    ""Guid"": ""3438e334-5844-4f3b-aaaa-0fa44066d2c8"",
                    ""LastModifiedOn"": ""/Date(1523319758253)/""
                },
                ""ReceivedDate"": null,
                ""DeliveryInstruction"": null,
                ""DeliveryName"": null,
                ""DeliveryStreetAddress"": null,
                ""DeliveryStreetAddress2"": null,
                ""DeliverySuburb"": null,
                ""DeliveryCity"": null,
                ""DeliveryRegion"": null,
                ""DeliveryCountry"": null,
                ""DeliveryPostCode"": null,
                ""Currency"": {
                    ""CurrencyCode"": ""NZD"",
                    ""Description"": ""New Zealand, Dollars"",
                    ""Guid"": ""30f018b8-aaaa-47e4-b3ef-c30d8970cae7"",
                    ""LastModifiedOn"": ""/Date(1519157995850)/""
                },
                ""ExchangeRate"": 1,
                ""DiscountRate"": 0,
                ""Tax"": {
                    ""TaxCode"": ""G.S.T."",
                    ""Description"": null,
                    ""TaxRate"": 0.15,
                    ""CanApplyToExpenses"": false,
                    ""CanApplyToRevenue"": false,
                    ""Obsolete"": false,
                    ""Guid"": ""00000000-0000-0000-0000-000000000000"",
                    ""LastModifiedOn"": null
                },
                ""TaxRate"": 0.15,
                ""XeroTaxCode"": ""G.S.T."",
                ""SubTotal"": 0,
                ""TaxTotal"": 0,
                ""Total"": 0,
                ""TotalVolume"": null,
                ""TotalWeight"": null,
                ""BCSubTotal"": 0,
                ""BCTaxTotal"": 0,
                ""BCTotal"": 0,
                ""PaymentDueDate"": null,
                ""AllocateProduct"": true,
                ""SalesOrderGroup"": null,
                ""DeliveryMethod"": null,
                ""SalesPerson"": null,
                ""SendAccountingJournalOnly"": false,
                ""SourceId"": null,
                ""CreatedBy"": ""test@test.co.nz"",
                ""CreatedOn"": ""/Date(1590620551341)/"",
                ""LastModifiedBy"": ""test@test.co.nz"",
                ""Guid"": ""17dfd9c5-f7e8-42b1-aaaa-1f3da229823b"",
                ""LastModifiedOn"": ""/Date(1590620551341)/""
            }";

            var order = JsonSerializer.Deserialize<SalesOrder>(jsonSalesOrder);

            Assert.NotNull(order);
            Assert.Null(order.PaymentDueDate);

            // Quick check to re-serialize process, to make sure we can go back and forth without issue

            string reSerialized = JsonSerializer.Serialize(order);

            Assert.NotNull(reSerialized);
        }
    }
}
