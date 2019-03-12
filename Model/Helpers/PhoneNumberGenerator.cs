﻿using System;
using System.Text;

namespace Model
{
    public class PhoneNumberGenerator
    {
        Random random = new Random();

        public string GetNumber()
        {
            var sb = new StringBuilder("8");
            for (var i = 0; i < 10; i++)
                sb.Append(random.Next(10));
            return sb.ToString();
        }
    }
}
