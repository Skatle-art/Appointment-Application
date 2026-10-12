using System;
using System.Collections.Generic;

namespace Appointment_Application.Models;

public partial class GeneralPractitioner
{
    public int Gpid { get; set; }

    public string? Name { get; set; }

    public string? Specialties { get; set; }

    public string? AddressNo { get; set; }

    public string? CityTown { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
