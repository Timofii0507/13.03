﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._03
{
    public class LightOnCommand : ICommand
    {
        private Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }
}