using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaFolderLibrary
{
    abstract class PlayableElement : MediaElement
    {
        public TimeSpan Duration { get; }
        public abstract void Play();
    }
}
