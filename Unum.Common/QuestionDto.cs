﻿using System;

namespace Unum.Common
{
    public class QuestionDto
    {
        public int QuestionId { get; set; }
        public string Description { get; set; }
        public bool? IsValid { get; set; }
    }
}
