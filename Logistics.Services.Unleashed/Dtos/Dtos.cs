using System;
using System.Text.Json.Serialization;

/// <remarks>
/// Generated using Visual Studio's "Edit > Paste Special > Paste JSON As Classes"
/// </remarks>
namespace Logistics.Services.Unleashed.Dtos
{
    public class SalesOrdersResults
    {
        public Pagination Pagination { get; set; }
        public SalesOrder[] Items { get; set; }
    }

    public class Pagination
    {
        public int NumberOfItems { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public int NumberOfPages { get; set; }
    }

    public class SalesOrder
    {
        public SalesOrderLine[] SalesOrderLines { get; set; }
        public string OrderNumber { get; set; }
        [JsonConverter(typeof(JsonMicrosoftDateTimeConverter))]
        public DateTime OrderDate { get; set; }
        [JsonConverter(typeof(JsonMicrosoftDateTimeConverter))]
        public DateTime RequiredDate { get; set; }
        public object CompletedDate { get; set; }
        public string OrderStatus { get; set; }
        public Customer Customer { get; set; }
        public string CustomerRef { get; set; }
        public string Comments { get; set; }
        public Warehouse Warehouse { get; set; }
        public object ReceivedDate { get; set; }
        public object DeliveryInstruction { get; set; }
        public string DeliveryName { get; set; }
        public string DeliveryStreetAddress { get; set; }
        public string DeliveryStreetAddress2 { get; set; }
        public string DeliverySuburb { get; set; }
        public string DeliveryCity { get; set; }
        public object DeliveryRegion { get; set; }
        public object DeliveryCountry { get; set; }
        public string DeliveryPostCode { get; set; }
        public Currency Currency { get; set; }
        public float ExchangeRate { get; set; }
        public float DiscountRate { get; set; }
        public Tax Tax { get; set; }
        public float TaxRate { get; set; }
        public string XeroTaxCode { get; set; }
        public float SubTotal { get; set; }
        public float TaxTotal { get; set; }
        public float Total { get; set; }
        public float? TotalVolume { get; set; }
        public float? TotalWeight { get; set; }
        public float BCSubTotal { get; set; }
        public float BCTaxTotal { get; set; }
        public float BCTotal { get; set; }
        [JsonConverter(typeof(JsonMicrosoftDateTimeConverter))]
        public DateTime? PaymentDueDate { get; set; }
        public bool AllocateProduct { get; set; }
        public string SalesOrderGroup { get; set; }
        public object DeliveryMethod { get; set; }
        public SalesPerson SalesPerson { get; set; }
        public bool SendAccountingJournalOnly { get; set; }
        public object SourceId { get; set; }
        public string CreatedBy { get; set; }
        [JsonConverter(typeof(JsonMicrosoftDateTimeConverter))]
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public string Guid { get; set; }
        [JsonConverter(typeof(JsonMicrosoftDateTimeConverter))]
        public DateTime LastModifiedOn { get; set; }
    }

    public class Customer
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public int CurrencyId { get; set; }
        public string Guid { get; set; }
        [JsonConverter(typeof(JsonMicrosoftDateTimeConverter))]
        public DateTime LastModifiedOn { get; set; }
    }

    public class Warehouse
    {
        public string WarehouseCode { get; set; }
        public string WarehouseName { get; set; }
        public bool IsDefault { get; set; }
        public object StreetNo { get; set; }
        public object AddressLine1 { get; set; }
        public object AddressLine2 { get; set; }
        public object Suburb { get; set; }
        public object City { get; set; }
        public object Region { get; set; }
        public object Country { get; set; }
        public object PostCode { get; set; }
        public object PhoneNumber { get; set; }
        public object FaxNumber { get; set; }
        public object MobileNumber { get; set; }
        public object DDINumber { get; set; }
        public object ContactName { get; set; }
        public bool Obsolete { get; set; }
        public string Guid { get; set; }
        [JsonConverter(typeof(JsonMicrosoftDateTimeConverter))]
        public DateTime LastModifiedOn { get; set; }
    }

    public class Currency
    {
        public string CurrencyCode { get; set; }
        public string Description { get; set; }
        public string Guid { get; set; }
        [JsonConverter(typeof(JsonMicrosoftDateTimeConverter))]
        public DateTime LastModifiedOn { get; set; }
    }

    public class Tax
    {
        public string TaxCode { get; set; }
        public object Description { get; set; }
        public float TaxRate { get; set; }
        public bool CanApplyToExpenses { get; set; }
        public bool CanApplyToRevenue { get; set; }
        public bool Obsolete { get; set; }
        public string Guid { get; set; }
        public object LastModifiedOn { get; set; }
    }

    public class SalesPerson
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool Obsolete { get; set; }
        public string Guid { get; set; }
        [JsonConverter(typeof(JsonMicrosoftDateTimeConverter))]
        public DateTime LastModifiedOn { get; set; }
    }

    public class SalesOrderLine
    {
        public int LineNumber { get; set; }
        public object LineType { get; set; }
        public Product Product { get; set; }
        [JsonConverter(typeof(JsonMicrosoftDateTimeConverter))]
        public DateTime DueDate { get; set; }
        public float OrderQuantity { get; set; }
        public float UnitPrice { get; set; }
        public float DiscountRate { get; set; }
        public float LineTotal { get; set; }
        public object Volume { get; set; }
        public object Weight { get; set; }
        public string Comments { get; set; }
        public float AverageLandedPriceAtTimeOfSale { get; set; }
        public float TaxRate { get; set; }
        public float LineTax { get; set; }
        public string XeroTaxCode { get; set; }
        public float BCUnitPrice { get; set; }
        public float BCLineTotal { get; set; }
        public float BCLineTax { get; set; }
        public object LineTaxCode { get; set; }
        public string XeroSalesAccount { get; set; }
        public object SerialNumbers { get; set; }
        public object BatchNumbers { get; set; }
        public string Guid { get; set; }
        [JsonConverter(typeof(JsonMicrosoftDateTimeConverter))]
        public DateTime LastModifiedOn { get; set; }
    }

    public class Product
    {
        public string Guid { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
    }

}