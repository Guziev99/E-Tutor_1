using E_TutorApp.Domain.Entities.Abstracts;
using E_TutorApp.Domain.Entities.Common;
//using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;




//using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TutorApp.Domain.Entities.Concretes
{
    public  class User : IdentityUser, IBaseEntity
    {
        // Columns
        //public string? FirstName { get; set; }
        // public string? UserName { get; set; }
        //public string? Email { get; set; }
        ///public byte[]? PasswordHash { get; set; }
        //public byte[]? PasswordSalt { get; set; }
        //public string? PasswordHash { get; set; }
        //public string? PasswordSalt { get; set; }
        //public bool? ConfirmEmail { get; set; }


        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? ProfilePicture { get; set; }
        public string? Bio { get; set; }

        // Foreign Key





        // Navigation Properties

        //public virtual IEnumerable<Course>? EnrolledCoursesOfStudent { get; set; }
        public virtual DetailInstructor? DetailOfInstrutctor { get; set; }

        public virtual DetailStudent? DetailStudent { get; set; }



        




        // Bunlari da elave etmek isteyirem.  Ki, bu studentin Complated ve Enroll, not complated olan kurslarini saxlayacaq. 

        //public virtual ICollection <Course> EnrollCourses { get; set; }

        //public virtual CoursesWithSameInstructor? CoursesWithSameInstructor { get; set; }
    }
}
