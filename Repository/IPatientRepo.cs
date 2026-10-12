using System;
using System.Collections.Generic;
using System.Text;
using Appointment_Application.Models;

namespace Appointment_Application.Repository
{
    internal interface IPatientRepo
    {
        List<Patient> GetPatients();
    }
}
