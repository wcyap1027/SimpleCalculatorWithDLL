#define MyFunctions _declspec(dllexport)

extern "C" {

	//add function
	MyFunctions int AddNumbers(int a, int b)
	{
		return a + b;
	}

	//minusfunction
	MyFunctions int MinusNumbers(int a, int b)
	{
		return a - b;
	}


	//multiplyfunction
	MyFunctions int MultiplyNumbers(int a, int b)
	{
		return a * b;
	}

	//divisionfunctions
	MyFunctions int DivisionNumbers(int a, int b)
	{
		return a / b;
	}

}