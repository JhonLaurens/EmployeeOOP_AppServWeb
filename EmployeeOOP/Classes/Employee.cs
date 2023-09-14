using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    internal class Employee
    {

        #region Properties
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; } 
        public Date? BirthDate { get; set; }
        public Date? HiringDate { get; set; }
        public bool? IsAcvtive { get; set; }

        #endregion

        #region Methods 

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"INFORMACION EMPLEADO \n\t"+
                $"ID: {Id}\n\t"+
                $"Nombres: {Id}\n\t" +
                $"Apellidos: {Id}\n\t" +
                $"Fecha de Cumpleaños: {Id}\n\t" +
                $"Fecha de Contratación: {Id}\n\t" +
                $"ID: {Id}\n\t" +
        }

        #endregion

    }
}
