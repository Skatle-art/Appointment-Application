using Appointment_Application.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Appointment_Application.Models;

namespace Appointment_Application.Service
{
    internal class PatientService : IPatientService
    {
        private readonly IPatientRepo _repository;

        public PatientService(IPatientRepo repository)
        {
          
            _repository = repository;
        }

        public List<Patient> ShowPatients()
        {
            return _repository.GetPatients();
        }
    }
}
