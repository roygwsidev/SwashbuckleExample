﻿using System.Collections.Generic;
using Swashbuckle.Examples;

namespace WebApi.Models.Examples
{
    public class DictionaryRequestExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return new Dictionary<string, object>
            {
                {"PropertyInt", 1},
                {"PropertyString", "Some string"}
            };
        }
    }
}
