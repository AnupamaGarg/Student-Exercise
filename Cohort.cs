// You must define a type for representing a cohort in code.

// The cohort's name (Evening Cohort 6, Day Cohort 25, etc.)
// The collection of students in the cohort.
// The collection of instructors in the cohort.

using System.Collections.Generic;

namespace StudentExcercises
{

public class Cohort
{
     public int Id { get; set; }
    public string CohortName { get; set; }
   public List<Student> StudentList{ get; set; }
   public List<Instructor> InstructorList{ get; set; }


     public Cohort(int id, string cohortName ){

         Id= id;
         CohortName = cohortName;
         StudentList = new List<Student>();
         InstructorList = new List<Instructor>();
         
     }
    
}
}
