// ------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="DVSE GmbH">
//   Copyright (c) by DVSE Gesellschaft für Datenverarbeitung, Service und Entwicklung mbH. All rights reserved.
// </copyright>
// <author>Adina Nicoara</author>
// ------------------------------------------------------------------------------------------------------------------

namespace CSharpIntroduction
{
  using CSharpIntroduction.Logic.Controllers;
  using CSharpIntroduction.Logic.Interfaces;

  internal class Program
  {
    static void Main(string[] args)
    {
      
        Console.WriteLine("Workshop - C# Introduction - University Management!");      
        IStudentController studentController = new StudentController();
        IMasterStudentController masterStudentController = new MasterStudentController();

        ITeacherController teacherController = new TeacherController();
        
        studentController.GenerateRandomData();
        teacherController.GenerateRandomData();

        //List<string> studentsNames = studentController.GetStudentsName();
        Console.WriteLine("The students names are:");
        ShowNames(studentController.GetStudentsName());
        
        masterStudentController.GenerateRandomData();
        Console.WriteLine("The master students names are:");

        //await ShowNames(masterStudentController.GetNames());
        ShowNames(masterStudentController.GetNames());

        Console.WriteLine("Enter command: (update year) (show all) (update note) (delete student) (delete masters) (quit)");

        string? actions = Console.ReadLine();

        while(actions != "quit")
            {

                switch (actions)
                {
                    case "update year":
                        Console.WriteLine("\nInsert Student cnp");
                        string? studentCNP = Console.ReadLine();
                        studentController.SearchPerson(studentCNP);
                        break;
                    case "show all":
                        studentController.ShowAllData();
                        masterStudentController.ShowAllData();
                        teacherController.ShowAllData();
                        break;
                    case "update note":
                        Console.WriteLine("\nInsert Student cnp");
                        string? masterStudentCNP = Console.ReadLine();
                        masterStudentController.UpdateGraduationNote(masterStudentCNP);
                        break;
                    case "delete student":
                        Console.WriteLine("\nInsert Student cnp");
                        string? studentCNPforDelete = Console.ReadLine();
                        studentController.DeleteStudent(studentCNPforDelete);
                        break;
                    case "delete masters":
                        masterStudentController.DeleteMasterStudent();
                        break;

                    default:
                        break;
                }

                Console.WriteLine("Enter command: (update year) (show all) (update note) (delete student) (delete masters) (quit)");
                actions = Console.ReadLine();
            }

        Console.ReadKey();
     }


    //private static async Task ShowNames(List<string> collection)
    private static void ShowNames(List<string> collection)
    {
      if (collection?.Any() == true)
      {
        
        for (int i = 0; i < collection.Count; i++)
        {
          Console.WriteLine(collection[i]);
        }
      }
      else
      {
        Console.WriteLine("No students registered!");
      }
      
    }
  }
}