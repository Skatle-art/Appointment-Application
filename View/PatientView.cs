using System;
using System.Collections.Generic;
using System.Text;
using Appointment_Application.Models;

namespace Appointment_Application.View
{
    internal class PatientView
    {
        public static void DisplayPatients(List<Patient> patients)
        {
            //Display the list of patients in a user-friendly format    
            Console.WriteLine("List of Patients:");
            foreach (var patient in patients)
            { 
                Console.WriteLine("NAME:                    SURNAME:                EMAIL:                           PHONE:                     CITY/TOWN: ");
                Console.WriteLine($"{patient.PatientName},{patient.PatientSurname},{patient.PatientEmail ?? "N/A"}, {patient.PhoneNumber ?? 0},{patient.CityTown ?? "N/A"}");
            }
            Console.ReadLine();
            Console.WriteLine("Thank you for using the Appointment Application. Press any key to exit.");
            Console.ReadLine();


        }
    }
}
