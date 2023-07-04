using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? MetaKeywords { get; set; }

    public string? MetaTitle { get; set; }

    public string? MetaDescription { get; set; }

    public string? SeName { get; set; }

    public string? Address { get; set; }

    public double? Area { get; set; }

    public string? AreaText { get; set; }

    public string? PriceText { get; set; }

    public string? Unit { get; set; }

    public double? Facade { get; set; }

    public double? EntryWidth { get; set; }

    public int HouseDirectionId { get; set; }

    public int BalconyDirectionId { get; set; }

    public string? Furniture { get; set; }

    public string? Legal { get; set; }

    public string? DefaultPicture { get; set; }

    public string? ImagesUrl { get; set; }

    public string? VideoLink { get; set; }

    public string? GoogleMaps { get; set; }

    public string? ContactName { get; set; }

    public string? ContactAddress { get; set; }

    public string? ContactPhone { get; set; }

    public string? ContactMobile { get; set; }

    public string? ContactEmail { get; set; }

    public bool ContactReceiveEmail { get; set; }

    public int ProductTypeId { get; set; }

    public string? UnitPrice { get; set; }

    public string? CostText { get; set; }

    public string? VatText { get; set; }

    public decimal TotalCost { get; set; }

    public string? TotalCostText { get; set; }

    public string? Source { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public int CustomerId { get; set; }

    public int CategoryId { get; set; }

    public string? Description { get; set; }

    public string? AdminComment { get; set; }

    public int ProductTemplateId { get; set; }

    public int VendorId { get; set; }

    public bool ShowOnHomepage { get; set; }

    public int? ProvinceId { get; set; }

    public int? DistrictId { get; set; }

    public int? CommuneId { get; set; }

    public int? StreetId { get; set; }

    public int? ProjectId { get; set; }

    public decimal Price { get; set; }

    public int? NumberOfStoreys { get; set; }

    public int? NumberOfBedRooms { get; set; }

    public int? NumberOfToilets { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int? NumberOfDays { get; set; }

    public decimal? Cost { get; set; }

    public bool AllowCustomerReviews { get; set; }

    public int ApprovedRatingSum { get; set; }

    public int NotApprovedRatingSum { get; set; }

    public int ApprovedTotalReviews { get; set; }

    public int NotApprovedTotalReviews { get; set; }

    public bool SubjectToAcl { get; set; }

    public decimal OldPrice { get; set; }

    public decimal ProductCost { get; set; }

    public bool MarkAsNew { get; set; }

    public DateTime? MarkAsNewStartDateTime { get; set; }

    public DateTime? MarkAsNewEndDateTime { get; set; }

    public DateTime? AvailableStartDateTime { get; set; }

    public DateTime? AvailableEndDateTime { get; set; }

    public int NumberOfViews { get; set; }

    public int PostFb { get; set; }

    public bool HasRedBook { get; set; }

    public bool IsOwner { get; set; }

    public bool IsSold { get; set; }

    public int DisplayOrder { get; set; }

    public bool Published { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public bool Deleted { get; set; }

    public virtual ICollection<ProductCategoryMapping> ProductCategoryMappings { get; set; } = new List<ProductCategoryMapping>();

    public virtual ICollection<ProductManufacturerMapping> ProductManufacturerMappings { get; set; } = new List<ProductManufacturerMapping>();

    public virtual ICollection<ProductPictureMapping> ProductPictureMappings { get; set; } = new List<ProductPictureMapping>();

    public virtual ICollection<ProductReview> ProductReviews { get; set; } = new List<ProductReview>();

    public virtual ProductType ProductType { get; set; } = null!;

    public virtual ICollection<ShoppingCartItem> ShoppingCartItems { get; set; } = new List<ShoppingCartItem>();

    public virtual ICollection<ProductTag> ProductTags { get; set; } = new List<ProductTag>();
}
