namespace DelegateHomework
{
    public delegate void Func(string str);

    class Run
    {
        public void RunFunc(Func func, string str)
        {
            func(str);
        }

    }


    class Methods
    {
        public void Space(string str)
        {
            string[] newStr = new string[str.Length * 2 - 1];
            newStr[0] = str[0].ToString();
            for (int i = 1; i < newStr.Length; i++)
            {
                if (i % 2 == 1)
                    newStr[i] = "_";
                else
                    newStr[i] = str[i / 2].ToString();
            }
            Console.Write("Space: ");
            foreach (var s in newStr)
            {
                Console.Write(s);
            }
            Console.WriteLine();
        }

        public void Reverse(string str)
        {
            string[] newStr = new string[str.Length];
            for (int i = 0, j = str.Length - 1; i < newStr.Length; i++, j--)
            {
                newStr[i] = str[j].ToString();
            }
            Console.Write("Reverse: ");
            foreach (var s in newStr)
            {
                Console.Write(s);
            }
            Console.WriteLine();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            var str = Console.ReadLine();
            Console.WriteLine();

            Methods methods = new Methods();
            Func funcDLG = new Func(methods.Space);
            funcDLG += methods.Reverse;
            Run run = new();
            run.RunFunc(funcDLG, str);
        }
    }

}