// First name
// Last name
// Slack handle
// The student's cohort
// The collection of exercises that the student is currently working on
using System;
using System.Collections.Generic;

namespace StudentExcercises
{

    public class Student
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SlackHandle { get; set; }
        public int Cohort_id { get; set; }


        public List<Excercise> ExcerciseList { get; set; }


        public Student(int id, string firstName, string lastName, string slackHandle, int cohort_id)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort_id = cohort_id;
            ExcerciseList = new List<Excercise>();
        }

        public void StudentExcerciseList(){
            foreach (Excercise excercise in ExcerciseList)
            {
                Console.WriteLine($"{FirstName}{LastName}Is assigned {excercise.ExcerciseName}");

            }
        }

    }
}
