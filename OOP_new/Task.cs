namespace OOP_new;

public class Task
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Priority { get; private set; }
    public string Status { get; private set; }
    public Developer? TaskDeveloper { get; set; }
    
    public Task(int id, string name, string priority)
    {
        Id = id;
        Name = name;
        Priority = priority;
        Status = "to do";
        TaskDeveloper = null;
    }
    
    
    public void ChangeStatus(string newStatus)
    {
        Status = newStatus;
    }

    public void ChangePriority(string changePriority)
    {
        Priority = changePriority;
    }

    public void SetDeveloper(Developer developer)
    {
        TaskDeveloper = developer;
    }
    
}