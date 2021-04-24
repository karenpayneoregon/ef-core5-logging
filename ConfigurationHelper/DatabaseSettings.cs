namespace ConfigurationHelper
{
    /// <summary>
    /// Properties for setting up a connection string
    /// </summary>
    public class DatabaseSettings
    {
        /// <summary>
        /// SQL-Server server
        /// </summary>
        public string DatabaseServer { get; set; }
        /// <summary>
        /// Default catalog
        /// </summary>
        public string Catalog { get; set; }
        /// <summary>
        /// User Integrated security
        /// </summary>
        public bool IntegratedSecurity { get; set; }
        /// <summary>
        /// Where to log for Entity Framework Core
        /// </summary>
        public LoggingDestination LoggingDistination { get; set; }
        /// <summary>
        /// Name of Entity Framework Core log file
        /// </summary>
        public string LogFileName { get; set; }
        /// <summary>
        /// SQL-Server connection string for Entity Framework Core
        /// </summary>
        public string ConnectionString => $"Data Source={DatabaseServer};" +
                                          $"Initial Catalog={Catalog};" +
                                          $"Integrated Security={IntegratedSecurity}";

    }
}
