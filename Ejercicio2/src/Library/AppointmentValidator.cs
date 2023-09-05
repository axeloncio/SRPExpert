using System;
using System.Text;

/* Por SRP hay que dividir la funcionalidad del programa en las clases pertinentes, la clase AppointmentService
que se da al comienzo contiene, como mencioné, toda la funcionalidad del programa en una misma clase. La clase que se define
a continuación toma el trabajo de validar la cita */
namespace Library
{
    public class AppointmentValidator
    {
        public bool Validate(Patient patient)
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (string.IsNullOrEmpty(patient.Name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
            }

            if (string.IsNullOrEmpty(patient.Id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
            }

            if (string.IsNullOrEmpty(patient.PhoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
            }

            if (string.IsNullOrEmpty(patient.AppointmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
            }

            if (string.IsNullOrEmpty(patient.DoctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
            }

            return stringBuilder.Length == 0;
        }
    }
}
