# PinballruleEngine
A robust C# rules engine built around lexical analysis for interpreting and executing string‑based expressions. Whether you're validating inputs, evaluating custom string conditions, or applying dynamic logic rules, this engine has you covered.

**Key Features**
Lexical Parsing
Parses rule definitions from string inputs into tokens for structured analysis and execution.

Full Expression Support
Handles complex rule expressions—logical operators, nested function calls, arithmetic, comparisons, and more.

Reverse Evaluation
Uniquely supports backward logic: you can derive inputs based on expected outputs—a powerful asset for testing and diagnostics.

Dynamic Functions
Includes built-in functions you can invoke within rules, and it's extensible—easily add your own custom functions.

Rule Composition
Combine multiple rules logically (AND, OR, NOT), and evaluate them as a cohesive group.

Runtime Evaluation
Evaluate rules dynamically at runtime using plain C# strings—no need for pre-compilation or domain-specific languages.

**Use Cases**
Rule Validation: Dynamically evaluate validation rules defined as strings.

Data Filtering: Apply filtering or transformation logic defined at runtime.

Diagnostic Tools: Use reverse evaluation to trace how inputs lead to failures.

Custom DSLs: Craft a lightweight domain-specific language powered by expression evaluation.

**Getting Started**
Clone the repo

Build the solution in Visual Studio or via dotnet build

Add references to the main RuleEvaluator or lexical parser classes

Write string-based rules and evaluate them in your C# code

**Ideal For**
Developers building dynamic rule-driven systems, validation engines, or diagnostic tools

Anyone looking to embed custom logic at runtime with minimal effort
