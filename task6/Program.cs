Console.WriteLine("Please Enter any number:");
int number = Convert.ToInt32(Console.ReadLine());
var str = number.ToString();
if (str.Length>2) Console.WriteLine("Third number - " + str[2].ToString());
else Console.WriteLine("No third digit.");