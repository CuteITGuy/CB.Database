using System.Collections.Generic;
using System.Data.SqlClient;


namespace CB.Database.SqlServer
{
    public class DataRequest
    {
        #region  Properties & Indexers
        public string DatabaseName { get; set; }
        public IEnumerable<SqlParameter> Parameters { get; set; }
        public string StoredProcedure { get; set; }
        #endregion
    }
}