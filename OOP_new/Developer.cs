namespace OOP_new;

public class Developer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Specialization { get; set; }

    public Developer(int id, string name, string specialization)
    {
        Id = id;
        Name = name;
        Specialization = specialization;
    }
}