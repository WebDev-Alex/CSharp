// ------------------------------------------------------------------------------------------------------------------
// <copyright file="MasterStudentController.cs" company="DVSE GmbH">
//   Copyright (c) by DVSE Gesellschaft für Datenverarbeitung, Service und Entwicklung mbH. All rights reserved.
// </copyright>
// <author>Adina Nicoara</author>
// ------------------------------------------------------------------------------------------------------------------

namespace CSharpIntroduction.Logic.Controllers
{

  using CSharpIntroduction.DataType;
  using CSharpIntroduction.DataType.Enums;
  using CSharpIntroduction.Logic.Interfaces;

  public class MasterStudentController : BaseController, IMasterStudentController
  {
    private List<MasterStudent> masterStudentsList;
    //private List2<Teacher> teacherList;

        public override void GenerateRandomData()
    {
      masterStudentsList = new List<MasterStudent>
      {
        new MasterStudent("Michael T", "123", EGender.Male, "UMFST", 8),
        new MasterStudent("Addison M", "454", EGender.Female, "Sapientia", 9),
        new MasterStudent("aaa M", "323", EGender.Female, "Sapientia", 8),
        new MasterStudent("ddd M", "222", EGender.Female, "UMFST", 4),
        new MasterStudent("asd M", "444", EGender.Male, "Sapientia", 5)
      };
    }

    public List<string> GetNames()
    {
      List<string> names = new List<string>();
      if (masterStudentsList?.Count > 0)
      {
        foreach (MasterStudent student in masterStudentsList)
        {
          names.Add(student.Name);
        }
      }

      return names;
    }

    /*public void assignTeacher(string cnp)
    {
        Console.WriteLine("Insert the CNP of the master student: ");
        foreach (var student in masterStudentsList)
        {
            if (student.CNP == cnp)
                {
                Console.WriteLine("Found student: " + student.Name + " Study year: " + student.YearOfStudy);
                Console.WriteLine("Insert the CNP  of teacher: ");
                var teachCNP = Console.ReadLine();
                foreach (var teacher in teacherList)
                {
                    if (teacher.CNP == cnp)
                    {
                       //student.Supervisor = teacher;
                    }
                }
             }
        }
    }*/

    public override void SearchPerson(string cnp)
        {
            foreach (var student in masterStudentsList)
            {
                if (student.CNP == cnp)
                {
                    Console.WriteLine("Found student: " + student.Name + " Study year: " + student.YearOfStudy);
                    Console.WriteLine("Insert the new year of study: ");
                    var newYear = Console.ReadLine();
                    student.YearOfStudy = Int32.Parse(newYear);
                }
            }
        }

        public override void ShowAllData()
        {
            Console.WriteLine("\n--Master Students--");
            foreach (var student in masterStudentsList)
            {
                Console.WriteLine("\nName: " + student.Name);
                Console.WriteLine("CNP: " + student.CNP);
                Console.WriteLine("Specialization: " + student.Specialization);
                Console.WriteLine("Gender: " + student.Gender);
                Console.WriteLine("Year of Study: " + student.YearOfStudy);
                Console.WriteLine("Graduation University Name: " + student.GraduatedUniversityName);
                Console.WriteLine("Graduation Note: " + student.GraduationNote);
                Console.WriteLine("-----------------------------");
            }
        }

        public void UpdateGraduationNote(string cnp)
        {
            foreach (var student in masterStudentsList)
            {
                if (student.CNP == cnp)
                {
                    Console.WriteLine("Found student: " + student.Name + " Study year: " + student.GraduationNote);
                    Console.WriteLine("Insert the new graduation note of master student: ");
                    var newGrade = Console.ReadLine();
                    student.GraduationNote = Int32.Parse(newGrade);
                }
            }
        }

        public void DeleteMasterStudent()
        {
            
            foreach (var student in masterStudentsList)
            {
                if (student.GraduationNote < 6)
                {
                    Console.WriteLine("Found masters student: " + student.Name + " Study year: " + student.YearOfStudy);
                    Console.WriteLine("Are you sure you want to delete this student? y/n");
                    //return student;
                }
            }
            var response = Console.ReadLine();
            if (response == "y")
            {
                masterStudentsList = masterStudentsList.Where(val => val.GraduationNote >= 6).ToList();
            }
        }

    }
}
