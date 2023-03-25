namespace MyAPI.Data
{
    public class MySqlConfiguration
    {
        public string ConnectionString { get; set; }

        public MySqlConfiguration(string connectionString)
        {
            ConnectionString = connectionString;
        }


    }
}