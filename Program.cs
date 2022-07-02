/*bool Palindrome(string input) {
    string reverse = string.Empty;
    for (int i = input.Length - 1; i >= 0; i--)
    {
        reverse += input[i].ToString();
    }
    if (reverse == input) return true;
    return false;
    }
    Console.Write("Input number: ");
    var input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("No input");
        return;
    }
    bool inputIsPalindrome = Palindrome(input);
    if (inputIsPalindrome) Console.WriteLine($"{input} is a palindrome");
    else Console.WriteLine($"{input} is not a palindrome"); */

/*double distance(int x1, int y1, int z1, int x2, int y2, int z2) { 
    double deltaX = x1 - x2; 
    double deltaY = y1 - y2; 
    double deltaZ = z1 - z2;
 
    return (double) Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ); 
} 
             
Console.Write("Input x1: "); 
var inputx1 = Console.ReadLine(); 
Console.Write("Input y1: "); 
var inputy1 = Console.ReadLine(); 
Console.Write("Input z1: "); 
var inputz1 = Console.ReadLine(); 
             
Console.Write("Input x2: "); 
var inputx2 = Console.ReadLine(); 
Console.Write("Input y2: "); 
var inputy2 = Console.ReadLine(); 
Console.Write("Input z2: "); 
var inputz2 = Console.ReadLine(); 
             
if (Int32.TryParse(inputx1, out int parsedx1) && Int32.TryParse(inputy1, out int parsedy1) && Int32.TryParse(inputz1, out int parsedz1) && Int32.TryParse(inputx2, out int parsedx2) && Int32.TryParse(inputy2, out int parsedy2) && Int32.TryParse(inputz2, out int parsedz2)) { 
    Console.WriteLine($"Distance between coordinates is {distance(parsedx1, parsedy1, parsedz1, parsedx2, parsedy2, parsedz2)}"); 
} 
            
else { 
    Console.WriteLine("Data not valid"); 
}
*/

List<int> GetCubeNumbers(int N) { 
    var list = new List<int>(); 
           
    for (int i = 1; i <= N; i++) { 
        list.Add(i * i * i); 
    } 
           
    return list; 
} 
          
Console.Write("Write N: "); 
var inputN = Console.ReadLine(); 
             
if(Int32.TryParse(inputN, out int parsedN)) { 
    var list = GetCubeNumbers(parsedN); 
              
    Console.WriteLine($"Cube numbers from 1 to {parsedN}:"); 
    foreach (var number in list) Console.WriteLine(number); 
} 
             
else { 
    Console.WriteLine("Input is not a valid number"); 
}