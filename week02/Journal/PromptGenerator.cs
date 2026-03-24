/*Author: Marcos Alas
Project: Journal app*/
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Whom did I feel more happy next to today?",
        "Which is the best word I heard today?",
        "Who talked to my about our Lord today?",
        "How did I feel in the morning today?",
        "Did I feel more motivated to continue BYU with today's activities?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}