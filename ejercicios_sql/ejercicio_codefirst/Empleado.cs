using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ejercicio_codefirst
{
    [Table("CURRANTE")]
    public class Empleado
    {
       
        public int EmpleadoId
        {
            get;
            set;
        }
        public string Empname
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }

        public string EmaIId
        {
            get;
            set;
        }

        public string MobileNo
        {
            get;
            set;
        }

        public string DeptName
        {
            get;
            set;
        }  
    }
}
