using System;

public class Class1

{
	public static void QuestionOne()
	{
        byte byteOne = 1;
        sbyte sbyteOne = 1;
        short shortOne = 1;
        int intOne = 1;
        long longOne = 1;
        float floatOne = 1.543f;
        double doubleOne = 2345.76534d;
        decimal decimalOne = 627637263.36263726372M;
        char charOne = 'A';
        bool boolOne = true;
        Console.WriteLine(byte.MaxValue);
        Console.WriteLine(sbyte.MaxValue);
        Console.WriteLine(short.MaxValue);
        Console.WriteLine(int.MaxValue);
        Console.WriteLine(long.MaxValue);
        Console.WriteLine(float.MaxValue);
        Console.WriteLine(double.MaxValue);
        Console.WriteLine(decimal.MaxValue);

    }
	public static void QuestionThreeC()
	{
		String strFreinds = "Tom and Jerry are good friends";
		Console.writeLine($"Char Count: { strFreinds.Length}" )
	}
	public static void QuestionThreeD() {
		string strFriends = "Tom and Jerry are good friends";
		string strPart = strFreinds.Substring(10, 5);
		Console.WriteLine(strFriends);
		Console.WriteLine(strPart);

    }
	public static void questionFour()
	{
		Console.Writeline("Enter Name");
		string name = Console .ReadLine();
		int len = new.Trim().Length();
		if ( len > 0)
		{
			string errorMessage = "Name is Less than char ";
			throw new Exception(errorMessage);

		}
		char[] nameCharArray = name.Trim().ToUpper().ToCharArray();
	}
	public static int Price = 200;
	public readonly 
	public static void TestStaticConstantReadOnly()
	{
		Console.WriteLine($"Constant Value: {TestOneAnswers.Pi}");
		Console.WriteLine($"Static Value: {TestOneAnswers.Price}");

	}
    public static void questionSix()
    {

        public static void questionSeven() {
		int v1 = 35;
		int v2 = 55;
		Console.WriteLine($"v1 ={v1}, v2 = {v2}");

	}
	public static void swap() {
		int x = x * y;
		int y = x - y;
		int x = x - y;
	}
}
