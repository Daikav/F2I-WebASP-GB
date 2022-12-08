﻿using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace MVC_EF2.Models;

public class Project

{

    // read/write (get/set) properties
    public int Id { get; set; }
    [MaxLength(50)]
    public string Name { get; set; }
    [MaxLength(500)]
    public string? Description { get; set; }

    // read only (get) properties


    public override string ToString()
    {
        return $"{Name}";
    }

}
