using System.Net;
using System.Net.Sockets;

public sealed class HttpServer 
{
    private TcpListener Controller;

    private int RequestCount = 0;

    public HttpServer(int port = 8080) 
    {
        var address = IPAddress.Parse("localhost");
        Controller = new TcpListener(address, port);
    }

    public async Task ReceiveRequest() 
    {
        ///
    }
}