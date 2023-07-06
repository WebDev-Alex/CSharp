// ------------------------------------------------------------------------------------------------------------------
// <copyright file="StudentController.cs" company="DVSE GmbH">
//   Copyright (c) by DVSE Gesellschaft für Datenverarbeitung, Service und Entwicklung mbH. All rights reserved.
// </copyright>
// <author>Adina Nicoara</author>
// ------------------------------------------------------------------------------------------------------------------

namespace CSharpIntroduction.Logic.Controllers
{
  using CSharpIntroduction.DataType;
  using CSharpIntroduction.DataType.Enums;
  using CSharpIntroduction.Logic.Interfaces;
  using System.Text;

  public class StudentController : BaseController, IStudentController
  {
    private List<Student> studentsList;

    public override void GenerateRandomData()
    {
      studentsList = new List<Student>
      {
        new Student("John T", "ZS12345", EGender.Male),
        new Student("Mary D", "ZS658", EGender.Female),
        new Student("Haley W", "ZS390", EGender.Female)
      };

      //studentsList.Add(new Student("John T", "ZS12345", EGender.Male));
    }

    public List<string> GetStudentsName()
    {
      List<string> names = new List<string>();
      foreach (KeyValuePair<EGender, List<string>> item in this.GetStudentsNames())
      {
        switch(item.Key)
        {
          case EGender.Male:
            foreach (string tmp in item.Value)
            {
              names.Add("Mr. " + tmp);
            }

            break;
          case EGender.Female:
            StringBuilder stringBuilder = new StringBuilder();
            foreach(string tmp in item.Value)
            {
              stringBuilder.AppendLine($"Mrs. {tmp}");
            }

            names.Add(stringBuilder.ToString());

            break;
          default:
            foreach (string tmp in item.Value)
            {
              names.Add($"Nonbinary {tmp}");
            }

            break;
        }
      }

      return names;
    }

    private Dictionary<EGender, List<string>> GetStudentsNames()
    {
      Dictionary<EGender, List<string>> namesCollection = new Dictionary<EGender, List<string>>();
      if (this.studentsList != null && this.studentsList.Count > 0)
      // if (studentList?.Count > 0)
      {
        foreach (Student item in this.studentsList)
        {
          if (namesCollection.ContainsKey(item.Gender))
          {
            List<string>names = namesCollection[item.Gender];
            names.Add(item.Name);
          }
          else
          {
            List<string>names = new List<string>();
            names.Add(item.Name);
            namesCollection.Add(item.Gender, names);
          }
        }
      }

      return namesCollection;
    }

        public override void SearchPerson(string cnp)
        {
            foreach (var student in studentsList)
            {
                if(student.CNP == cnp)
                {
                    Console.WriteLine("Found student: " + student.Name + " Study year: " + student.YearOfStudy);
                    Console.WriteLine("Insert the new year of study: ");
                    var newYear = Console.ReadLine();
                    student.YearOfStudy = Int32.Parse(newYear);
                    //return student;
                }
            }
        }

        public override void ShowAllData()
        {
            Console.WriteLine("\n--Students--");
            foreach (var student in studentsList)
            {
                Console.WriteLine("\nName: " + student.Name);
                Console.WriteLine("CNP: " + student.CNP);
                Console.WriteLine("Specialization: " + student.Specialization);
                Console.WriteLine("Gender: " + student.Gender);
                Console.WriteLine("Year of Study: " + student.YearOfStudy);
                Console.WriteLine("-----------------------------");
            }
        }

        public void DeleteStudent(string cnp)
        {
            foreach (var student in studentsList)
            {
                if (student.CNP == cnp)
                {
                    Console.WriteLine("Found student: " + student.Name + " Study year: " + student.YearOfStudy);
                    Console.WriteLine("Are you sure you want to delete this student? y/n");
                    var response = Console.ReadLine();
                    if(response == "y")
                    {
                        studentsList = studentsList.Where(val => val.CNP != cnp).ToList();
                    }
                    //return student;
                }
            }
        }

        public void ResetRegisteredData()
    {
      //delete students list
    }
  }
}
