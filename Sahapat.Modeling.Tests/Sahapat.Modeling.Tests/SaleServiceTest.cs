using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sahapat.Modeling.Tests
{
    [TestClass]
    public class SaleServiceTest
    {
        // SaleService
        // -> GetSaleOrderByOrderCode
        [TestMethod]
        public void GetSaleOrderByOrderCode(string orderCode)
        {

        }
    }

    public class SaleOrderDTO
    {
        public string OrderCode { get; set; }
        public DateTime OrderDate { get; set; }

        public CustomerDTO Customer { get; set; }
        public SaleDTO Sale { get; set; }
        public CustomerDTO BillTo { get; set; }

        public ProductDTO Product { get; set; }
    }

    public class ProductDTO
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UnitDescription { get; set; }

        public double Price { get; set; }
    }

    public class CustomerDTO
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public PostalAddressDTO ContactAddress { get; set; }
        public string ContactPhone { get; set; }
    }

    public class SaleDTO
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string ContactPhone { get; set; }
    }

    public class PostalAddressDTO
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }
        public string Khet { get; set; }
        public string Province { get; set; }
        public string PostCode { get; set; }
    }
}
