using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _59.CRUD_App_using_ASP_CORE_WEB_API.Models
{
 
        public class Student
        {
            public int id { get; set; }
        [DisplayName("Student Name")]
        [Required(ErrorMessage = "Name is required")]
            public string name { get; set; }
        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender is required")]
        public string gender { get; set; }
        [DisplayName("Class")]
        [Required(ErrorMessage = "Class is required")]
        public int _class { get; set; }
        [DisplayName("Fees")]
        [Required(ErrorMessage = "Fees is required")]
        public int fees { get; set; }
        }

    }

