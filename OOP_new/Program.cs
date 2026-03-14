namespace OOP_new;

class Program
{
    static void Main(string[] args)
    {
        Project myProject = new Project();
        
        Developer dev1 = new Developer(1, "Oleg", "backend");
        Developer dev2 = new Developer(2, "Ivan", "frontend");
        Developer dev3 = new Developer(3, "Masha", "frontend");
        Developer dev4 = new Developer(4, "Ihor", "backend");
        
        myProject.AddDeveloper(dev1);
        myProject.AddDeveloper(dev2);
        myProject.AddDeveloper(dev3);
        myProject.AddDeveloper(dev4);
        
        myProject.DevDict();
        
        Task t1 = new Task(101, "Fix bug", "high");
        Task t2 = new Task(167, "Improve code", "high");
        Task t3 = new Task(150, "Resolve conflict", "low");
        Task t4 = new Task(210, "Algorithm fix", "medium");
        Task t5 = new Task(305, "Write a code", "low");
        
        myProject.ShowDevelopersBySpecialization("backend");
        myProject.ShowDevelopersBySpecialization("frontend");
        Console.WriteLine();
        
        myProject.AddTask(t1);
        myProject.AddTask(t2);
        myProject.AddTask(t3);
        myProject.AddTask(t4);
        myProject.AddTask(t5);
        
        myProject.NextTask(dev1);
        myProject.NextTask(dev3);
        myProject.NextTask(dev2);
        myProject.NextTask(dev4);
        myProject.NextTask(dev4);
        Console.WriteLine();
        
        myProject.CompleteTask(t1);
        myProject.CompleteTask(t2);
        myProject.CompleteTask(t3);
        myProject.CompleteTask(t4);
        
        myProject.FilterTask("high");
        Console.WriteLine();
        
        myProject.ShowHistory();
        Console.WriteLine();
        
        myProject.DevOut(); 
        
    }
    
}