﻿using System.ComponentModel.DataAnnotations;

namespace L01P02_2021DD601.Models
{
    public class facultades
    {
        [Key]
        public int id { get; set; }
        public string facultad { get; set; }

    }
}
