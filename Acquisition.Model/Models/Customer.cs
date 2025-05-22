using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? DUNS { get; set; }

    public string? Country { get; set; }

    public string? Province { get; set; }

    public string? Address { get; set; }

    public string? PostCode { get; set; }

    public string? Fax { get; set; }

    public string? ContactPerson { get; set; }

    public string? Email { get; set; }

    public string? Telphone { get; set; }

    public string? MobilePhone { get; set; }

    public int? CreatorId { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? State { get; set; }

    public virtual User? Creator { get; set; }

    public virtual User? Editor { get; set; }

    public virtual ICollection<ProductDeliveryRequestForm> ProductDeliveryRequestForms { get; set; } = new List<ProductDeliveryRequestForm>();
}
