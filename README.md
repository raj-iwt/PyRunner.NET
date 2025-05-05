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
using PyRunner.NET;

var runner = new PythonRunner();
var result = await runner.RunScriptAsync("scripts/hello.py", ["Bob", "42"]);
Console.WriteLine(result);

// Output: Hello Bob, you are 42 years old.
```

## 🔧 Use Cases

Here are some powerful scenarios where **PyRunner.NET** can be useful:

- **Run AI/ML Models**  
  Seamlessly invoke Python-based machine learning models from your .NET applications without rewriting them in C#.

- **Scripted Plugins**  
  Enable scripting support in enterprise or desktop apps. Let users define logic using Python scripts that your .NET app can run dynamically.

- **Data Science Workflows**  
  Integrate data preprocessing, visualization, or analysis scripts written in Python as part of your data pipeline in .NET.

- **Legacy Reuse**  
  Call battle-tested Python libraries and tools (e.g., NumPy, Pandas, SciPy) from C# without porting them to .NET.

- **Hybrid Architectures**  
  Use Python for what it does best (data, ML, automation), and .NET for enterprise backend, UI, or API hosting.

## 🤝 Contributing

We welcome contributions of all kinds!

To contribute:

1. **Fork** the repository  
2. **Create a branch** for your feature or fix  
   ```bash
   git checkout -b feature/your-feature-name


---

### ✅ `License` section
```markdown
## 📜 License

This project is licensed under the **MIT License**.

You are free to use, modify, and distribute this software for personal or commercial use.

See the [LICENSE](LICENSE) file for full license text.
