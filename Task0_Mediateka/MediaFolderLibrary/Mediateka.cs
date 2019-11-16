using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaFolderLibrary
{
    class Mediateka : IMediaTeka
    {
        public ICollection<MediaElement> collection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(MediaElement item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(MediaElement item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(MediaElement[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<MediaElement> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(MediaElement item)
        {
            throw new NotImplementedException();
        }

        public ICollection<MediaElement> Search(ICollection<MediaElement> collection, string name)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
