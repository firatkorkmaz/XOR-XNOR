# XOR & XNOR Logical Operations in C#
A simple program to perform XOR & XNOR logical operations in C-Sharp.

## General Information
This is a simple C# console program to print the truth table of XOR & XNOR logical operations on two binary inputs.

```
XOR (X, Y) = X'.Y + X.Y'
XNOR(X, Y) = X.Y + X'.Y'
```

| X | Y | XOR   | XNOR  |
|---|---|-------|-------|
| 0 | 0 | False | True  |
| 0 | 1 | True  | False |
| 1 | 0 | True  | False |
| 1 | 1 | False | True  |
	
## Technologies
This project is created with:
* Microsoft Visual Studio
  * C# Console Application

## Setup & Run
To run this project, open the **XOR_XNOR.sln** solution file with Visual Studio, then build and run this solution, or use C# compiler to directly compile the **Program.cs** file and run the created executable (.exe) file:
```
csc Program.cs
```
