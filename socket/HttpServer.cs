
using System.Net;
using System.Net.Sockets;
using System.Text;

public sealed class HttpServer
{
    private TcpListener Server;

    public HttpServer(int port = 8080)
    {
        Server = new TcpListener(IPAddress.Parse("127.0.0.1"), port);
        Server.Start();
        Console.WriteLine($"The server is open on http://localhost:{port}");
        Up();
    }

    public void Up()
    {
        while (true)
        {
            Socket socket = Server.AcceptSocket();
            byte[] bytes = new byte[3024];
            int bytesReceived = socket.Receive(bytes);
            File.WriteAllBytes("./receive.txt", bytes);
            Send(socket);
        }
    }

    public void Send(Socket socket)
    {
        string responseBody = "{ \"nome\": \"Gabriel\"}";

        string response =
            "HTTP/1.1 404 Not Found\r\n" +
            "Content-Type: application/json\r\n" +
            "Content-Length: " + responseBody.Length + "\r\n" +
            "\r\n" +
            responseBody; 

        byte[] bytes = Encoding.UTF8.GetBytes(response);
        socket.Send(bytes);
    }
}