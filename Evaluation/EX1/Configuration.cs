//EX1.3
public sealed class Configuration
{
    private static readonly object lockObj = new object();
    private static Configuration instance;

    public string DbConnection { get; set; }
    public string Language { get; set; }

    private Configuration() { }

    public static Configuration GetInstance()
    {
        if (instance == null)
        {
            lock (lockObj)
            {
                if (instance == null)
                    instance = new Configuration();
            }
        }
        return instance;
    }
}