// See https://aka.ms/new-console-template for more information
using PyRunner.NET;

var runner = new PythonRunner();
var result = await runner.RunScriptAsync("scripts/hello.py", ["Raj", "42"]);
Console.WriteLine(result);
