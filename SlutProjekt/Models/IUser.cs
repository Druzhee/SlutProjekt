﻿using SlutProjekt;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutProjekt
{
    public interface IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }      
    }
}
