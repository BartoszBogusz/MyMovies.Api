﻿namespace Domain.Entities;

public class Disk
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Movie> Movies { get; set; }
}
