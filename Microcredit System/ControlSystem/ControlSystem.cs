﻿using Microcredit_System.ControlSystem.DatabaseStuff;
using Microcredit_System.ControlSystem.Persons.EmployeeStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microcredit_System.ControlSystem
{
    public class ControlSystem
    {
        internal Employee LogIn(string _login, string _password)
        {
            return Database.DB.LogIn(_login, _password);
        } 
    }
}
