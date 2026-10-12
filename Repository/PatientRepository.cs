using Appointment_Application.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;

namespace Appointment_Application.Repository
{
    internal class PatientRepository: IPatientRepo
    {
        private readonly AppointmentDatabaseSystemGpContext _repo;
        public PatientRepository(AppointmentDatabaseSystemGpContext repo)
        {
            _repo = repo;
        }
        public List<Patient> GetPatients()
        {
            return _repo.Patients.ToList<Patient>();
        }
    }
}
