using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el mensaje:");
        string mensaje = Console.ReadLine();

        string mensajeCifrado = Cifrar(mensaje);
        Console.WriteLine($"Mensaje cifrado: {mensajeCifrado}");

        string mensajeDescifrado = Descifrar(mensajeCifrado);
        Console.WriteLine($"Mensaje descifrado: {mensajeDescifrado}");

        // Pausa para que la consola no se cierre inmediatamente
        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }

    static string Cifrar(string mensaje)
    {
        char[] vocales = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        char[] sustituciones = { '1', '2', '3', '4', '5', '1', '2', '3', '4', '5' };

        for (int i = 0; i < mensaje.Length; i++)
        {
            for (int j = 0; j < vocales.Length; j++)
            {
                if (mensaje[i] == vocales[j])
                {
                    mensaje = mensaje.Remove(i, 1).Insert(i, sustituciones[j].ToString());
                    break;
                }
            }
        }

        return mensaje;
    }

    static string Descifrar(string mensaje)
    {
        char[] vocales = { '1', '2', '3', '4', '5' };
        char[] originales = { 'a', 'e', 'i', 'o', 'u' };

        for (int i = 0; i < mensaje.Length; i++)
        {
            for (int j = 0; j < vocales.Length; j++)
            {
                if (mensaje[i] == vocales[j])
                {
                    mensaje = mensaje.Remove(i, 1).Insert(i, originales[j].ToString());
                    break;
                }
            }
        }

        return mensaje;
    }
}

