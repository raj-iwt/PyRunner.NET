using System.Diagnostics;
using System.Text;

namespace PyRunner.NET
{
    public class PythonRunner
    {
        private readonly string _pythonExe;

        public PythonRunner(string pythonExe = "python")
        {
            _pythonExe = pythonExe;
        }

        public async Task<string> RunScriptAsync(string scriptPath, string[] args = null!)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = _pythonExe,
                Arguments = BuildArguments(scriptPath, args),
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.UTF8,
                StandardErrorEncoding = Encoding.UTF8
            };

            var process = new Process { StartInfo = startInfo };

            var output = new StringBuilder();
            var error = new StringBuilder();

            process.OutputDataReceived += (sender, e) => { if (e.Data != null) output.AppendLine(e.Data); };
            process.ErrorDataReceived += (sender, e) => { if (e.Data != null) error.AppendLine(e.Data); };

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            await process.WaitForExitAsync();

            if (process.ExitCode != 0)
                throw new Exception($"Script error: {error}");

            return output.ToString();
        }

        private string BuildArguments(string scriptPath, string[] args)
        {
            var argList = args?.Select(a => $"\"{a}\"") ?? Enumerable.Empty<string>();
            return $"\"{scriptPath}\" {string.Join(" ", argList)}";
        }
    }
}
