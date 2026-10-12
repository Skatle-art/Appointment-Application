using System;
using System.Collections.Generic;

namespace Appointment_Application.Models;

public partial class Appointment
{
    public int AppointmentId { get; set; }

    public DateOnly AppointmentDate { get; set; }

    public TimeOnly AppointmentTime { get; set; }

    public string VisitReason { get; set; } = null!;

    public int? PatientId { get; set; }

    public int? Gpid { get; set; }

    public virtual GeneralPractitioner? Gp { get; set; }

    public virtual Patient? Patient { get; set; }
}
