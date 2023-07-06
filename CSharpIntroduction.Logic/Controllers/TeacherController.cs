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

    public class TeacherController : BaseController, ITeacherController
    {
        private List<Teacher> teacherList;

        public override void GenerateRandomData()
        {
            teacherList = new List<Teacher>
      {
        new Teacher("T John T", "ZS12345", EGender.Male),
        new Teacher("T Mary D", "ZS658", EGender.Female),
        new Teacher("T Haley W", "ZS390", EGender.Female)
      };

        }

        public override void SearchPerson(string cnp)
        {
            foreach (var teacher in teacherList)
            {
                if (teacher.CNP == cnp)
                {
                    Console.WriteLine("Found teacher: " + teacher.Name);
                }
            }
        }

        public override void ShowAllData()
        {
            Console.WriteLine("\n--Teachers--");
            foreach (var teacher in teacherList)
            {
                Console.WriteLine("\nName: " + teacher.Name);
                Console.WriteLine("CNP: " + teacher.CNP);
                Console.WriteLine("Gender: " + teacher.Gender);
                Console.WriteLine("-----------------------------");
            }
        }

        public void ResetRegisteredData()
        {
            //delete students list
        }
    }
}
