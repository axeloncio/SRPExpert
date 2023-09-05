using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var paciente1 = new Patient("Robertito", "", "5555-555-555", DateTime.Now, "Wall Street", "Armando");

            var appointmentService = new AppointmentService();

            DateTime fechaCita = DateTime.Now.AddDays(7); // La cita puede variar, algo que no hacía el programa original
            string resultadoCita = appointmentService.CreateAndScheduleAppointment(paciente1, fechaCita);

            Console.WriteLine(resultadoCita);
        }
    }
}

