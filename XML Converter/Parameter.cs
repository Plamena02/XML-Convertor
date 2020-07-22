﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XML_Converter
{
    public class Parameter
    {
        public enum Names { config, input, output };

        public string Name { get; set; }

        public string Value { get; set; }

        public Parameter(int num, string value)
        {
            if (num == 1)
            {
                Name = Names.config.ToString();
            }
            else if (num == 2)
            {
                Name = Names.input.ToString();
            }
            else
            {
                Name = Names.output.ToString();
            }
            Value = value;
        }


    }
}