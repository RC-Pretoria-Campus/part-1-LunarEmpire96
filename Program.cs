
using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Speech.Synthesis;

class Program
{

    static void Main()
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();

        //Configure the synthesizer
        synth.Volume = 100; 
        synth.Rate = 0;

        //Speak a message
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("┌[0-0]┐");
        Console.WriteLine("Chatbot: Hello! Welcome to the CyberSecurity Awareness Chatbot. I'm here to help.");
        synth.Speak(" Hello! Welcome to the CyberSecurity Awareness Chatbot. I'm here to help.");

        //request the user to input their name 
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Please input your name of choice "); 
        string userText = Console.ReadLine();

        Console.WriteLine("└[♥Д♥]┘");
        //Message to confirm user name
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Hello " + userText + ". How may I help you?");
        synth.Speak("Hello " + userText + "How may I help you? ");

        //request user input once more
        string userInput = Console.ReadLine();


        if (userInput == "How are you?")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("I'm doing fine. Safe and secure, thank you.");
            synth.Speak("I'm doing fine. Safe and secure, thank you.");
        }


        else if (userInput == "What is your purpose?")
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("I am a bot that was created with the purpose of properly educating you on the importance of cybersecurity as well as answering your queries to the best of my abilities");
            synth.Speak("I am a bot that was created with the purpose of properly educating you on the importance of cybersecurity as well as answering your queries to the best of my abilities. ");
        }

        else if (userInput == "What can I ask you about?")
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("You may ask me about what cybersecurity is, the importance of it in everyday life, as well as common threats to cybersecurity.");
            synth.Speak("You may ask me about what cybersecurity is, the importance of it in everyday life, as well as common threats to cybersecurity.");
        }

        else if (userInput == "What is cybersecurity?")
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("Cybersecurity refers to various methods, tools and strategies that are set in place to protect a computer from various digital threats like cyber attacks and unauthorized access from known and unknown parties and ensures that users can practice safe browsing. Examples of such threats are phishing, unethical hacking as well as password theft.");
            synth.Speak("Cybersecurity refers to various methods, tools and strategies that are set in place to protect a computer from various digital threats like cyber attacks and unauthorized access from known and unknown parties and ensures that users can practice safe browsing. Examples of such threats are phishing, unethical hacking as well as password theft.");
        }

        else if (userInput == "What is the importance of cybersecurity?")
        {
            //set text colour to green
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Cybersecurity assists in maintaining user security and safety by ensuring user data is protected and inaccessible to unwanted, unauthorized parties. This is done by reinforcing the strength of user passwords, frequent security checks, 2 factor verification as well as a quick response to security breaches.");
            synth.Speak("Cybersecurity assists in maintaining user security and safety by ensuring user data is protected and inaccessible to unwanted, unauthorized parties. This is done by reinforcing the strength of user passwords, frequent security checks, 2 factor verification as well as a quick response to security breaches.");
        }

        else if (userInput == "What are some threats to cybersecurity?")
        {

            // Set the Foreground color to blue 
            Console.ForegroundColor
                = ConsoleColor.Blue;

            Console.WriteLine("Examples of threats to cybersecurity is phishing, which is when attackers decieve users into giving away sensitive information through means such as emails or messages.");
            synth.Speak("Examples of threats to cybersecurity is phishing, which is when attackers decieve users into giving away sensitive information through means such as emails or messages.");
        }

        else 
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("[・╭╮・]┘");
            Console.WriteLine("I didn't understand that question. Please try again.");
            synth.Speak("I didn't understand that question. Please try again.");
        }


    }
}
