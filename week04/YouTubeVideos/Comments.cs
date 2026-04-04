// Author: Marcos Alas
// Date: 2026-04-04
// Program: YouTube Video Code
public class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }
    public Comment(string name, string text)
    {
        CommenterName = name;
        Text = text;
    }
}

/* Separate files for each individual class
First class: Coomments 
*/