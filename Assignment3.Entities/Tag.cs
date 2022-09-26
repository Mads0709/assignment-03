namespace Assignment3.Entities;

public class Tag
{
    public int Id {get; set;}

    [Required]
    public string Name {get; set;}

    public Task Task {get; set;} //many-to-many like a join statemen
}
