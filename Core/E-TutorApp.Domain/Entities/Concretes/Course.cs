using E_TutorApp.Domain.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_TutorApp.Domain.Entities.Concretes
{
    public  class Course : BaseEntity
    {
        // Columns

        public string? Name { get; set; }
        public string ? Title { get; set; }
        public string? Description { get; set; }
        public float? Price { get; set; }
        public string? ImageUrl { get; set; }




        // MyNewAdds
        public bool IsActive { get; set; }
        public bool IsCompleted { get; set; }



        // Foreign Key
        public int CategoryId { get; set; }


        // MyNewAdds
        public int InstructorId { get; set; }

        // Navigation Property
        public  virtual DetailInstructor? Instructor { get; set; }
        public virtual  ICollection<User>? Students { get; set; }    

        public virtual Category Category { get; set; }
        public virtual ICollection<Invoice>? ForInvoices { get; set; }
        public virtual ICollection<Curriculum>? Curriculum { get; set; }
    }
}






