using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirst
{
    [Table ("Currante")]
    public class Empleado
    {
        [Key]
        public int EmpleadoId
        {
            get; set;
        }
        public string EmpName
        {
            get; set;
        }
        public string Address
        {
            get; set;
        }
        public string EmailId
        {
            get; set;
        }
        public string MobileNo
        {
            get; set;
        }
        public string DeptName
        {
            get; set;
        }
    }
   
}
