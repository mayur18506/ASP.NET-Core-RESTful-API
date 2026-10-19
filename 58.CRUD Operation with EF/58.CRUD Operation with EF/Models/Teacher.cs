using System;
using System.Collections.Generic;

namespace _58.CRUD_Operation_with_EF.Models;

public partial class Teacher
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string Qualification { get; set; } = null!;

    public int Salary { get; set; }
}
