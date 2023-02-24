string[] originalArray = {"hello", "2", "world", ":)"};
List<string> shorterStrings = new List<string>();

foreach (string str in originalArray)
{
    if (str.Length <= 3)
    {
        shorterStrings.Add(str);
    }
}

string[] newArray = shorterStrings.ToArray();