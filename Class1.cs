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

public class ProgramHandler
{
    public void ExitProgram()
    {
        try
        {
            // 종료 전 필요한 정리 작업 수행
            Console.WriteLine("프로그램을 종료합니다...");

            // 프로그램 종료
            Environment.Exit(0);
        }
        catch (Exception ex)
        {
            Console.WriteLine("프로그램 종료 중 예외 발생: " + ex.Message);
        }
    }
}
