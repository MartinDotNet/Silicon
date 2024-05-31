﻿using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class CourseEntity
{

    [Key]
    public int id {  get; set; }
    public bool isBestseller {  get; set; }
    public string Image { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;
    public string Price { get; set; } = null!;
    public string? DiscountPrice { get; set; }
    public string Hours { get; set; } = null!;
    public string LikesInProcent { get; set; } = null!;
    public string LikesInNumbers { get; set; } = null!;
}
