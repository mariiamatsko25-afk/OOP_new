namespace OOP_new;

public class Project
{
    private List<Task> allTasks = new List<Task>();
    private List<Developer> allDevelopers = new List<Developer>();
    private Dictionary<string, List<Developer>> developers = new Dictionary<string, List<Developer>>();
    private Queue<Task> backlog = new Queue<Task>();
    private Stack<Task> history = new Stack<Task>();
    private Dictionary<Developer, List<Task>> assignments = new Dictionary<Developer, List<Task>>();

    
    public void AddDeveloper(Developer dev)
    {
        allDevelopers.Add(dev);
    }
    
    
    public void DevDict()
    {
        foreach (var dev in allDevelopers)
        {
            string specialisation = dev.Specialization;
            if (!developers.ContainsKey(specialisation))
            {
                developers[specialisation] = new List<Developer>();
            }

            developers[specialisation].Add(dev);
        }
    }

    public void AddTask(Task task)
            {
            allTasks.Add(task);
            backlog.Enqueue(task);
            }

    public void NextTask(Developer dev)
    {
        if (backlog.Count > 0)
        {
            Task task = backlog.Dequeue();
            task.SetDeveloper(dev);
            
            task.ChangeStatus("in progress");
            
            if (!assignments.ContainsKey(dev))
            {
                assignments[dev] = new List<Task>();
            }
            assignments[dev].Add(task);
        
            Console.WriteLine($"Task {task.Name} is for {dev.Name}");
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }
    }
    public void CompleteTask(Task task)
    {
        task.ChangeStatus("done");
        history.Push(task);
    }
    
    public void DevOut()
    {
        foreach (var pair in developers)
        {
            Console.WriteLine($"specialisation: {pair.Key}");
            int count = 0;
            foreach (var dev in pair.Value)
            {
                count++;
                Console.WriteLine($"{count}: {dev.Name}");
            }
        }
    }
    
    public void FilterTask(string needPriority)
    {
        Console.WriteLine($"tasks with {needPriority} priority:");
        int count = 0;
        foreach (var task in allTasks)
        {
            if (task.Priority == needPriority)
            {
                count++;
                Console.WriteLine($"{count} - {task.Name}");
            }
        }
    }
    
    public void ShowDevelopersBySpecialization(string specialization)
    {
        Console.WriteLine($"Developers of {specialization}:");
        int count = 0;
        if (developers.ContainsKey(specialization))
        {
            foreach (var dev in developers[specialization])
            {
                count++;
                Console.WriteLine($"{count}. {dev.Name}");
            }
        }
    }
    
    public void ShowHistory()
    {
        Console.WriteLine("History of done tasks: ");
        foreach (var task in history)
        {
            Console.WriteLine($"Task: {task.Name} is done");
        }
    }
}