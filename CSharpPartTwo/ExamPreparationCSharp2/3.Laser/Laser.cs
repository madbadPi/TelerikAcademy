using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Laser
{
    static void Main()
    {
        if (File.Exists("input.txt"))
        {
            Console.SetIn(new StreamReader("input.txt"));
        }
        int[] dims = GetThreeNumsFromConsole();
        int[] pos = GetThreeNumsFromConsole();
        int[] vect = GetThreeNumsFromConsole();

        bool[, ,] visited = new bool[dims[0] + 1, dims[1] + 1, dims[2]+1];

        while (true)
        {
            visited[pos[0], pos[1], pos[2]] = true;
            int[] newPos = new int[3];
            for (int i = 0; i < 3; i++)
            {
                newPos[i] = pos[i] + vect[i];
            } 
            if (visited[newPos[0], newPos[1], newPos[2]]||
                HowManyIndexAreLimit(newPos, dims) >=2)
            {
                //new po
                Console.WriteLine("{0} {1} {2}", pos[0], pos[1], pos[2]);
                return;
            }
            if (HowManyIndexAreLimit(newPos, dims) == 1)
            {
                //we have hit wall   
                ReverseComponent(newPos, vect, dims);
            }

            for (int i = 0; i < 3; i++)
            {
                pos[i] = newPos[i];
            }
        }
    }

    private static void ReverseComponent(int[] newPos,int[] vect, int[] dims)
    {
        for (int i = 0; i < 3; i++)
        {
            if (newPos[i] == 1 && vect[i] == -1)
            {
                vect[i] *= -1;
            }
            else if(newPos[i] == dims[i] && vect[i]==1)       
            {
                vect[i] *= -1;
            }
        }
    }

    static int HowManyIndexAreLimit(int[] pos, int[] dims)
    {
        int count = 0;
        for (int i = 0; i < 3; i++)
        {
            if (pos[i] == 1 || pos [i] == dims[i])
            {
                count++;
            }
        }
        return count;
    }
    static int[] GetThreeNumsFromConsole()
    {
        string input = Console.ReadLine();
        string[] split = input.Split(' ');
        int[] array = new int[3];
        for (int i = 0; i < array.Length; i++)
		{
		    array[i] = int.Parse(split[i]);	 
        }
        return array;
    }    
}
