// 1
// create an int array
// fill with numbers of 1 - 5
// loop through the numbers and display all to console

int[] ex1 = { 1, 2, 3, 4, 5 };          
foreach (int i in ex1)
{
    Console.WriteLine(i);
}

// for (int i = 0; i < ex1.Length; i++
// {
//    Console.WriteLine(ex1[i]);
// }


// 2
// Ask the user for a sentence. Save it in a string
// Split the sentence into an array of words (strings)
// Display each word in console

Console.WriteLine("Provide a sentence");
string sentence = Console.ReadLine();
string[] words = sentence.Split(" ");
foreach (string w in words)
{
    Console.WriteLine(w);
}


// 3
// Make a method called AvgArray
// take in a double array
// return a double
// find the average of the values in the array and return it

double[] ex3 = { 5.00, 10.00, 15.00 };
Console.WriteLine(AvgArray(ex3));
static double AvgArray(double[] nums)
{
    //return nums.Average();
    double total = 0;
    foreach (double n in nums)
    {
        total += n;
    }
    return total / nums.Length;
}


// 4
// Method called FindIndex
// take in a string list and a string    // take in or parameter go in ()
// return an int
// look through the string list and return the index of the string parameter
// if not found, return -1
//"egg", "bacon", "cheese"
// "bacon"
// return 1

List<string> sandwich = new List<string>() { "egg", "bacon", "cheese" };
Console.WriteLine(FindIndex(sandwich, "bacon"));
static int FindIndex(List<string> strings, string searchWord)
{
    //return strings.FindIndex(s => s == searchWord);      // Linq method

    int index = -1;
    for (int i = 0; i < strings.Count; i++)         // lists uses .Count not .Length
    {
        if (strings[i] == searchWord)
        {
            index = i;
        }
    }
    return index;
}