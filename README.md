# SimpleCalculatorWithDLL

In this project, I am using c++ to create an DLL file and using c# to call all the functions from the dll file.

[DllImport(SumFunctionsDLL, CallingConvention = CallingConvention.Cdecl)]

Main ---> "\CalculatorDLL\
DLL  ---> "\SumFunction\"


What is a .dll file?
The use of DLLs helps promote modularization of code, code reuse, efficient memory usage, 
and reduced disk space. So, the operating system and the programs load faster, run faster, and take less disk space on the computer.

What are the functions inside the .dll file?
- AddNumbers()
- MinusNumber()
- MultiplyNumber()
- DivisionNumber()







