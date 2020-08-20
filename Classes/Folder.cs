using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonJsonMeniShchonochiSnutsya.Classes
{
    internal class Folder
    {
        public string Name { get; set; }
        public string DateCreated { get; set; }
        public List<Folder> SubFolders { get; set; }
        public List<File> Files { get; set; }

        public Folder(string name, string date, List<Folder> subFolders, List<File> files)
        {
            Name = name;
            DateCreated = date;
            SubFolders = subFolders;
            Files = files;
        }
    }
}
