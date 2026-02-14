using System;

public sealed class AppConfig
{
    // Lazy<T> crea la instancia solo cuando se necesita (thread-safe)
    private static readonly Lazy<AppConfig> _instancia =
        new Lazy<AppConfig>(() => new AppConfig());

    public static AppConfig Instancia => _instancia.Value;

    // Constructor privado: impide new AppConfig() desde fuera
    private AppConfig()
    {
        ConnectionString = "Server=.;Database=MiDB;Trusted_Connection=True;";
    }

    public string ConnectionString { get; private set; }
}

class Program
{
    static void Main()
    {
        var config1 = AppConfig.Instancia;
        var config2 = AppConfig.Instancia;

        Console.WriteLine(config1.ConnectionString);
        Console.WriteLine(Object.ReferenceEquals(config1, config2)); // True
    }
}

