using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaFolderLibrary
{
    class PlayList : ICollection<PlayableElement>
    {
        public PlayList UserPlayList { get; set; }
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(PlayableElement item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(PlayableElement item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(PlayableElement[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<PlayableElement> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(PlayableElement item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
