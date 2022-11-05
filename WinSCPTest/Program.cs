
// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using WinSCP;


try
{
    // Setup session options
    SessionOptions sessionOptions = new SessionOptions
    {
        Protocol = Protocol.Sftp,
        HostName = "hostname",
        UserName = "username",
        SshPrivateKeyPath = Path.Combine(Directory.GetCurrentDirectory(), "ppkfile.ppk"),
        SshHostKeyFingerprint = "fingerprint",
        PortNumber = 22,
        Timeout = TimeSpan.FromMinutes(30)
    };

    using (Session session = new Session())
    {
        // Connect
        session.Open(sessionOptions);
        Console.WriteLine("Opened");
    }

    return 0;


}
catch (Exception e)
{
    Console.WriteLine("Error: {0}", e);
    return 1;
}