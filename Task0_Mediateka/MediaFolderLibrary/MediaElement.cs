using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaFolderLibrary
{
    abstract class MediaElement
    {
        public string Name { get; set; }
        public Guid ID { get; }
        public string Path { get; set; }
    }
}
