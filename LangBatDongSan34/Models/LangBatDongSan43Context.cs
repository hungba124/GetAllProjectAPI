using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LangBatDongSan34.Models;

public partial class LangBatDongSan43Context : DbContext
{
    public LangBatDongSan43Context()
    {
    }

    public LangBatDongSan43Context(DbContextOptions<LangBatDongSan43Context> options)
        : base(options)
    {
    }

    public virtual DbSet<AclRecord> AclRecords { get; set; }

    public virtual DbSet<ActivityLog> ActivityLogs { get; set; }

    public virtual DbSet<ActivityLogType> ActivityLogTypes { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<AddressAttribute> AddressAttributes { get; set; }

    public virtual DbSet<AddressAttributeValue> AddressAttributeValues { get; set; }

    public virtual DbSet<Affiliate> Affiliates { get; set; }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<BlogComment> BlogComments { get; set; }

    public virtual DbSet<BlogPost> BlogPosts { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Broker> Brokers { get; set; }

    public virtual DbSet<Campaign> Campaigns { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CategoryTemplate> CategoryTemplates { get; set; }

    public virtual DbSet<Commune> Communes { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<CrossSellProduct> CrossSellProducts { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerAttribute> CustomerAttributes { get; set; }

    public virtual DbSet<CustomerAttributeValue> CustomerAttributeValues { get; set; }

    public virtual DbSet<CustomerPassword> CustomerPasswords { get; set; }

    public virtual DbSet<CustomerRole> CustomerRoles { get; set; }

    public virtual DbSet<District> Districts { get; set; }

    public virtual DbSet<Download> Downloads { get; set; }

    public virtual DbSet<EmailAccount> EmailAccounts { get; set; }

    public virtual DbSet<ExternalAuthenticationRecord> ExternalAuthenticationRecords { get; set; }

    public virtual DbSet<ForumsForum> ForumsForums { get; set; }

    public virtual DbSet<ForumsGroup> ForumsGroups { get; set; }

    public virtual DbSet<ForumsPost> ForumsPosts { get; set; }

    public virtual DbSet<ForumsPostVote> ForumsPostVotes { get; set; }

    public virtual DbSet<ForumsPrivateMessage> ForumsPrivateMessages { get; set; }

    public virtual DbSet<ForumsSubscription> ForumsSubscriptions { get; set; }

    public virtual DbSet<ForumsTopic> ForumsTopics { get; set; }

    public virtual DbSet<GdprConsent> GdprConsents { get; set; }

    public virtual DbSet<GdprLog> GdprLogs { get; set; }

    public virtual DbSet<GenericAttribute> GenericAttributes { get; set; }

    public virtual DbSet<Investor> Investors { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<LocaleStringResource> LocaleStringResources { get; set; }

    public virtual DbSet<LocalizedProperty> LocalizedProperties { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<ManufacturerTemplate> ManufacturerTemplates { get; set; }

    public virtual DbSet<MessageTemplate> MessageTemplates { get; set; }

    public virtual DbSet<MigrationVersionInfo> MigrationVersionInfos { get; set; }

    public virtual DbSet<News> News { get; set; }

    public virtual DbSet<NewsComment> NewsComments { get; set; }

    public virtual DbSet<NewsLetterSubscription> NewsLetterSubscriptions { get; set; }

    public virtual DbSet<NewsType> NewsTypes { get; set; }

    public virtual DbSet<PermissionRecord> PermissionRecords { get; set; }

    public virtual DbSet<Picture> Pictures { get; set; }

    public virtual DbSet<PictureBinary> PictureBinaries { get; set; }

    public virtual DbSet<Poll> Polls { get; set; }

    public virtual DbSet<PollAnswer> PollAnswers { get; set; }

    public virtual DbSet<PollVotingRecord> PollVotingRecords { get; set; }

    public virtual DbSet<PredefinedProductAttributeValue> PredefinedProductAttributeValues { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCategoryMapping> ProductCategoryMappings { get; set; }

    public virtual DbSet<ProductManufacturerMapping> ProductManufacturerMappings { get; set; }

    public virtual DbSet<ProductPictureMapping> ProductPictureMappings { get; set; }

    public virtual DbSet<ProductReview> ProductReviews { get; set; }

    public virtual DbSet<ProductReviewHelpfulness> ProductReviewHelpfulnesses { get; set; }

    public virtual DbSet<ProductReviewReviewTypeMapping> ProductReviewReviewTypeMappings { get; set; }

    public virtual DbSet<ProductTag> ProductTags { get; set; }

    public virtual DbSet<ProductTemplate> ProductTemplates { get; set; }

    public virtual DbSet<ProductType> ProductTypes { get; set; }

    public virtual DbSet<ProductWarehouseInventory> ProductWarehouseInventories { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<ProjectPictureMapping> ProjectPictureMappings { get; set; }

    public virtual DbSet<ProjectTimeline> ProjectTimelines { get; set; }

    public virtual DbSet<ProjectType> ProjectTypes { get; set; }

    public virtual DbSet<Province> Provinces { get; set; }

    public virtual DbSet<QueuedEmail> QueuedEmails { get; set; }

    public virtual DbSet<RelatedProduct> RelatedProducts { get; set; }

    public virtual DbSet<ReviewType> ReviewTypes { get; set; }

    public virtual DbSet<RewardPointsHistory> RewardPointsHistories { get; set; }

    public virtual DbSet<ScheduleTask> ScheduleTasks { get; set; }

    public virtual DbSet<SearchTerm> SearchTerms { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<Street> Streets { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    public virtual DbSet<TopicTemplate> TopicTemplates { get; set; }

    public virtual DbSet<TransactionBureau> TransactionBureaus { get; set; }

    public virtual DbSet<UrlRecord> UrlRecords { get; set; }

    public virtual DbSet<Vendor> Vendors { get; set; }

    public virtual DbSet<VendorAttribute> VendorAttributes { get; set; }

    public virtual DbSet<VendorAttributeValue> VendorAttributeValues { get; set; }

    public virtual DbSet<VendorNote> VendorNotes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=LangBatDongSan43;User=sa;Password=secret;Trusted_Connection=true;TrustServerCertificate=True;encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AclRecord>(entity =>
        {
            entity.ToTable("AclRecord");

            entity.HasIndex(e => e.CustomerRoleId, "IX_AclRecord_CustomerRoleId");

            entity.HasIndex(e => new { e.EntityId, e.EntityName }, "IX_AclRecord_EntityId_EntityName");

            entity.Property(e => e.EntityName).HasMaxLength(400);

            entity.HasOne(d => d.CustomerRole).WithMany(p => p.AclRecords)
                .HasForeignKey(d => d.CustomerRoleId)
                .HasConstraintName("FK_AclRecord_CustomerRoleId_CustomerRole_Id");
        });

        modelBuilder.Entity<ActivityLog>(entity =>
        {
            entity.ToTable("ActivityLog");

            entity.HasIndex(e => e.ActivityLogTypeId, "IX_ActivityLog_ActivityLogTypeId");

            entity.HasIndex(e => e.CreatedOn, "IX_ActivityLog_CreatedOn").IsDescending();

            entity.HasIndex(e => e.CustomerId, "IX_ActivityLog_CustomerId");

            entity.Property(e => e.EntityName).HasMaxLength(400);
            entity.Property(e => e.IpAddress).HasMaxLength(200);

            entity.HasOne(d => d.ActivityLogType).WithMany(p => p.ActivityLogs)
                .HasForeignKey(d => d.ActivityLogTypeId)
                .HasConstraintName("FK_ActivityLog_ActivityLogTypeId_ActivityLogType_Id");

            entity.HasOne(d => d.Customer).WithMany(p => p.ActivityLogs)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_ActivityLog_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<ActivityLogType>(entity =>
        {
            entity.ToTable("ActivityLogType");

            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.SystemKeyword).HasMaxLength(100);
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.ToTable("Address");

            entity.HasIndex(e => e.CountryId, "IX_Address_CountryId");

            entity.HasIndex(e => e.ProvinceId, "IX_Address_ProvinceId");

            entity.HasOne(d => d.Country).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_Address_CountryId_Country_Id");

            entity.HasOne(d => d.Province).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.ProvinceId)
                .HasConstraintName("FK_Address_ProvinceId_Province_Id");

            entity.HasMany(d => d.Customers).WithMany(p => p.Addresses)
                .UsingEntity<Dictionary<string, object>>(
                    "CustomerAddress",
                    r => r.HasOne<Customer>().WithMany()
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_CustomerAddresses_Customer_Id_Customer_Id"),
                    l => l.HasOne<Address>().WithMany()
                        .HasForeignKey("AddressId")
                        .HasConstraintName("FK_CustomerAddresses_Address_Id_Address_Id"),
                    j =>
                    {
                        j.HasKey("AddressId", "CustomerId");
                        j.ToTable("CustomerAddresses");
                        j.HasIndex(new[] { "AddressId" }, "IX_CustomerAddresses_Address_Id");
                        j.HasIndex(new[] { "CustomerId" }, "IX_CustomerAddresses_Customer_Id");
                        j.IndexerProperty<int>("AddressId").HasColumnName("Address_Id");
                        j.IndexerProperty<int>("CustomerId").HasColumnName("Customer_Id");
                    });
        });

        modelBuilder.Entity<AddressAttribute>(entity =>
        {
            entity.ToTable("AddressAttribute");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<AddressAttributeValue>(entity =>
        {
            entity.ToTable("AddressAttributeValue");

            entity.HasIndex(e => e.AddressAttributeId, "IX_AddressAttributeValue_AddressAttributeId");

            entity.Property(e => e.Name).HasMaxLength(400);

            entity.HasOne(d => d.AddressAttribute).WithMany(p => p.AddressAttributeValues)
                .HasForeignKey(d => d.AddressAttributeId)
                .HasConstraintName("FK_AddressAttributeValue_AddressAttributeId_AddressAttribute_Id");
        });

        modelBuilder.Entity<Affiliate>(entity =>
        {
            entity.ToTable("Affiliate");

            entity.HasIndex(e => e.AddressId, "IX_Affiliate_AddressId");

            entity.HasOne(d => d.Address).WithMany(p => p.Affiliates)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Affiliate_AddressId_Address_Id");
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.ToTable("Bank");

            entity.Property(e => e.Abbreviation).HasMaxLength(30);
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.SeName).HasMaxLength(400);
            entity.Property(e => e.WebRecruit).HasMaxLength(200);
            entity.Property(e => e.Website).HasMaxLength(200);
        });

        modelBuilder.Entity<BlogComment>(entity =>
        {
            entity.ToTable("BlogComment");

            entity.HasIndex(e => e.BlogPostId, "IX_BlogComment_BlogPostId");

            entity.HasIndex(e => e.CustomerId, "IX_BlogComment_CustomerId");

            entity.HasOne(d => d.BlogPost).WithMany(p => p.BlogComments)
                .HasForeignKey(d => d.BlogPostId)
                .HasConstraintName("FK_BlogComment_BlogPostId_BlogPost_Id");

            entity.HasOne(d => d.Customer).WithMany(p => p.BlogComments)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_BlogComment_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<BlogPost>(entity =>
        {
            entity.ToTable("BlogPost");

            entity.HasIndex(e => e.LanguageId, "IX_BlogPost_LanguageId");

            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);

            entity.HasOne(d => d.Language).WithMany(p => p.BlogPosts)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_BlogPost_LanguageId_Language_Id");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.ToTable("Branch");

            entity.Property(e => e.Abbreviation).HasMaxLength(30);
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.SeName).HasMaxLength(400);
        });

        modelBuilder.Entity<Broker>(entity =>
        {
            entity.ToTable("Broker");

            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.CreatedBy).HasMaxLength(200);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FullName).HasMaxLength(200);
            entity.Property(e => e.MobilePhone).HasMaxLength(20);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.UpdatedBy).HasMaxLength(200);
            entity.Property(e => e.WebSite).HasMaxLength(200);
        });

        modelBuilder.Entity<Campaign>(entity =>
        {
            entity.ToTable("Campaign");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category");

            entity.HasIndex(e => e.Deleted, "IX_Category_Deleted_Extended");

            entity.HasIndex(e => e.DisplayOrder, "IX_Category_DisplayOrder");

            entity.HasIndex(e => e.ParentCategoryId, "IX_Category_ParentCategoryId");

            entity.Property(e => e.MetaDescription).HasMaxLength(1000);
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PageSizeOptions).HasMaxLength(200);
            entity.Property(e => e.PriceRanges).HasMaxLength(400);
            entity.Property(e => e.SeName).HasMaxLength(400);
        });

        modelBuilder.Entity<CategoryTemplate>(entity =>
        {
            entity.ToTable("CategoryTemplate");

            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.ViewPath).HasMaxLength(400);
        });

        modelBuilder.Entity<Commune>(entity =>
        {
            entity.ToTable("Commune");

            entity.HasIndex(e => e.DistrictId, "IX_Commune_DistrictId");

            entity.Property(e => e.Abbreviation).HasMaxLength(20);
            entity.Property(e => e.GoogleMaps).HasMaxLength(500);
            entity.Property(e => e.Location).HasMaxLength(250);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.SeName).HasMaxLength(100);

            entity.HasOne(d => d.District).WithMany(p => p.Communes)
                .HasForeignKey(d => d.DistrictId)
                .HasConstraintName("FK_Commune_DistrictId_District_Id");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country");

            entity.HasIndex(e => e.DisplayOrder, "IX_Country_DisplayOrder");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.ThreeLetterIsoCode).HasMaxLength(3);
            entity.Property(e => e.TwoLetterIsoCode).HasMaxLength(2);
        });

        modelBuilder.Entity<CrossSellProduct>(entity =>
        {
            entity.ToTable("CrossSellProduct");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.ToTable("Currency");

            entity.HasIndex(e => e.DisplayOrder, "IX_Currency_DisplayOrder");

            entity.Property(e => e.CurrencyCode).HasMaxLength(5);
            entity.Property(e => e.CustomFormatting).HasMaxLength(50);
            entity.Property(e => e.DisplayLocale).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.HasIndex(e => e.BillingAddressId, "IX_Customer_BillingAddress_Id");

            entity.HasIndex(e => e.CreatedOn, "IX_Customer_CreatedOn").IsDescending();

            entity.HasIndex(e => e.CustomerGuid, "IX_Customer_CustomerGuid");

            entity.HasIndex(e => e.Email, "IX_Customer_Email");

            entity.HasIndex(e => e.ShippingAddressId, "IX_Customer_ShippingAddress_Id");

            entity.HasIndex(e => e.SystemName, "IX_Customer_SystemName");

            entity.HasIndex(e => e.Username, "IX_Customer_Username");

            entity.Property(e => e.BalanceAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BillingAddressId).HasColumnName("BillingAddress_Id");
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.EmailToRevalidate).HasMaxLength(500);
            entity.Property(e => e.PromotionAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ShippingAddressId).HasColumnName("ShippingAddress_Id");
            entity.Property(e => e.SystemName).HasMaxLength(200);
            entity.Property(e => e.TransferCode).HasMaxLength(20);
            entity.Property(e => e.Username).HasMaxLength(500);

            entity.HasOne(d => d.BillingAddress).WithMany(p => p.CustomerBillingAddresses)
                .HasForeignKey(d => d.BillingAddressId)
                .HasConstraintName("FK_Customer_BillingAddress_Id_Address_Id");

            entity.HasOne(d => d.ShippingAddress).WithMany(p => p.CustomerShippingAddresses)
                .HasForeignKey(d => d.ShippingAddressId)
                .HasConstraintName("FK_Customer_ShippingAddress_Id_Address_Id");

            entity.HasMany(d => d.CustomerRoles).WithMany(p => p.Customers)
                .UsingEntity<Dictionary<string, object>>(
                    "CustomerCustomerRoleMapping",
                    r => r.HasOne<CustomerRole>().WithMany()
                        .HasForeignKey("CustomerRoleId")
                        .HasConstraintName("FK_Customer_CustomerRole_Mapping_CustomerRole_Id_CustomerRole_Id"),
                    l => l.HasOne<Customer>().WithMany()
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Customer_CustomerRole_Mapping_Customer_Id_Customer_Id"),
                    j =>
                    {
                        j.HasKey("CustomerId", "CustomerRoleId");
                        j.ToTable("Customer_CustomerRole_Mapping");
                        j.HasIndex(new[] { "CustomerRoleId" }, "IX_Customer_CustomerRole_Mapping_CustomerRole_Id");
                        j.HasIndex(new[] { "CustomerId" }, "IX_Customer_CustomerRole_Mapping_Customer_Id");
                        j.IndexerProperty<int>("CustomerId").HasColumnName("Customer_Id");
                        j.IndexerProperty<int>("CustomerRoleId").HasColumnName("CustomerRole_Id");
                    });
        });

        modelBuilder.Entity<CustomerAttribute>(entity =>
        {
            entity.ToTable("CustomerAttribute");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<CustomerAttributeValue>(entity =>
        {
            entity.ToTable("CustomerAttributeValue");

            entity.HasIndex(e => e.CustomerAttributeId, "IX_CustomerAttributeValue_CustomerAttributeId");

            entity.Property(e => e.Name).HasMaxLength(400);

            entity.HasOne(d => d.CustomerAttribute).WithMany(p => p.CustomerAttributeValues)
                .HasForeignKey(d => d.CustomerAttributeId)
                .HasConstraintName("FK_CustomerAttributeValue_CustomerAttributeId_CustomerAttribute_Id");
        });

        modelBuilder.Entity<CustomerPassword>(entity =>
        {
            entity.ToTable("CustomerPassword");

            entity.HasIndex(e => e.CustomerId, "IX_CustomerPassword_CustomerId");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerPasswords)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_CustomerPassword_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<CustomerRole>(entity =>
        {
            entity.ToTable("CustomerRole");

            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.SystemName).HasMaxLength(255);
        });

        modelBuilder.Entity<District>(entity =>
        {
            entity.ToTable("District");

            entity.HasIndex(e => e.ProvinceId, "IX_District_ProvinceId");

            entity.Property(e => e.Abbreviation).HasMaxLength(20);
            entity.Property(e => e.GoogleMaps).HasMaxLength(500);
            entity.Property(e => e.Location).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.SeName).HasMaxLength(100);

            entity.HasOne(d => d.Province).WithMany(p => p.Districts)
                .HasForeignKey(d => d.ProvinceId)
                .HasConstraintName("FK_District_ProvinceId_Province_Id");
        });

        modelBuilder.Entity<Download>(entity =>
        {
            entity.ToTable("Download");
        });

        modelBuilder.Entity<EmailAccount>(entity =>
        {
            entity.ToTable("EmailAccount");

            entity.Property(e => e.DisplayName).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Host).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Username).HasMaxLength(255);
        });

        modelBuilder.Entity<ExternalAuthenticationRecord>(entity =>
        {
            entity.ToTable("ExternalAuthenticationRecord");

            entity.HasIndex(e => e.CustomerId, "IX_ExternalAuthenticationRecord_CustomerId");

            entity.Property(e => e.OauthAccessToken).HasColumnName("OAuthAccessToken");
            entity.Property(e => e.OauthToken).HasColumnName("OAuthToken");

            entity.HasOne(d => d.Customer).WithMany(p => p.ExternalAuthenticationRecords)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_ExternalAuthenticationRecord_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<ForumsForum>(entity =>
        {
            entity.ToTable("Forums_Forum");

            entity.HasIndex(e => e.DisplayOrder, "IX_Forums_Forum_DisplayOrder");

            entity.HasIndex(e => e.ForumGroupId, "IX_Forums_Forum_ForumGroupId");

            entity.Property(e => e.Name).HasMaxLength(200);

            entity.HasOne(d => d.ForumGroup).WithMany(p => p.ForumsForums)
                .HasForeignKey(d => d.ForumGroupId)
                .HasConstraintName("FK_Forums_Forum_ForumGroupId_Forums_Group_Id");
        });

        modelBuilder.Entity<ForumsGroup>(entity =>
        {
            entity.ToTable("Forums_Group");

            entity.HasIndex(e => e.DisplayOrder, "IX_Forums_Group_DisplayOrder");

            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<ForumsPost>(entity =>
        {
            entity.ToTable("Forums_Post");

            entity.HasIndex(e => e.CustomerId, "IX_Forums_Post_CustomerId");

            entity.HasIndex(e => e.TopicId, "IX_Forums_Post_TopicId");

            entity.Property(e => e.Ipaddress)
                .HasMaxLength(100)
                .HasColumnName("IPAddress");

            entity.HasOne(d => d.Customer).WithMany(p => p.ForumsPosts)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Forums_Post_CustomerId_Customer_Id");

            entity.HasOne(d => d.Topic).WithMany(p => p.ForumsPosts)
                .HasForeignKey(d => d.TopicId)
                .HasConstraintName("FK_Forums_Post_TopicId_Forums_Topic_Id");
        });

        modelBuilder.Entity<ForumsPostVote>(entity =>
        {
            entity.ToTable("Forums_PostVote");

            entity.HasIndex(e => e.ForumPostId, "IX_Forums_PostVote_ForumPostId");

            entity.HasOne(d => d.ForumPost).WithMany(p => p.ForumsPostVotes)
                .HasForeignKey(d => d.ForumPostId)
                .HasConstraintName("FK_Forums_PostVote_ForumPostId_Forums_Post_Id");
        });

        modelBuilder.Entity<ForumsPrivateMessage>(entity =>
        {
            entity.ToTable("Forums_PrivateMessage");

            entity.HasIndex(e => e.FromCustomerId, "IX_Forums_PrivateMessage_FromCustomerId");

            entity.HasIndex(e => e.ToCustomerId, "IX_Forums_PrivateMessage_ToCustomerId");

            entity.Property(e => e.Subject).HasMaxLength(450);

            entity.HasOne(d => d.FromCustomer).WithMany(p => p.ForumsPrivateMessageFromCustomers)
                .HasForeignKey(d => d.FromCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Forums_PrivateMessage_FromCustomerId_Customer_Id");

            entity.HasOne(d => d.ToCustomer).WithMany(p => p.ForumsPrivateMessageToCustomers)
                .HasForeignKey(d => d.ToCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Forums_PrivateMessage_ToCustomerId_Customer_Id");
        });

        modelBuilder.Entity<ForumsSubscription>(entity =>
        {
            entity.ToTable("Forums_Subscription");

            entity.HasIndex(e => e.CustomerId, "IX_Forums_Subscription_CustomerId");

            entity.HasIndex(e => e.ForumId, "IX_Forums_Subscription_ForumId");

            entity.HasIndex(e => e.TopicId, "IX_Forums_Subscription_TopicId");

            entity.HasOne(d => d.Customer).WithMany(p => p.ForumsSubscriptions)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Forums_Subscription_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<ForumsTopic>(entity =>
        {
            entity.ToTable("Forums_Topic");

            entity.HasIndex(e => e.CustomerId, "IX_Forums_Topic_CustomerId");

            entity.HasIndex(e => e.ForumId, "IX_Forums_Topic_ForumId");

            entity.Property(e => e.Subject).HasMaxLength(450);

            entity.HasOne(d => d.Customer).WithMany(p => p.ForumsTopics)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Forums_Topic_CustomerId_Customer_Id");

            entity.HasOne(d => d.Forum).WithMany(p => p.ForumsTopics)
                .HasForeignKey(d => d.ForumId)
                .HasConstraintName("FK_Forums_Topic_ForumId_Forums_Forum_Id");
        });

        modelBuilder.Entity<GdprConsent>(entity =>
        {
            entity.ToTable("GdprConsent");
        });

        modelBuilder.Entity<GdprLog>(entity =>
        {
            entity.ToTable("GdprLog");
        });

        modelBuilder.Entity<GenericAttribute>(entity =>
        {
            entity.ToTable("GenericAttribute");

            entity.HasIndex(e => new { e.EntityId, e.KeyGroup }, "IX_GenericAttribute_EntityId_and_KeyGroup");

            entity.Property(e => e.Key).HasMaxLength(400);
            entity.Property(e => e.KeyGroup).HasMaxLength(400);
        });

        modelBuilder.Entity<Investor>(entity =>
        {
            entity.ToTable("Investor");

            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.LogoUrl).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.PhoneNumber).HasMaxLength(30);
            entity.Property(e => e.Website).HasMaxLength(200);
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.ToTable("Language");

            entity.HasIndex(e => e.DisplayOrder, "IX_Language_DisplayOrder");

            entity.Property(e => e.FlagImageFileName).HasMaxLength(50);
            entity.Property(e => e.LanguageCulture).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.UniqueSeoCode).HasMaxLength(2);
        });

        modelBuilder.Entity<LocaleStringResource>(entity =>
        {
            entity.ToTable("LocaleStringResource");

            entity.HasIndex(e => new { e.ResourceName, e.LanguageId }, "IX_LocaleStringResource");

            entity.HasIndex(e => e.LanguageId, "IX_LocaleStringResource_LanguageId");

            entity.Property(e => e.ResourceName).HasMaxLength(200);

            entity.HasOne(d => d.Language).WithMany(p => p.LocaleStringResources)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_LocaleStringResource_LanguageId_Language_Id");
        });

        modelBuilder.Entity<LocalizedProperty>(entity =>
        {
            entity.ToTable("LocalizedProperty");

            entity.HasIndex(e => e.LanguageId, "IX_LocalizedProperty_LanguageId");

            entity.Property(e => e.LocaleKey).HasMaxLength(400);
            entity.Property(e => e.LocaleKeyGroup).HasMaxLength(400);

            entity.HasOne(d => d.Language).WithMany(p => p.LocalizedProperties)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_LocalizedProperty_LanguageId_Language_Id");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.ToTable("Log");

            entity.HasIndex(e => e.CreatedOn, "IX_Log_CreatedOn").IsDescending();

            entity.HasIndex(e => e.CustomerId, "IX_Log_CustomerId");

            entity.Property(e => e.IpAddress).HasMaxLength(200);

            entity.HasOne(d => d.Customer).WithMany(p => p.Logs)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Log_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.ToTable("Manufacturer");

            entity.HasIndex(e => e.DisplayOrder, "IX_Manufacturer_DisplayOrder");

            entity.HasIndex(e => e.SubjectToAcl, "IX_Manufacturer_SubjectToAcl");

            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PageSizeOptions).HasMaxLength(200);
            entity.Property(e => e.PriceRanges).HasMaxLength(400);
        });

        modelBuilder.Entity<ManufacturerTemplate>(entity =>
        {
            entity.ToTable("ManufacturerTemplate");

            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.ViewPath).HasMaxLength(400);
        });

        modelBuilder.Entity<MessageTemplate>(entity =>
        {
            entity.ToTable("MessageTemplate");

            entity.Property(e => e.BccEmailAddresses).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Subject).HasMaxLength(1000);
        });

        modelBuilder.Entity<MigrationVersionInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MigrationVersionInfo");

            entity.HasIndex(e => e.Version, "UC_Version")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.AppliedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1024);
        });

        modelBuilder.Entity<News>(entity =>
        {
            entity.HasIndex(e => e.LanguageId, "IX_News_LanguageId");

            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.SeName).HasMaxLength(400);

            entity.HasOne(d => d.Language).WithMany(p => p.News)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_News_LanguageId_Language_Id");
        });

        modelBuilder.Entity<NewsComment>(entity =>
        {
            entity.ToTable("NewsComment");

            entity.HasIndex(e => e.CustomerId, "IX_NewsComment_CustomerId");

            entity.HasIndex(e => e.NewsItemId, "IX_NewsComment_NewsItemId");

            entity.HasOne(d => d.Customer).WithMany(p => p.NewsComments)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_NewsComment_CustomerId_Customer_Id");

            entity.HasOne(d => d.NewsItem).WithMany(p => p.NewsComments)
                .HasForeignKey(d => d.NewsItemId)
                .HasConstraintName("FK_NewsComment_NewsItemId_News_Id");
        });

        modelBuilder.Entity<NewsLetterSubscription>(entity =>
        {
            entity.ToTable("NewsLetterSubscription");

            entity.HasIndex(e => e.Email, "IX_NewsletterSubscription_Email_StoreId");

            entity.Property(e => e.Email).HasMaxLength(255);
        });

        modelBuilder.Entity<NewsType>(entity =>
        {
            entity.ToTable("NewsType");

            entity.Property(e => e.MetaDescription).HasMaxLength(1000);
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PageSizeOptions).HasMaxLength(200);
            entity.Property(e => e.SeName).HasMaxLength(400);
        });

        modelBuilder.Entity<PermissionRecord>(entity =>
        {
            entity.ToTable("PermissionRecord");

            entity.Property(e => e.Category).HasMaxLength(255);
            entity.Property(e => e.SystemName).HasMaxLength(255);

            entity.HasMany(d => d.CustomerRoles).WithMany(p => p.PermissionRecords)
                .UsingEntity<Dictionary<string, object>>(
                    "PermissionRecordRoleMapping",
                    r => r.HasOne<CustomerRole>().WithMany()
                        .HasForeignKey("CustomerRoleId")
                        .HasConstraintName("FK_PermissionRecord_Role_Mapping_CustomerRole_Id_CustomerRole_Id"),
                    l => l.HasOne<PermissionRecord>().WithMany()
                        .HasForeignKey("PermissionRecordId")
                        .HasConstraintName("FK_PermissionRecord_Role_Mapping_PermissionRecord_Id_PermissionRecord_Id"),
                    j =>
                    {
                        j.HasKey("PermissionRecordId", "CustomerRoleId");
                        j.ToTable("PermissionRecord_Role_Mapping");
                        j.HasIndex(new[] { "CustomerRoleId" }, "IX_PermissionRecord_Role_Mapping_CustomerRole_Id");
                        j.HasIndex(new[] { "PermissionRecordId" }, "IX_PermissionRecord_Role_Mapping_PermissionRecord_Id");
                        j.IndexerProperty<int>("PermissionRecordId").HasColumnName("PermissionRecord_Id");
                        j.IndexerProperty<int>("CustomerRoleId").HasColumnName("CustomerRole_Id");
                    });
        });

        modelBuilder.Entity<Picture>(entity =>
        {
            entity.ToTable("Picture");

            entity.Property(e => e.AltAttribute).HasMaxLength(300);
            entity.Property(e => e.MimeType).HasMaxLength(40);
            entity.Property(e => e.SeoFilename).HasMaxLength(300);
            entity.Property(e => e.Source).HasMaxLength(500);
            entity.Property(e => e.TitleAttribute).HasMaxLength(300);
            entity.Property(e => e.VirtualPath).HasMaxLength(300);
        });

        modelBuilder.Entity<PictureBinary>(entity =>
        {
            entity.ToTable("PictureBinary");

            entity.HasIndex(e => e.PictureId, "IX_PictureBinary_PictureId");

            entity.HasOne(d => d.Picture).WithMany(p => p.PictureBinaries)
                .HasForeignKey(d => d.PictureId)
                .HasConstraintName("FK_PictureBinary_PictureId_Picture_Id");
        });

        modelBuilder.Entity<Poll>(entity =>
        {
            entity.ToTable("Poll");

            entity.HasIndex(e => e.LanguageId, "IX_Poll_LanguageId");

            entity.HasOne(d => d.Language).WithMany(p => p.Polls)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_Poll_LanguageId_Language_Id");
        });

        modelBuilder.Entity<PollAnswer>(entity =>
        {
            entity.ToTable("PollAnswer");

            entity.HasIndex(e => e.PollId, "IX_PollAnswer_PollId");

            entity.HasOne(d => d.Poll).WithMany(p => p.PollAnswers)
                .HasForeignKey(d => d.PollId)
                .HasConstraintName("FK_PollAnswer_PollId_Poll_Id");
        });

        modelBuilder.Entity<PollVotingRecord>(entity =>
        {
            entity.ToTable("PollVotingRecord");

            entity.HasIndex(e => e.CustomerId, "IX_PollVotingRecord_CustomerId");

            entity.HasIndex(e => e.PollAnswerId, "IX_PollVotingRecord_PollAnswerId");

            entity.HasOne(d => d.Customer).WithMany(p => p.PollVotingRecords)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_PollVotingRecord_CustomerId_Customer_Id");

            entity.HasOne(d => d.PollAnswer).WithMany(p => p.PollVotingRecords)
                .HasForeignKey(d => d.PollAnswerId)
                .HasConstraintName("FK_PollVotingRecord_PollAnswerId_PollAnswer_Id");
        });

        modelBuilder.Entity<PredefinedProductAttributeValue>(entity =>
        {
            entity.ToTable("PredefinedProductAttributeValue");

            entity.Property(e => e.Cost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.HasIndex(e => new { e.Deleted, e.VendorId, e.ProductTypeId }, "IX_GetLowStockProducts");

            entity.HasIndex(e => new { e.Deleted, e.Id }, "IX_Product_Delete_Id");

            entity.HasIndex(e => new { e.Published, e.Deleted }, "IX_Product_Deleted_and_Published");

            entity.HasIndex(e => new { e.Price, e.AvailableStartDateTime, e.AvailableEndDateTime, e.Published, e.Deleted }, "IX_Product_PriceDatesEtc");

            entity.HasIndex(e => e.ProductTypeId, "IX_Product_ProductTypeId");

            entity.HasIndex(e => e.Published, "IX_Product_Published");

            entity.HasIndex(e => new { e.Published, e.Deleted }, "IX_Product_Published_Deleted_Extended");

            entity.HasIndex(e => e.ShowOnHomepage, "IX_Product_ShowOnHomepage");

            entity.HasIndex(e => e.SubjectToAcl, "IX_Product_SubjectToAcl");

            entity.Property(e => e.Address).HasMaxLength(300);
            entity.Property(e => e.AreaText).HasMaxLength(50);
            entity.Property(e => e.ContactAddress).HasMaxLength(500);
            entity.Property(e => e.ContactEmail).HasMaxLength(200);
            entity.Property(e => e.ContactMobile).HasMaxLength(20);
            entity.Property(e => e.ContactName).HasMaxLength(200);
            entity.Property(e => e.ContactPhone).HasMaxLength(20);
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CostText).HasMaxLength(200);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DefaultPicture).HasMaxLength(200);
            entity.Property(e => e.Furniture).HasMaxLength(1000);
            entity.Property(e => e.GoogleMaps).HasMaxLength(250);
            entity.Property(e => e.ImagesUrl).HasMaxLength(2500);
            entity.Property(e => e.Legal).HasMaxLength(255);
            entity.Property(e => e.MetaDescription).HasMaxLength(500);
            entity.Property(e => e.MetaKeywords).HasMaxLength(200);
            entity.Property(e => e.MetaTitle).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceText).HasMaxLength(50);
            entity.Property(e => e.ProductCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SeName).HasMaxLength(200);
            entity.Property(e => e.Source).HasMaxLength(200);
            entity.Property(e => e.TotalCost).HasColumnType("decimal(19, 5)");
            entity.Property(e => e.TotalCostText).HasMaxLength(200);
            entity.Property(e => e.Unit).HasMaxLength(50);
            entity.Property(e => e.UnitPrice).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.VatText).HasMaxLength(200);
            entity.Property(e => e.VideoLink).HasMaxLength(250);

            entity.HasOne(d => d.ProductType).WithMany(p => p.Products)
                .HasForeignKey(d => d.ProductTypeId)
                .HasConstraintName("FK_Product_ProductTypeId_ProductType_Id");

            entity.HasMany(d => d.ProductTags).WithMany(p => p.Products)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductProductTagMapping",
                    r => r.HasOne<ProductTag>().WithMany()
                        .HasForeignKey("ProductTagId")
                        .HasConstraintName("FK_Product_ProductTag_Mapping_ProductTag_Id_ProductTag_Id"),
                    l => l.HasOne<Product>().WithMany()
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Product_ProductTag_Mapping_Product_Id_Product_Id"),
                    j =>
                    {
                        j.HasKey("ProductId", "ProductTagId");
                        j.ToTable("Product_ProductTag_Mapping");
                        j.HasIndex(new[] { "ProductTagId" }, "IX_Product_ProductTag_Mapping_ProductTag_Id");
                        j.HasIndex(new[] { "ProductId" }, "IX_Product_ProductTag_Mapping_Product_Id");
                        j.IndexerProperty<int>("ProductId").HasColumnName("Product_Id");
                        j.IndexerProperty<int>("ProductTagId").HasColumnName("ProductTag_Id");
                    });
        });

        modelBuilder.Entity<ProductCategoryMapping>(entity =>
        {
            entity.ToTable("Product_Category_Mapping");

            entity.HasIndex(e => new { e.ProductId, e.IsFeaturedProduct }, "IX_PCM_ProductId_Extended");

            entity.HasIndex(e => new { e.CategoryId, e.ProductId }, "IX_PCM_Product_and_Category");

            entity.HasIndex(e => e.CategoryId, "IX_Product_Category_Mapping_CategoryId");

            entity.HasIndex(e => e.IsFeaturedProduct, "IX_Product_Category_Mapping_IsFeaturedProduct");

            entity.HasIndex(e => e.ProductId, "IX_Product_Category_Mapping_ProductId");

            entity.HasOne(d => d.Category).WithMany(p => p.ProductCategoryMappings)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Product_Category_Mapping_CategoryId_Category_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductCategoryMappings)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_Product_Category_Mapping_ProductId_Product_Id");
        });

        modelBuilder.Entity<ProductManufacturerMapping>(entity =>
        {
            entity.ToTable("Product_Manufacturer_Mapping");

            entity.HasIndex(e => new { e.ProductId, e.IsFeaturedProduct }, "IX_PMM_ProductId_Extended");

            entity.HasIndex(e => new { e.ManufacturerId, e.ProductId }, "IX_PMM_Product_and_Manufacturer");

            entity.HasIndex(e => e.IsFeaturedProduct, "IX_Product_Manufacturer_Mapping_IsFeaturedProduct");

            entity.HasIndex(e => e.ManufacturerId, "IX_Product_Manufacturer_Mapping_ManufacturerId");

            entity.HasIndex(e => e.ProductId, "IX_Product_Manufacturer_Mapping_ProductId");

            entity.HasOne(d => d.Manufacturer).WithMany(p => p.ProductManufacturerMappings)
                .HasForeignKey(d => d.ManufacturerId)
                .HasConstraintName("FK_Product_Manufacturer_Mapping_ManufacturerId_Manufacturer_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductManufacturerMappings)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_Product_Manufacturer_Mapping_ProductId_Product_Id");
        });

        modelBuilder.Entity<ProductPictureMapping>(entity =>
        {
            entity.ToTable("Product_Picture_Mapping");

            entity.HasIndex(e => e.PictureId, "IX_Product_Picture_Mapping_PictureId");

            entity.HasIndex(e => e.ProductId, "IX_Product_Picture_Mapping_ProductId");

            entity.HasOne(d => d.Picture).WithMany(p => p.ProductPictureMappings)
                .HasForeignKey(d => d.PictureId)
                .HasConstraintName("FK_Product_Picture_Mapping_PictureId_Picture_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductPictureMappings)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_Product_Picture_Mapping_ProductId_Product_Id");
        });

        modelBuilder.Entity<ProductReview>(entity =>
        {
            entity.ToTable("ProductReview");

            entity.HasIndex(e => e.CustomerId, "IX_ProductReview_CustomerId");

            entity.HasIndex(e => e.ProductId, "IX_ProductReview_ProductId");

            entity.HasIndex(e => e.StoreId, "IX_ProductReview_StoreId");

            entity.HasOne(d => d.Customer).WithMany(p => p.ProductReviews)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_ProductReview_CustomerId_Customer_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductReviews)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ProductReview_ProductId_Product_Id");

            entity.HasOne(d => d.Store).WithMany(p => p.ProductReviews)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK_ProductReview_StoreId_Store_Id");
        });

        modelBuilder.Entity<ProductReviewHelpfulness>(entity =>
        {
            entity.ToTable("ProductReviewHelpfulness");

            entity.HasIndex(e => e.ProductReviewId, "IX_ProductReviewHelpfulness_ProductReviewId");

            entity.HasOne(d => d.ProductReview).WithMany(p => p.ProductReviewHelpfulnesses)
                .HasForeignKey(d => d.ProductReviewId)
                .HasConstraintName("FK_ProductReviewHelpfulness_ProductReviewId_ProductReview_Id");
        });

        modelBuilder.Entity<ProductReviewReviewTypeMapping>(entity =>
        {
            entity.ToTable("ProductReview_ReviewType_Mapping");

            entity.HasIndex(e => e.ProductReviewId, "IX_ProductReview_ReviewType_Mapping_ProductReviewId");

            entity.HasIndex(e => e.ReviewTypeId, "IX_ProductReview_ReviewType_Mapping_ReviewTypeId");

            entity.HasOne(d => d.ProductReview).WithMany(p => p.ProductReviewReviewTypeMappings)
                .HasForeignKey(d => d.ProductReviewId)
                .HasConstraintName("FK_ProductReview_ReviewType_Mapping_ProductReviewId_ProductReview_Id");

            entity.HasOne(d => d.ReviewType).WithMany(p => p.ProductReviewReviewTypeMappings)
                .HasForeignKey(d => d.ReviewTypeId)
                .HasConstraintName("FK_ProductReview_ReviewType_Mapping_ReviewTypeId_ReviewType_Id");
        });

        modelBuilder.Entity<ProductTag>(entity =>
        {
            entity.ToTable("ProductTag");

            entity.HasIndex(e => e.Name, "IX_ProductTag_Name");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<ProductTemplate>(entity =>
        {
            entity.ToTable("ProductTemplate");

            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.ViewPath).HasMaxLength(400);
        });

        modelBuilder.Entity<ProductType>(entity =>
        {
            entity.ToTable("ProductType");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PricePerDay).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<ProductWarehouseInventory>(entity =>
        {
            entity.ToTable("ProductWarehouseInventory");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.ToTable("Project");

            entity.HasIndex(e => e.InvestorId, "IX_Project_InvestorId");

            entity.HasIndex(e => e.ProjectTypeId, "IX_Project_ProjectTypeId");

            entity.HasIndex(e => e.ProvinceId, "IX_Project_ProvinceId");

            entity.Property(e => e.Address).HasMaxLength(400);
            entity.Property(e => e.CreatedBy).HasMaxLength(200);
            entity.Property(e => e.DefaultPicture).HasMaxLength(200);
            entity.Property(e => e.Delivery).HasMaxLength(50);
            entity.Property(e => e.DesignUrl).HasMaxLength(1000);
            entity.Property(e => e.GoogleMapLink).HasMaxLength(250);
            entity.Property(e => e.GroundUrl).HasMaxLength(1000);
            entity.Property(e => e.Hotline).HasMaxLength(20);
            entity.Property(e => e.LibraryImagesUrl).HasMaxLength(2000);
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceText).HasMaxLength(50);
            entity.Property(e => e.Scale).HasMaxLength(400);
            entity.Property(e => e.SeName).HasMaxLength(400);
            entity.Property(e => e.Source).HasMaxLength(200);
            entity.Property(e => e.TimeLineImagesUrl).HasMaxLength(2000);
            entity.Property(e => e.TimeLineTitle).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(200);
            entity.Property(e => e.VideoUrl).HasMaxLength(100);

            entity.HasOne(d => d.Investor).WithMany(p => p.Projects)
                .HasForeignKey(d => d.InvestorId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Project_InvestorId_Investor_Id");

            entity.HasOne(d => d.ProjectType).WithMany(p => p.Projects)
                .HasForeignKey(d => d.ProjectTypeId)
                .HasConstraintName("FK_Project_ProjectTypeId_ProjectType_Id");

            entity.HasOne(d => d.Province).WithMany(p => p.Projects)
                .HasForeignKey(d => d.ProvinceId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Project_ProvinceId_Province_Id");
        });

        modelBuilder.Entity<ProjectPictureMapping>(entity =>
        {
            entity.ToTable("Project_Picture_Mapping");

            entity.HasIndex(e => e.PictureId, "IX_Project_Picture_Mapping_PictureId");

            entity.HasIndex(e => e.ProjectId, "IX_Project_Picture_Mapping_ProjectId");

            entity.HasOne(d => d.Picture).WithMany(p => p.ProjectPictureMappings)
                .HasForeignKey(d => d.PictureId)
                .HasConstraintName("FK_Project_Picture_Mapping_PictureId_Picture_Id");

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectPictureMappings)
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("FK_Project_Picture_Mapping_ProjectId_Project_Id");
        });

        modelBuilder.Entity<ProjectTimeline>(entity =>
        {
            entity.ToTable("ProjectTimeline");
        });

        modelBuilder.Entity<ProjectType>(entity =>
        {
            entity.ToTable("ProjectType");

            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.SeName).HasMaxLength(400);
        });

        modelBuilder.Entity<Province>(entity =>
        {
            entity.ToTable("Province");

            entity.HasIndex(e => e.CountryId, "IX_Province_CountryId");

            entity.Property(e => e.Abbreviation).HasMaxLength(20);
            entity.Property(e => e.GoogleMaps).HasMaxLength(500);
            entity.Property(e => e.Location).HasMaxLength(250);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.SeName).HasMaxLength(100);

            entity.HasOne(d => d.Country).WithMany(p => p.Provinces)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_Province_CountryId_Country_Id");
        });

        modelBuilder.Entity<QueuedEmail>(entity =>
        {
            entity.ToTable("QueuedEmail");

            entity.HasIndex(e => e.CreatedOn, "IX_QueuedEmail_CreatedOn").IsDescending();

            entity.HasIndex(e => e.EmailAccountId, "IX_QueuedEmail_EmailAccountId");

            entity.HasIndex(e => new { e.SentOn, e.DontSendBeforeDate }, "IX_QueuedEmail_SentOn_DontSendBeforeDate_Extended");

            entity.Property(e => e.Bcc).HasMaxLength(500);
            entity.Property(e => e.Cc)
                .HasMaxLength(500)
                .HasColumnName("CC");
            entity.Property(e => e.From).HasMaxLength(500);
            entity.Property(e => e.FromName).HasMaxLength(500);
            entity.Property(e => e.ReplyTo).HasMaxLength(500);
            entity.Property(e => e.ReplyToName).HasMaxLength(500);
            entity.Property(e => e.Subject).HasMaxLength(1000);
            entity.Property(e => e.To).HasMaxLength(500);
            entity.Property(e => e.ToName).HasMaxLength(500);

            entity.HasOne(d => d.EmailAccount).WithMany(p => p.QueuedEmails)
                .HasForeignKey(d => d.EmailAccountId)
                .HasConstraintName("FK_QueuedEmail_EmailAccountId_EmailAccount_Id");
        });

        modelBuilder.Entity<RelatedProduct>(entity =>
        {
            entity.ToTable("RelatedProduct");

            entity.HasIndex(e => e.ProductId1, "IX_RelatedProduct_ProductId1");
        });

        modelBuilder.Entity<ReviewType>(entity =>
        {
            entity.ToTable("ReviewType");

            entity.Property(e => e.Description).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<RewardPointsHistory>(entity =>
        {
            entity.ToTable("RewardPointsHistory");

            entity.HasIndex(e => e.CustomerId, "IX_RewardPointsHistory_CustomerId");

            entity.Property(e => e.UsedAmount).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Customer).WithMany(p => p.RewardPointsHistories)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_RewardPointsHistory_CustomerId_Customer_Id");
        });

        modelBuilder.Entity<ScheduleTask>(entity =>
        {
            entity.ToTable("ScheduleTask");
        });

        modelBuilder.Entity<SearchTerm>(entity =>
        {
            entity.ToTable("SearchTerm");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.ToTable("Setting");

            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<ShoppingCartItem>(entity =>
        {
            entity.ToTable("ShoppingCartItem");

            entity.HasIndex(e => e.CustomerId, "IX_ShoppingCartItem_CustomerId");

            entity.HasIndex(e => e.ProductId, "IX_ShoppingCartItem_ProductId");

            entity.HasIndex(e => new { e.ShoppingCartTypeId, e.CustomerId }, "IX_ShoppingCartItem_ShoppingCartTypeId_CustomerId");

            entity.Property(e => e.CustomerEnteredPrice).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Customer).WithMany(p => p.ShoppingCartItems)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_ShoppingCartItem_CustomerId_Customer_Id");

            entity.HasOne(d => d.Product).WithMany(p => p.ShoppingCartItems)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ShoppingCartItem_ProductId_Product_Id");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.ToTable("Store");

            entity.Property(e => e.CompanyAddress).HasMaxLength(1000);
            entity.Property(e => e.CompanyName).HasMaxLength(1000);
            entity.Property(e => e.CompanyPhoneNumber).HasMaxLength(1000);
            entity.Property(e => e.CompanyVat).HasMaxLength(1000);
            entity.Property(e => e.Hosts).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.Url).HasMaxLength(400);
        });

        modelBuilder.Entity<Street>(entity =>
        {
            entity.ToTable("Street");

            entity.HasIndex(e => e.DistrictId, "IX_Street_DistrictId");

            entity.Property(e => e.Abbreviation).HasMaxLength(20);
            entity.Property(e => e.GoogleMaps).HasMaxLength(500);
            entity.Property(e => e.Location).HasMaxLength(250);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.SeName).HasMaxLength(100);

            entity.HasOne(d => d.District).WithMany(p => p.Streets)
                .HasForeignKey(d => d.DistrictId)
                .HasConstraintName("FK_Street_DistrictId_District_Id");
        });

        modelBuilder.Entity<Topic>(entity =>
        {
            entity.ToTable("Topic");
        });

        modelBuilder.Entity<TopicTemplate>(entity =>
        {
            entity.ToTable("TopicTemplate");

            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.ViewPath).HasMaxLength(400);
        });

        modelBuilder.Entity<TransactionBureau>(entity =>
        {
            entity.ToTable("TransactionBureau");

            entity.Property(e => e.Abbreviation).HasMaxLength(30);
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.SeName).HasMaxLength(400);
        });

        modelBuilder.Entity<UrlRecord>(entity =>
        {
            entity.ToTable("UrlRecord");

            entity.HasIndex(e => new { e.EntityId, e.EntityName, e.LanguageId, e.IsActive }, "IX_UrlRecord_Custom_1");

            entity.HasIndex(e => e.Slug, "IX_UrlRecord_Slug");

            entity.Property(e => e.EntityName).HasMaxLength(400);
            entity.Property(e => e.Slug).HasMaxLength(400);
        });

        modelBuilder.Entity<Vendor>(entity =>
        {
            entity.ToTable("Vendor");

            entity.Property(e => e.Email).HasMaxLength(400);
            entity.Property(e => e.MetaKeywords).HasMaxLength(400);
            entity.Property(e => e.MetaTitle).HasMaxLength(400);
            entity.Property(e => e.Name).HasMaxLength(400);
            entity.Property(e => e.PageSizeOptions).HasMaxLength(200);
        });

        modelBuilder.Entity<VendorAttribute>(entity =>
        {
            entity.ToTable("VendorAttribute");

            entity.Property(e => e.Name).HasMaxLength(400);
        });

        modelBuilder.Entity<VendorAttributeValue>(entity =>
        {
            entity.ToTable("VendorAttributeValue");

            entity.HasIndex(e => e.VendorAttributeId, "IX_VendorAttributeValue_VendorAttributeId");

            entity.Property(e => e.Name).HasMaxLength(400);

            entity.HasOne(d => d.VendorAttribute).WithMany(p => p.VendorAttributeValues)
                .HasForeignKey(d => d.VendorAttributeId)
                .HasConstraintName("FK_VendorAttributeValue_VendorAttributeId_VendorAttribute_Id");
        });

        modelBuilder.Entity<VendorNote>(entity =>
        {
            entity.ToTable("VendorNote");

            entity.HasIndex(e => e.VendorId, "IX_VendorNote_VendorId");

            entity.HasOne(d => d.Vendor).WithMany(p => p.VendorNotes)
                .HasForeignKey(d => d.VendorId)
                .HasConstraintName("FK_VendorNote_VendorId_Vendor_Id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
