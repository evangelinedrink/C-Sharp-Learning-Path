﻿// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.ConsoleApp.Models.Samples;

namespace Example.ConsoleApp.Services.Foundations.Samples
{
    public interface ISampleService
    {
        Sample AddSample(Sample sample);
    }
}
