using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAppConsole.SalesWatcher
{
    public class FileWatcher
    {
        private static void Run(string path)
        {
            using (FileSystemWatcher watcher = new FileSystemWatcher(path))
            {
                watcher.NotifyFilter = NotifyFilters.LastAccess
                                     | NotifyFilters.LastWrite
                                     | NotifyFilters.FileName
                                     | NotifyFilters.DirectoryName;

                watcher.Filter = "*.csv";

                watcher.Created += OnChanged;

                watcher.EnableRaisingEvents = true;
            }
        }

        private static void OnChanged(object source, FileSystemEventArgs e) =>
            // Specify what is done when a file is changed, created, or deleted.
            Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");
    }
}
