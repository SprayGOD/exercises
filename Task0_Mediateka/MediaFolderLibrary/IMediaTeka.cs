using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaFolderLibrary
{
    interface IMediaTeka : ICollection<MediaElement>
    {
        ICollection<MediaElement> collection { get; set; }
        ICollection<MediaElement> Search(ICollection<MediaElement> collection, string name);
    }
}
