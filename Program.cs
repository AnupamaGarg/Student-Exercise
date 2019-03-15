using System;
using System.Collections.Generic;

namespace StudentExcercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 4, or more, exercises.
            Excercise excercise1 = new Excercise(1,"OverlyExcited", "JavaScript");
            Excercise excercise2 = new Excercise(2,"Kennel", "React");
            Excercise excercise3 = new Excercise(3,"Classes", "CSharp");
            Excercise excercise4 = new Excercise(4,"LINQ", "CSharp");


            // Create 3, or more, cohorts.

            Cohort cohort27 = new Cohort(27, "Cohort-27");
            Cohort cohort28 = new Cohort(28, "Cohort-28");
            Cohort cohort29 = new Cohort(29, "Cohort-29");
            Cohort cohort30 = new Cohort(30, "Cohort-30");
            Cohort cohort31 = new Cohort(31, "Cohort-31");


            // Create 4, or more, students and assign them to one of the cohorts.

            Student student1 = new Student(1, "Anupama", "Garg", "day-cohort-29", 29);
            Student student2 = new Student(2, "Grady", "Robin", "day-cohort-29", 29);
            Student student3 = new Student(3, "Hannah", "Neal", "day-cohort-29", 29);
            Student student4 = new Student(4, "Colleen", "Woolsey", "day-cohort-29", 29);
            Student student5 = new Student(5, "Prafu", "lata", "day-cohort-30", 30);
            Student student6 = new Student(6, "Kirren", "Covey", "day-cohort-30", 30);
            Student student7 = new Student(7, "Priyanka", "Garg", "day-cohort-27", 27);


            //  Create 3, or more, instructors and assign them to one of the cohorts.

            Instructor instructor1 = new Instructor(1, "Steve", "Brownlee", "day-cohort-30", 30);
            Instructor instructor2 = new Instructor(1, "Jisie", "David", "day-cohort-31", 31);
            Instructor instructor3 = new Instructor(1, "Andy", "Collins", "day-cohort-29", 29);
            Instructor instructor4 = new Instructor(1, "Brenda", "Long", "day-cohort-27", 27);


            // Have each instructor assign 2 exercises to each of the students.

            instructor3.ExcercisesAssingedToStudents(student1, excercise4);
            instructor3.ExcercisesAssingedToStudents(student1, excercise2);
            instructor1.ExcercisesAssingedToStudents(student5, excercise3);
            instructor1.ExcercisesAssingedToStudents(student5, excercise1);
            instructor4.ExcercisesAssingedToStudents(student7, excercise3);
            instructor4.ExcercisesAssingedToStudents(student7, excercise1);


        
            //  Create a list of students. Add all of the student instances to it.

            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            students.Add(student5);
            students.Add(student6);
            students.Add(student7);

        //    Create a list of exercises. Add all of the exercise instances to it.
            List<Excercise> excercises=new List<Excercise>();
            excercises.Add(excercise1);
            excercises.Add(excercise2);
            excercises.Add(excercise3);
            excercises.Add(excercise4);

        //    Generate a report that displays which students are working on which exercises.

            student1.StudentExcerciseList();
            student2.StudentExcerciseList();
            student3.StudentExcerciseList();
            student4.StudentExcerciseList();
            student5.StudentExcerciseList();
            student6.StudentExcerciseList();
            student7.StudentExcerciseList();




        }
    }
}
