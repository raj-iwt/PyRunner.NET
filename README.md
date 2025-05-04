# PyRunner.NET

**Run Python seamlessly inside .NET applications.**

PyRunner.NET is a developer-friendly .NET SDK that lets you run Python scripts and functions from C# with ease. It wraps Python.NET (or IronPython) under the hood and adds:
- ✅ Async script execution
- ✅ Type-safe interop between C# and Python
- ✅ Output streaming & error handling
- ✅ Optional script sandboxing
- ✅ Clean integration with ASP.NET Core

---

## 🚀 Why PyRunner.NET?

.NET and Python often live in separate stacks. PyRunner.NET brings them together—allowing you to:
- Invoke ML models written in Python from .NET apps
- Add dynamic rule-based logic from Python scripts
- Enable scripting for plugins in enterprise apps

---

## 🔧 Usage Example

```csharp
var result = await _pythonRunner.InvokeFunctionAsync(
    scriptPath: "scripts/math_utils.py",
    functionName: "square_root",
    args: new object[] { 25 }
);
// Output: 5.0
