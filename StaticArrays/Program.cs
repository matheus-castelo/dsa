namespace StaticArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // STATIC ARRAY
            var staticArray = new int[5] { 1, 2, 3, 4, 5 };

            PrintTitle("Printing Static Array");
            PrintCollection(staticArray);
            
            staticArray[4] = 100;  // O[1] Complexity
            PrintTitle("Printing Updated Static Array");
            PrintCollection(staticArray);
            
            PrintTitle("Printing Element at Index 4");
            Console.WriteLine(staticArray[4]);; // O[1] Complexity
            
            PrintTitle("Removing i-th Element from Static Array");
            // O(1) Complexity (the memory will not dealocate)
            staticArray[2] = 0; // "Removing"
            PrintCollection(staticArray);
            
            PrintTitle("Forcing an Error (staticArray[5]) = 6");
            try
            {
                // Forcing an IndexOutOfRangeException
                staticArray[5] = 6; 
            }
            catch (IndexOutOfRangeException ex)
            {
                PrintError($"Erro: {ex.Message}");
            }
        }
        /*
         Summarizing Static Array Operations:
           
           r/w i-th element	O(1)	
           
           Insert / Remove End	O(1)	
           
           Insert Middle	O(n)	(worst case, you will have to shift elements)
           
           Remove Middle	O(n)	(worst case, you will have to shift elements)
          
         */
        
        
        
        
/*#######################################################3###########################################################*/
        // O(n) Complexitiy
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
                Console.WriteLine(item);
        }

        static void PrintTitle(string title)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n=== {title} ===");
            Console.ResetColor();
        }

        static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}