# Streams, Exceptions, Dispose pattern and TCP Communication

## Materials & Resources

| Material                                                                                                                                                              |    Time |
| :-------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------: |
| [File read and write](https://channel9.msdn.com/Series/C-Sharp-Fundamentals-Development-for-Absolute-Beginners/while-Iterations-and-Reading-Data-from-a-Text-File-11) |   11:38 |
| [using keyword](https://www.youtube.com/watch?v=Dxbbtx-8MKw)                                                                                                          |    5:35 |
| [exceptions](https://www.youtube.com/watch?v=DzUFm2FNeyo)                                                                                                             |    6:56 |
| [TCP/IP Client Server](https://www.youtube.com/watch?v=ve2LX1tOwIM)                                                                                                   |   10:11 |
| [TCP/IP Server & Client Communication](https://www.youtube.com/watch?v=55mH-gYd0TQ)                                                                                   |   14:09 |
| [TcpListener and TcpClient (an easy-to-use example)](https://www.tabsoverspaces.com/6188-tcplistener-and-tcpclient-an-easy-to-use-example)                            | reading |

## Optional

PLC TCP Communication: http://www.infoplc.net/files/descargas/siemens/infoplc_net_the_guide_about_tcpip_connections_between_pcs_and_siemens_plcs.pdf

Restart background worker: https://stackoverflow.com/questions/1005480/restart-background-worker

## Environment

Install TCP tester tool:

- [Packet Sender](https://packetsender.com/)
- [SocketTest](http://sockettest.sourceforge.net/)

## Material Review

- What's a Stream in .NET?
- How to read the contents of a file?
- How to use `StreamReader` and `StreamWriter`?
- What's an Exception?
  - How to handle exceptions in your code using `try`, `catch` and `finally`?
- What are managed and unmanaged resources?
- What's the Dispose Pattern?
- How to use a class that implements `IDisposable`?
- What is multi-threading and the UI thread?
  - What's a BackgroundWorker?
  - How do I restart the background worker?
- What's TCP?
- What's a Berkeley socket?
- How to use `Socket`, `TcpListener` and `TcpClient` classes?

## Workshop

### Exceptions

- [Divide by zero](../workshop/file-manipulations/divide-by-zero/DivideByZero.cs)

### Reading files

- [Print each line](../workshop/file-manipulations/print-each-line/PrintEachLine.cs)
- [Count lines](../workshop/file-manipulations/count-lines/CountLines.cs)

### Writing files

```csharp
using System;
using System.IO;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"./lorem-ipsum.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Hello from the file!");
            }
        }
    }
}
```

- [Write single line](../workshop/file-manipulations/write-single-line/WriteSingleLine.cs)
- [Write multiple lines](../workshop/file-manipulations/write-multiple-lines/WriteMultipleLines.cs)

### TCP Communication

Here is an example of creating a TCP server using C# built-in class:

```csharp
TcpListener listener = new TcpListener(IPAddress.Any, port);

listener.Start();

TcpClient client = listener.AcceptTcpClient();
Stream stream = client.GetStream();

using(var reader = new StreamReader(stream))
{
    string response = reader.ReadToEnd();
}

Console.WriteLine(response);
```

And another example to have a TCP client and send

```csharp
TcpClient client = new TcpClient("127.0.0.1", 8080);

var clientStream = client.GetStream();

using (var streamWriter = new StreamWriter(clientStream))
{
    streamWriter.WriteLine("This is a nice message");
}
```

### P2P Chat application

[Follow this link to the P2P chat app](../project/p2p-chat-desktop/README.md)
