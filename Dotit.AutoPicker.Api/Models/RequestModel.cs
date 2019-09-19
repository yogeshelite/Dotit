﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotIt.AutoPickerApi.Models
{
    public class RequestModel
    {
        public string Data { get; set; }

        public int PageNumber { get; set; }

        public string orderBy { get; set; }

        public bool ShowAll { get; internal set; }
    }
}
