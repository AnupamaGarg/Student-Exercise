// You must define a type for representing an instructor in code.

// First name
// Last name
// Slack handle
// The instructor's cohort
// A method to assign an exercise to a student

using System.Collections.Generic;

namespace StudentExcercises
{

public class Instructor
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SlackHandle { get; set; }
    public int Cohort_id { get; set; }
   public List<Student> StudentList{ get; set; }



     public Instructor (int id, string firstName, string lastName, string slackChannel , int cohort_id  ){

         Id= id;
         FirstName = firstName;
         LastName = lastName;
         SlackHandle = slackChannel;
         Cohort_id = cohort_id;
          }

     public void ExcercisesAssingedToStudents(Student student, Excercise excercise ){
          student. ExcerciseList.Add(excercise);
            
     }     
    
}
}
