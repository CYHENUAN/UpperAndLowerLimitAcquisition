using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class CustomerBoxInformation
{
    public long Id { get; set; }

    public long? ContainerId { get; set; }

    public string? CustomerBoxNumber { get; set; }

    public DateTime? LinkDateTimed { get; set; }

    public int? CreatorId { get; set; }

    public int? ProductDeliveryRequestFormItemId { get; set; }

    public int? MaterialOtherMovementFormItemId { get; set; }

    public virtual Container? Container { get; set; }

    public virtual User? Creator { get; set; }

    public virtual MaterialOtherMovementFormItem? MaterialOtherMovementFormItem { get; set; }

    public virtual ProductDeliveryRequestFormItem? ProductDeliveryRequestFormItem { get; set; }
}
