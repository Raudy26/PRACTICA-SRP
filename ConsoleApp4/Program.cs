using System;

public class EmailSender
{
    public void EnviarCorreo(string destinatario, string mensaje)
    {
       
    }
}
public class Persona
{
    private string nombre;
    private int edad;
    private string direccion;
    private string correoElectronico;

    public void ImprimirDatos()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Dirección: {direccion}");
        Console.WriteLine($"Correo electrónico: {correoElectronico}");
    }

    public void EnviarCorreo(string mensaje)
    {
    
        EmailSender emailSender = new EmailSender();
        emailSender.EnviarCorreo(correoElectronico, mensaje);
    }
}