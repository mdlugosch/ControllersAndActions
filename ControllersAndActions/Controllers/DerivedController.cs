﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllersAndActions.Controllers
{
    public class DerivedController : Controller
    {
        public ViewResult Index() =>
            View("Result", $"This is a dervied controller");

        public ViewResult Headers() => View("DictionaryResult",
            Request.Headers.ToDictionary(kvp => kvp.Key,
                kvp => kvp.Value.First()));
    }
}
