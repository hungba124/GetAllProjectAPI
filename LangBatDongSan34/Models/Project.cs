using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class Project
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? SeName { get; set; }

    public int ProjectTypeId { get; set; }

    public int? InvestorId { get; set; }

    public int? ProvinceId { get; set; }

    public int? DistrictId { get; set; }

    public int? CommuneId { get; set; }

    public string? Address { get; set; }

    public string? GoogleMapLink { get; set; }

    public string? Delivery { get; set; }

    public string? PriceText { get; set; }

    public string? Scale { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaTitle { get; set; }

    public string? DefaultPicture { get; set; }

    public string? DesignUrl { get; set; }

    public string? GroundUrl { get; set; }

    public string? LibraryImagesUrl { get; set; }

    public string? TimeLineTitle { get; set; }

    public string? TimeLineImagesUrl { get; set; }

    public string? VideoUrl { get; set; }

    public string? Hotline { get; set; }

    public string? Source { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public decimal? Price { get; set; }

    public string? Unit { get; set; }

    public string? Description { get; set; }

    public string? MetaDescription { get; set; }

    public string? Location { get; set; }

    public string? Insfrastructure { get; set; }

    public string? ImagesUrl { get; set; }

    public DateTime? TimeLineUpdatedOn { get; set; }

    public int StatusId { get; set; }

    public string? PaymentPlan { get; set; }

    public int NumberOfViews { get; set; }

    public int PostFb { get; set; }

    public int DisplayOrder { get; set; }

    public bool Published { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }

    public bool Deleted { get; set; }

    public virtual Investor? Investor { get; set; }

    public virtual ICollection<ProjectPictureMapping> ProjectPictureMappings { get; set; } = new List<ProjectPictureMapping>();

    public virtual ProjectType ProjectType { get; set; } = null!;

    public virtual Province? Province { get; set; }
}
