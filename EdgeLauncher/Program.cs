using System.Diagnostics;

// Launch
const string edge = "msedge";
var cmd_args = "/c start " + edge;

// Read the console parameters
if (args.Length > 0) cmd_args += " " + args[0];
Process.Start("cmd", cmd_args);

// Limit can only run one
if (Process.GetProcessesByName("edgelauncher").Length > 1) return;

// Wait for the browser to close
while (true)
{
    Thread.Sleep(30000);
    if (Process.GetProcessesByName(edge).All(p => p.MainWindowHandle == 0)) break;
}

// Close all processes
var ps = Process.GetProcessesByName(edge);
foreach (var p in ps) p.Kill();