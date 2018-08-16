using System;

namespace CG_6_3_Alice_in_wonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //explain program and prompt user for word to search. consolidated in one line of code using \n to add a line break and 
            //Console.Write so user's entry is on the same line as the second sentence.
            Console.Write("Search for words in the very first sentence of Alice in Wonderland by Lewis Carroll. " +
                "\n Enter word you would like to search: ");

            //declare user entered word as string and give a variable name
            string toSearch = Console.ReadLine();
            //convert word to all caps. I converted both strings to all caps so case sensitivity would not be an issue in search
            toSearch = toSearch.ToUpper();


            //entered text for second string and named it. converted to all caps. explained above.
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, " +
                "and of having nothing to do: once or twice she had peeped into the book her sister was reading, " +
                "but it had no pictures or conversations in it, ‘and what is the use of a book,’ " +
                "thought Alice ‘without pictures or conversation?’ ";

            alice = alice.ToUpper();


            //used IndexOf to search alice for user entered variable. it returns a -1 if it does not find user word.
            var search = alice.IndexOf(toSearch);

            
            //if word is not in quote (index of returned a -1), print that it is not found.
            if (search == -1)
            {
                Console.WriteLine("Word not found.");
            }

            //if index of returned anything other than -1 it means the word was found in the quote. print word found to console.
            else
            {
                Console.WriteLine("Word found!");
            }


            Console.ReadLine();

}


}
}
