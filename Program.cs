using System;
using System.Text;

// IsPalindrome returns a tuple of two values
(bool, int) IsPalindrome(string sai) {
    string tharun;

    // Convert the string to upper-case
    tharun = sai.ToUpper();

    // Use a StringBuilder to strip out all the punctuation
    var sb = new StringBuilder();
    foreach (char c in tharun) {
        // Add characters to the builder if not punctuation or white space
        if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c)) {
            sb.Append(c);
        }
    }
    // Convert the builder to the finished string
    tharun = sb.ToString();

    // compare characters starting at beginning and end of string
    int i=0, j=tharun.Length-1;
    // if the indexes cross each other, then we're done
    while (i <= j) {
        // if the character at each index doesn't match, it's not a palindrome
        if (tharun[i] != tharun[j]) {
            return(false, 0);
        }
        // update the counters and try again
        i++;
        j--;
    }
    // if we reach this point, we must have a palindrome
    return (true, sai.Length);
}

string s="";
(bool b, int l) result;
Console.WriteLine("Let's begin:");
while (s != "exit") {
    s = Console.ReadLine();
    if (s != "exit") {
        result = IsPalindrome(s);
        Console.WriteLine($"Palindrome: {result.b}, Length: {result.l}");
    }
}