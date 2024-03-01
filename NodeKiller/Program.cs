using System.Diagnostics;

Process.GetProcessesByName("node").ToList().ForEach(process => process?.Kill());