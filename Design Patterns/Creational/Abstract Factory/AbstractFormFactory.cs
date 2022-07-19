﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Abstract_Factory
{
    public interface AbstractFormFactory
    {
        IButton GetButton();
        IInputField GetInputField();
    }
}
