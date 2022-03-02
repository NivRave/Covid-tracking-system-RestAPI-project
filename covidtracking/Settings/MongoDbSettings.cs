namespace covidtracking.Settings
{
    public class MongoDbSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string ConnectionString
        {
            get
            {
                //To run with a concrete online mongo database, remove the class' parameters,
                //remove the current return line and replace with the commented one after passing your
                //credentials.
                //return $"mongodb+srv://"+{user}+":"+{pass}+"@{db url}";
                return $"mongodb://{Host}:{Port}";
            }
        }
    }
}