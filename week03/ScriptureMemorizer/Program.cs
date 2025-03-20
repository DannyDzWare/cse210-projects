using System;


/*  The following features did I add
    - I created an own class for the template Scriptures.
        -> in that way, the Reference and the text can be stored as a string.
        -> the reference can be got as a Reference-class
    - The scriptures are stored in a List
    - With the programstart it will choose a random entry from the scripture list.
    - the HideRandomWords() Method needs a quantity of words that with each time will be hidden.
*/
class Program
{
    static void Main(string[] args)
    {
        //Contains the Scriptures and References
        List<ScriptureTemplate> listScriptures = new List<ScriptureTemplate>
        {
            new ScriptureTemplate("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life." ),
            new ScriptureTemplate("Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.")
        };
        int index = new Random().Next(0, listScriptures.Count);
        Scripture scripture = new Scripture(listScriptures[index].GetReference(), listScriptures[index].GetText());


   
        string userInput = "";

        while(userInput.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            if(scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();
            if(userInput.ToLower() != "quit")
            {
                scripture.HideRandomWords(3);
            }
            
        }
    }
}