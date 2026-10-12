using System;
using System.Collections.Generic;
using System.Text;
using Appointment_Application.Service;
using Appointment_Application.Models;


namespace Appointment_Application.Controller
{
    internal class PatientController
    {

        private readonly IPatientService _service;

        public PatientController(IPatientService service)
        {
            _service = service;
        }

        public List<Patient> GetPatients()
        {
            return _service.ShowPatients();
        }
    }
}
