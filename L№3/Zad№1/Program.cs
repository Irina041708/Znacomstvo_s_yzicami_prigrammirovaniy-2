
String text = "тарам памапам - = -ю"
                +"тарам "
                +"Люлякебаб .";
string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty; // инициализация пустой строки

    int Length = text.Length;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;

}
string newText = Replace (text, ' ' ,  '|' );
Console.WriteLine(newText);
