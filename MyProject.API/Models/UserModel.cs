using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using MyProject.Common.DTOs;
using System.Collections.Generic;

namespace MyProject.WebAPI.Models
{
    public enum eGenderUser { male, female };
    public enum eHMO { Leumit, Macabi, Clalit, Meuchedet };
 
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }
        public DateTime DateOfBirth { get; set; }
        public eGenderUserDTO Gender { get; set;}
        public eHMODTO HMO { get; set; }
    }
}
