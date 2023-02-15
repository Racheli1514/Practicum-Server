using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public enum eGenderUser { male, female };
    public enum eHMO {Leumit=0,Macabi=1,Clalit=2,Meuchedet=3};
    public class User
    {
        [Key, Required]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }
        public DateTime DateOfBirth { get; set; }
        public eGenderUser Gender { get; set; }
        public eHMO HMO { get; set; }
       
    }
}
