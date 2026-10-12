using Appointment_Application.Controller;
using Appointment_Application.Repository;
using Appointment_Application.Service;
using Microsoft.Extensions.DependencyInjection;
using Appointment_Application.View;
using Appointment_Application.Models;


namespace Appointment_Application
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var  services = new ServiceCollection();
            services.AddScoped<AppointmentDatabaseSystemGpContext>();
            services.AddScoped<IPatientRepo, PatientRepository>();
            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<PatientController, PatientController>();
            var provider = services.BuildServiceProvider();
            var Controller = provider.GetRequiredService<PatientController>();
            var patients = Controller.GetPatients().ToList();
            PatientView.DisplayPatients(patients);
        }
    }
}
