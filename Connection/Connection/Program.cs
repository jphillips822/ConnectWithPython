using System;
using System.Diagnostics; // Process
using System.IO; // StreamWriter

namespace PythonConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 2;

            Process p = new Process(); // create process (i.e., the python program)
            p.StartInfo.FileName = "c:\\Python27\\python.exe";
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false; // make sure we can read the output from stdout
            p.StartInfo.Arguments = "c:\\Users\\jphillips\\Desktop\\PythonTest.py " + a + " " + b; // start the python program with two parameters
            p.Start(); // start the process (the python program)
            StreamReader s = p.StandardOutput;
            String output = s.ReadToEnd();
            string[] r = output.Split(new char[] { ' ' }); // get the parameter
            Console.WriteLine(r[0]);
            p.WaitForExit();

            Console.ReadLine(); // wait for a key press
        }
    }
}
