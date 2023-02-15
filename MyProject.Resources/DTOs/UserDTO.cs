using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MyProject.Common.DTOs
{
    public enum eGenderUserDTO { male,female };
    public enum eHMODTO { Leumit=0, Macabi=1, Clalit=2, Meuchedet=3 };
  
    public class UserDTO
    {
        [Key, Required]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }
        public DateTime DateOfBirth { get; set; }
        public eGenderUserDTO Gender { get; set; }
        public eHMODTO HMO { get; set; }
    }
}
