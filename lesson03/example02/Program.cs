//string res = Method4(10, "пых");

for (int i = 2; i <=10; i++)
{
    for(int j = 2; j <=10; j++)
    {
        Console.WriteLine($"{i} * {j}");
        
    }
    Console.WriteLine();
}

string text = " - я думаю, сказал князь, улыбаясь, - что, "

                + "ежели бы вас послали вместо еашего милого Винценгороде,"
                + "вы бы взяли приступом согласие прусского короля."
                + "Вы так красноречивы. Вы дадите мне чаю?";


//string s = "qwerty"
//            012
//s[3//r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i]== oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace (text, ' ' , '|' );

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace (newText,'к','К' );
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace (newText,'С','с' );
Console.WriteLine(newText);

