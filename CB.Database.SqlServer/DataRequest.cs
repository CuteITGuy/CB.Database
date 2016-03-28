namespace CB.Database.SqlServer
{
    public class DataRequest
    {
        #region  Constructors & Destructor
        public DataRequest(string databaseName, string procedureName, object parameters)
        {
            DatabaseName = databaseName;
            ProcedureName = procedureName;
            Parameters = parameters;
        }
        #endregion


        #region  Properties & Indexers
        public string DatabaseName { get; set; }
        public object Parameters { get; set; }
        public string ProcedureName { get; set; }
        #endregion
    }
}