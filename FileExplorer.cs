using System;
using System.IO; 

namespace FileExplorer
{
    class FileWorker
    {
        private string logFile = "default_log.txt";
        private string loggedUser = "default_user";

        public FileWorker(string userName, string userLog)
        {
            this.logFile = userLog;
            this.loggedUser = userName;
            this.WriteLog("has loged in to system");
        }

        public void ChangeUser(string userName)
        {
            this.loggedUser = userName;
            this.WriteLog("has loged in to system");
        }

        public string ReadWholeFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                this.WriteLog("has read a whole file");
                return File.ReadAllText(filePath); 
            } 
            else 
            {
                return "File does not exist in the current directory";
            }
        }

        public string[] ReadFileLineAfterLine(string filePath)
        {
            if (File.Exists(filePath))
            {
                this.WriteLog("has read a file line after line");
                return File.ReadAllLines(filePath);
            } 
            else 
            {
                Console.WriteLine("File does not exist in the current directory");
                return new string[0];
            }
        }

        public void AppendLine(string filePath, string newLine)
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(newLine);
            }
            this.WriteLog("has appended line to a file");
        }
        public void CreateNewFile(string filePath)
        {
            using (StreamWriter strWr = File.CreateText(filePath))
            { }
            this.WriteLog("has created a file");
        }

        private void WriteLog(string logMessage)
        {
            using (StreamWriter sw = File.AppendText(this.logFile))
            {
                sw.WriteLine($"{DateTime.Now.ToString()} {Environment.MachineName}: {this.loggedUser} {logMessage}");
            }
        }
    }
}
