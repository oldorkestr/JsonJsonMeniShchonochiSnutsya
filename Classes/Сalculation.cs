using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonJsonMeniShchonochiSnutsya.Classes
{
    internal class Сalculation
    {
        public static Folder CreateFolder(DirectoryInfo dirInfo)
        {
            var files = new List<File>();
            var getFiles = dirInfo.GetFiles();
            var folders = new List<Folder>();
            var getFolders = dirInfo.GetDirectories();

            if (getFolders.Count() > 0) 
            {
                foreach(var folder in getFolders)
                {
                    folders.Add(CreateFolder(folder));
                }
            }
            if (getFiles.Count() > 0)
            {
                foreach(var file in getFiles)
                {
                    files.Add(new File { Name = file.Name, Size = String.Format(file.Length + " B"),
                        Path = file.FullName });
                }
            }
            return new Folder(dirInfo.Name, dirInfo.CreationTime.ToString("dd-MMM-yy, h:mm tt"), folders, files);
        }
    }
}
