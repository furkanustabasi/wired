﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Wired.Service.Models.Request
{
    public class ArticleRequestModel
    {
        public string Title { get; set; }
        public string Contect { get; set; }
        public string TitleGuid { get; set; }
        public bool Status { get; set; }
    }
}
