using Photon.SocketServer;
using System;
public class ChatServer : ApplicationBase
{
    protected override PeerBase CreatePeer(InitRequest initRequest)
    {
        return new ChatPeer(initRequest);
    }

    protected override void Setup()
    {

    }

    protected override void TearDown()
    {
        Console.WriteLine("[TearDown] Server is stopped!!!!!");
    }
}