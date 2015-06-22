static void Main(string[] args)
{
    // string str_input = "ABC";
    string str_input = args[0];
    char[] chr_input = str_input.ToUpper().ToCharArray();
    StreamWriter myFile; // reference to file
    myFile = File.CreateText("example.txt");
    myFile.Close(); 
    permutations(str_input.Length, chr_input);
      
    // Console.ReadLine();
}
static public void permutations(int N, char[] Arr) 
{            
    if (N == 1)
    {
       using (StreamWriter sw = File.AppendText("example.txt"))
        {
            sw.WriteLine(new string(Arr));
        }
        Console.WriteLine(new string(Arr));
    }
    else 
    {
        for (int i = 0; i < N; i++) 
        {
            permutations( N-1 , Arr );
            if (N % 2 == 1)
            {
               // swap(0, n - 1);
               char t = Arr[0];
               Arr[0] = Arr[N-1];
               Arr[N - 1] = t;
            }
            else 
            {
              //  swap(i, n - 1);
                char t = Arr[i];
                Arr[i] = Arr[N - 1];
                Arr[N - 1] = t;
            }
        }
    }
}
