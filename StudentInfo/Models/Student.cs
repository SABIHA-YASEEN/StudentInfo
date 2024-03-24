using System;
using System.Collections.Generic;

namespace StudentInfo.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public int? Semester { get; set; }

    public string? Batch { get; set; }
}
