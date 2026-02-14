using System;

public interface INotificador
{
    void Enviar(string mensaje);
}

public class EmailNotificador : INotificador
{
    public void Enviar(string mensaje) => Console.WriteLine($"Email: {mensaje}");
}

public class SmsNotificador : INotificador
{
    public void Enviar(string mensaje) => Console.WriteLine($"SMS: {mensaje}");
}

public static class NotificadorFactory
{
    // Factory Method: decide qué objeto crear según un criterio
    public static INotificador Crear(string tipo)
    {
        return tipo.ToLower() switch
        {
            "email" => new EmailNotificador(),
            "sms"   => new SmsNotificador(),
            _       => throw new ArgumentException("Tipo de notificador no soportado.")
        };
    }
}

class Program
{
    static void Main()
    {
        INotificador n1 = NotificadorFactory.Crear("email");
        n1.Enviar("Hola desde Factory Method");

        INotificador n2 = NotificadorFactory.Crear("sms");
        n2.Enviar("Mensaje por SMS");
    }
}

