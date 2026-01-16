using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What’s one thing that made me feel calm or happy today, and why?",
        "What’s something I’m worried about right now—and what’s one small thing I can do about it?",
        "What’s a recent moment I’m proud of, even if it seems small?",
        "If I could talk to my past self from one year ago, what advice or reassurance would I give?",
        "What’s something I need more of in my life right now (rest, fun, honesty, boundaries, etc.)?",
        "What does my ideal day look like, from morning to night?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}