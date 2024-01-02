using Amazon.Runtime.CredentialManagement;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var sharedFile = new SharedCredentialsFile();
        List<string> profileNames = sharedFile.ListProfileNames().ToList();

        foreach (var profileName in profileNames)
        {
            Console.WriteLine(profileName);
        }
    }
}