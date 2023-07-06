// ------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseController.cs" company="DVSE GmbH">
//   Copyright (c) by DVSE Gesellschaft für Datenverarbeitung, Service und Entwicklung mbH. All rights reserved.
// </copyright>
// <author>Adina Nicoara</author>
// ------------------------------------------------------------------------------------------------------------------

namespace CSharpIntroduction.Logic.Controllers
{
    public abstract class BaseController
    {
       public abstract void GenerateRandomData();

       public abstract void SearchPerson(string cnp);

       public abstract void ShowAllData();
    }
}
