using System;
using System.Net.Sockets;

public class Class1
{
	public Class1()
	{
		Console.WriteLine("Hello World!");
		const string message = "This is a constant string.";
		Socket socket = new Socket();
		socket.Connect("localhost", 8080);
		Console.WriteLine("Connected to the server at localhost:8080");
			
		try
        {
            socket.Send(System.Text.Encoding.UTF8.GetBytes(message));
            Console.WriteLine("Message sent: " + message);
        }
        catch (SocketException ex)
        {
            Console.WriteLine("Socket error: " + ex.Message);
        }
        finally
        {
            socket.Close();
            Console.WriteLine("Socket closed."); //testggh
        }

	}
}
