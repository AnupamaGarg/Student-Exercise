// Name of exercise
// Language of exercise (JavaScript, Python, CSharp, etc.)

using System.Collections.Generic;

namespace StudentExcercises
{

public class Excercise
{
     public int Id { get; set; }
    public string ExcerciseName { get; set; }

    public string ExcerciseLanguage { get; set; }


    public Excercise(int id , string excerciseName, string excrciseLanguage){
         Id=id;
         ExcerciseName = excerciseName;
         ExcerciseLanguage = excrciseLanguage;
         


    }

   
   
    
}
}