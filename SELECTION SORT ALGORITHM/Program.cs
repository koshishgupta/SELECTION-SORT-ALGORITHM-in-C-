namespace SELECTION_SORT_ALGORITHM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                           WELCOME TO MY PROGRAM      ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("ENTER A ARRAY SIZE:");
            int n=Convert.ToInt32( Console.ReadLine() );
            int[] arr= new int[n];
            for(int i=0; i<n; i++)
            {
                arr[i] = Convert.ToInt32( Console.ReadLine() ) ;
            }
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = i+1;j<n; j++)
                {
                    if(arr[i]> arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for(int i = 0;i < n; i++)
            {
                Console.WriteLine(arr[i]) ;
            }
        }

    }
}
