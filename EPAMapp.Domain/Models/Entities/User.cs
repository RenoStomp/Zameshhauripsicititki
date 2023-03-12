﻿using EPAMapp.Domain.Models.Common;

namespace EPAMapp.Domain.Models.Entities
{
    public class User : AccountHolder
    {
        public List<Note> Notes { get; set; }
    }
}
