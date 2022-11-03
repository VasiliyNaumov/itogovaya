Console.Clear(); 
string PrintText(string[] text) 
{ 
    return "[" + String.Join(' ' , text ) + "]"; 
} 
string[] DelElements(string[] text) 
{ 
    string newText = string.Empty; 
    for (int index = 0; index < text.Length; index++) 
    { 
        string Word = text[index]; 
        if (Word.Length <= 3) 
        { 
            newText = newText + Word + " "; 
        } 
    } 
    string[] arrayText = newText.Split(' '); 
    return arrayText; 
} 
Console.WriteLine("Введите текст и нажмите клавишу Enter"); 
Console.WriteLine("Если нажать Enter не вводя текст, то программа запустит встроенный текст"); 
Console.WriteLine(); 
string enter = Console.ReadLine(); 
if (enter == String.Empty) 
{ 
    string[] text = { "СМИ", "сообщили,", "что", "Илон", "Маск", "договорился", "с", "международными", "инвесторами", "о", "предоставлении", "ему", "$13", "млрд:", "заёмных", "средств", "на", "покупку", "Twitter" }; 
    Console.WriteLine(PrintText(text)); 
    Console.WriteLine(); 
    string[] arrayText = DelElements(text); 
    Console.WriteLine(PrintText(arrayText)); 
} 
else 
{ 
    Console.WriteLine(); 
    string[] text = enter.Split(' '); 
    string[] arrayText = DelElements(text); 
    Console.WriteLine(PrintText(arrayText)); 
}