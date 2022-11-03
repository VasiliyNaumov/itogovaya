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