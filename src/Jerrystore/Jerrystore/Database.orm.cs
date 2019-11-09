
namespace Jerrystore.Database
{
	using global::System;
	using global::Jerrycurl.Data.Metadata.Annotations;
	using global::Jerrycurl.Mvc.Metadata.Annotations;
	
	[Table("dbo", "Customer")]
	public class Customer	
	{
		[Id, Key("PK_Customer", 1)]
		public int Id { get; set; }
		[Ref("PK_CustomerAddress", 1, "FK_Customer_CustomerAddress")]
		public int? AddressId { get; set; }
		public DateTime CreatedDate { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Name { get; set; }
	}
	
	[Table("dbo", "CustomerAddress")]
	public class CustomerAddress	
	{
		[Id, Key("PK_CustomerAddress", 1)]
		public int Id { get; set; }
		public string Street { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
	}
	
	[Table("dbo", "Order")]
	public class Order	
	{
		[Id, Key("PK_Order", 1)]
		public int Id { get; set; }
		[Ref("PK_Customer", 1, "FK_Order_Customer")]
		public int CustomerId { get; set; }
		[Ref("PK_CustomerAddress", 1, "FK_Order_CustomerAddress")]
		public int AddressId { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime? CompletedDate { get; set; }
	}
	
	[Table("dbo", "OrderLine")]
	public class OrderLine	
	{
		[Id, Key("PK_OrderLine", 1)]
		public int Id { get; set; }
		[Ref("PK_Order", 1, "FK_OrderLine_Order")]
		public int OrderId { get; set; }
		[Ref("PK_Product", 1, "FK_OrderLine_Product")]
		public int ProductId { get; set; }
		public int Units { get; set; }
	}
	
	[Table("dbo", "Product")]
	public class Product	
	{
		[Id, Key("PK_Product", 1)]
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
	}
	
}
