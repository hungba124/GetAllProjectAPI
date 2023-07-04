using System;
using System.Collections.Generic;

namespace LangBatDongSan34.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public string? EmailToRevalidate { get; set; }

    public string? SystemName { get; set; }

    public string? TransferCode { get; set; }

    public int? BillingAddressId { get; set; }

    public int? ShippingAddressId { get; set; }

    public Guid CustomerGuid { get; set; }

    public string? AdminComment { get; set; }

    public int AffiliateId { get; set; }

    public int VendorId { get; set; }

    public bool HasShoppingCartItems { get; set; }

    public bool RequireReLogin { get; set; }

    public int FailedLoginAttempts { get; set; }

    public DateTime? CannotLoginUntilDate { get; set; }

    public decimal BalanceAmount { get; set; }

    public decimal PromotionAmount { get; set; }

    public bool Active { get; set; }

    public bool Deleted { get; set; }

    public bool IsSystemAccount { get; set; }

    public string? LastIpAddress { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public DateTime LastActivityDate { get; set; }

    public int RegisteredInStoreId { get; set; }

    public virtual ICollection<ActivityLog> ActivityLogs { get; set; } = new List<ActivityLog>();

    public virtual Address? BillingAddress { get; set; }

    public virtual ICollection<BlogComment> BlogComments { get; set; } = new List<BlogComment>();

    public virtual ICollection<CustomerPassword> CustomerPasswords { get; set; } = new List<CustomerPassword>();

    public virtual ICollection<ExternalAuthenticationRecord> ExternalAuthenticationRecords { get; set; } = new List<ExternalAuthenticationRecord>();

    public virtual ICollection<ForumsPost> ForumsPosts { get; set; } = new List<ForumsPost>();

    public virtual ICollection<ForumsPrivateMessage> ForumsPrivateMessageFromCustomers { get; set; } = new List<ForumsPrivateMessage>();

    public virtual ICollection<ForumsPrivateMessage> ForumsPrivateMessageToCustomers { get; set; } = new List<ForumsPrivateMessage>();

    public virtual ICollection<ForumsSubscription> ForumsSubscriptions { get; set; } = new List<ForumsSubscription>();

    public virtual ICollection<ForumsTopic> ForumsTopics { get; set; } = new List<ForumsTopic>();

    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();

    public virtual ICollection<NewsComment> NewsComments { get; set; } = new List<NewsComment>();

    public virtual ICollection<PollVotingRecord> PollVotingRecords { get; set; } = new List<PollVotingRecord>();

    public virtual ICollection<ProductReview> ProductReviews { get; set; } = new List<ProductReview>();

    public virtual ICollection<RewardPointsHistory> RewardPointsHistories { get; set; } = new List<RewardPointsHistory>();

    public virtual Address? ShippingAddress { get; set; }

    public virtual ICollection<ShoppingCartItem> ShoppingCartItems { get; set; } = new List<ShoppingCartItem>();

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual ICollection<CustomerRole> CustomerRoles { get; set; } = new List<CustomerRole>();
}
