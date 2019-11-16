using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace MediaFolderLibrary
{
    class MediaPlayer : ICollection<PlayList>
    {
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Play(ICollection<MediaElement> list, MediaElement element) { }

        public void Pause(ICollection<MediaElement> list, MediaElement element) { }

        public void Stop(ICollection<MediaElement> list, MediaElement element) { }

        StreamReader getStream(MediaElement element) { return new StreamReader(new FileStream(element.Path, FileMode.Open)); }

        public void Add(PlayList item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(PlayList item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(PlayList[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(PlayList item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<PlayList> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
