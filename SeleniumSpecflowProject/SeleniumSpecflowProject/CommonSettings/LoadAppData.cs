﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumSpecflowProject.CommonSettings
{
    class LoadAppData
    {
        public static string GetTestData(string key)
        {
            var value = TestContext.Parameters[key];

            return value;
        }


        public static string GetBaseWebUrl()
        {
            return GetTestData("baseUrl");
        }

    }
}
