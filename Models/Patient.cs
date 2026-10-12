using System;
using System.Collections.Generic;

namespace Appointment_Application.Models;

public partial class Patient
{
    public int PatientId { get; set; }

    public string PatientName { get; set; } = null!;

    public string PatientSurname { get; set; } = null!;

    public string? PatientEmail { get; set; }

    public int? PhoneNumber { get; set; }

    public string? CityTown { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
