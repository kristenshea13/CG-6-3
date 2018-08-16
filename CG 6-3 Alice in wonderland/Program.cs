using System;

namespace CG_6_3_Alice_in_wonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The first sentence of Alice in Wonderland is below. Store this sentence in a string, 
             * and then prompt the user for a string to search for within this string. Print whether the search 
             * term was found. See if you can make the search case-insensitive, so that searching for “alice” prints true.*/

            //explain program and prompt user for word to search in one line of code using \n to add a line break and 
            //using Console.Write so user's entry is on the same line as the second sentence.
            Console.Write("Search for words in the very first sentence of Alice in Wonderland by Lewis Carroll. \nEnter word you would like to search: ");

            string toSearch = Console.ReadLine();

           string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, " +
                "and of having nothing to do: once or twice she had peeped into the book her sister was " +
                "reading, but it had no pictures or conversations in it, ‘and what is the use of a book,’ " +
                "thought Alice ‘without pictures or conversation?’ ";

           

            var search = alice.IndexOf(toSearch);

            //ToUpper or ToLower

            

            if (search == -1)
            {
                Console.WriteLine("Word not found.");
            }

            else
            {
                Console.WriteLine("Word found!");
            }

            //StringComparison search = StringComparison.OrdinalIgnoreCase;



           


        










Console.ReadLine();

}


}
}
