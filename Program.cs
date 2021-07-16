using System;
using FileExplorer;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            FileWorker workobject = new FileWorker("User", @"E:\C#\FileExplorer\logfile.txt");
            string file_path = @"E:\C#\FileExplorer\test.txt";
            string file_path_new = @"E:\C#\FileExplorer\test_new.txt";
            string file_path_wrong = @"E:\C#\FileExplorer\test_wrong.txt";
            Console.WriteLine(workobject.ReadWholeFile(file_path));
            foreach (string line in workobject.ReadFileLineAfterLine(file_path))
            Console.WriteLine(line); 
            Console.WriteLine(workobject.ReadWholeFile(file_path_wrong));
            foreach (string line in workobject.ReadFileLineAfterLine(file_path_wrong))    
            Console.WriteLine(line);  
            workobject.CreateNewFile(file_path_new);
            workobject.AppendLine(file_path_new, "Test message");
            workobject.AppendLine(file_path_new, "Test message2");
        }
    }
}
