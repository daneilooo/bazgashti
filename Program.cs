int[,] parent = new int[6, 3];
int  w = 0, e = 0, r = 0, t = 0, u = 0, o = 0;
int x = 1, y = 1, b = 1;
// ask user if he want to difine array
Console.WriteLine("do you wanna enter the numbers?(y/n)");
while (x != 0)
{
    string respone = Console.ReadLine();
    if (respone == "y" || respone == "Y")
    {
        //getting array from user
        Console.Clear();
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                while (y != 0)
                {
                    try
                    {
                        Console.Write("enter number of row {0}, col {1} => ", i + 1, j + 1);
                        parent[i, j] = int.Parse(Console.ReadLine());
                        y = 0;
                    }
                    catch
                    {
                        Console.WriteLine("enter number!");
                    }
                }
                b++;
                y = 1;
            }
        }
        // showing array
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(parent[i, j] + "\t");
            }
            Console.Write("\n");
        }
        x = 0;
    }
    else if (respone == "n" || respone == "N")
    {
        // set default array
        parent[0, 0] = 1;
        parent[0, 1] = 9078;
        parent[0, 2] = 0;
        parent[1, 0] = 2;
        parent[1, 1] = 657;
        parent[1, 2] = 0;
        parent[2, 0] = 3;
        parent[2, 1] = 64564;
        parent[2, 2] = 1;
        parent[3, 0] = 4;
        parent[3, 1] = 65756;
        parent[3, 2] = 3;
        parent[4, 0] = 5;
        parent[4, 1] = 53543;
        parent[4, 2] = 2;
        parent[5, 0] = 2;
        parent[5, 1] = 123;
        parent[5, 2] = 2;

        Console.Clear();
        //show
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(parent[i, j] + "\t");
            }
            Console.Write("\n");
        }
        x = 0;
    }
    else
    {
        Console.WriteLine("enter corret answer!");
    }
}
Console.Write("enter your top number => ");
int z = int.Parse(Console.ReadLine());

int[] javab = bazgasht(z,parent);
int[] bazgasht(int z, int[,] parent)
{
   // making simple array to get paarents
    int q = 0;
    int[] yek = new int[6];
    if (z == 0)
    {
            for (int i = 0; i < 6; i++)
            {
                if (parent[i, 2] == 0)
                {
                    yek[q] = parent[i,0] ;
                    q++;
                }
            }
        Console.Write("{0} = ", z);
        for (int i = 0; i < q; i++)
        {
            if (i == q - 1)
            {
                Console.Write(yek[i]);
            }
            else
            {
                Console.Write(yek[i] + ",");
            }
        }
        return yek;
    }
    else if (z > 0) 
    {
            for (int i = 0; i < 6; i++)
            {
                if (parent[i, 2] == z)
                {
                    yek[q] = parent[i, 0];
                    q++;
                }
            }
        Console.Write("{0} = ",z);
        for (int i = 0;i < q; i++) 
        {
            if (i == q - 1)
            {
                Console.Write(yek[i]);
            }
            else
            {
                Console.Write(yek[i] + ",");
            }
           
        }
        Console.WriteLine();
    }
    return bazgasht(z-1,parent);
}
        