﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson01.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string title { get; set; }

        public string content { get; set; }
        public int status { get; set; }
        public DateTime add_time { get; set; }
        public DateTime mobify_time { get; set; }

    }
}
