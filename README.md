# SimpleCalculatorWithDLL

# What is a .dll file?
The use of DLLs helps promote modularization of code, code reuse, efficient memory usage, 
and reduced disk space. So, the operating system and the programs load faster, run faster, and take less disk space on the computer.





# Example of how to create a .dll file 
In this project, I am using c++ to create an DLL file

Step 1: Create an empty c++ project

Step 2: Right click on your c++ project in Solution Explorer and choose "Properties"

Step 3: Configuration Propeties > General > Configuration Type change to "Dynamic Library (.dll)" > Click Apply & OK

Step 4: Create a .cpp file in the Source Files

Step 5: Refer to https://github.com/wcyap1027/SimpleCalculatorWithDLL/blob/8fe4c50e4bfa8bb4c1b20f6b1bf31e6ace92ae3c/SumFunction/MyFunctions.cpp

Step 6: Right click your c++ project and build.





# Example of how to retrieve functions from .dll file in C#
Step 1: Get the path of your .dll file

Step 2: [DllImport(**yourdllfilename**, CallingConvention = CallingConvention.Cdecl)] to call your .dll file.

Step 3: Refer to https://github.com/wcyap1027/SimpleCalculatorWithDLL/blob/8fe4c50e4bfa8bb4c1b20f6b1bf31e6ace92ae3c/CalculatorDLL/Form1.cs

Step 4: Done & Run





# What are the functions inside the .dll file?
- AddNumbers()
- MinusNumber()
- MultiplyNumber()
- DivisionNumber()







