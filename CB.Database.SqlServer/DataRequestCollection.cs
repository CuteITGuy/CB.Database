using System.Collections;
using System.Collections.Generic;


namespace CB.Database.SqlServer
{
    public class DataRequestCollection: ICollection<DataRequest>
    {
        #region Fields
        private readonly List<DataRequest> _collection = new List<DataRequest>();
        #endregion


        #region  Properties & Indexers
        public int Count => _collection.Count;
        public bool IsReadOnly => false;
        public QueryStrategy QueryStrategy { get; set; }
        #endregion


        #region Methods
        public void Add(DataRequest item)
        {
            _collection.Add(item);
        }

        public void Clear()
        {
            _collection.Clear();
        }

        public bool Contains(DataRequest item)
        {
            return _collection.Contains(item);
        }

        public void CopyTo(DataRequest[] array, int arrayIndex)
        {
            _collection.CopyTo(array, arrayIndex);
        }

        public IEnumerator<DataRequest> GetEnumerator()
        {
            return _collection.GetEnumerator();
        }

        public bool Remove(DataRequest item)
        {
            return _collection.Remove(item);
        }
        #endregion


        #region Implementation
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}