using System;
using System.Collections.Generic;
using System.Text;
using Appointment_Application.Models;

namespace Appointment_Application.Service
{
    internal interface IPatientService
    {
      
            public List<Patient> ShowPatients();
        
    }
}
