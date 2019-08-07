using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBuilder.Domain.Interfaces
{
    public interface ITrackable
    {
        DateTime CreatedAt { get; set; }
        DateTime LastUpdatedAt { get; set; }
    }
}
