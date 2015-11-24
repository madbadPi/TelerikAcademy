using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ball
{    
    public int BallWidth { get; set; }
    public int BallHeight { get; set; }
    public int BallDepth { get; set; }
    public Ball(int width, int height, int depth)
    {
        this.BallWidth = width;
        this.BallHeight = height;
        this.BallDepth = depth;
    }
    public Ball (Ball ball)
    {
        this.BallWidth = ball.BallWidth;
        this.BallHeight = ball.BallHeight;
        this.BallDepth = ball.BallDepth;
    }
}

class ThreeDSlides
{
    private static int width, depth, height;
    private static string[, ,] cube;
    private static Ball cubeBall;

    static void Main(string[] args)
    {
        ReadInput();
        PricessesBallCommandes();
    }

    private static void PricessesBallCommandes()
    {
        while (true)
        {
            string currentCell = cube[cubeBall.BallWidth, cubeBall.BallHeight, cubeBall.BallDepth];
            string[] splitedCell = currentCell.Split();

            string command = splitedCell[0];
            switch (command)
            {
                case "S":
                    ProcessBallSlides(splitedCell[1]);
                    break;
                case "T":
                    cubeBall.BallWidth = int.Parse(splitedCell[1]);
                    cubeBall.BallDepth = int.Parse(splitedCell[2]);
                    break;
                case "B":
                    PrintMessage();
                    return;
                case "E":
                    if (cubeBall.BallHeight == height -1)
                    {
                        PrintMessage();
                    }
                    else
                    {
                        cubeBall.BallHeight++;
                    }                    
                    break;
                default: 
                    throw new ArgumentException("Invalid command");
                    
            }
        }
    }

    private static void ProcessBallSlides(string command)
    {
        Ball newCubeBall = new Ball(cubeBall);
        switch (command)
        {
            case "R":
                newCubeBall.BallWidth++;
                newCubeBall.BallHeight++;
                break;
            case "L":
                newCubeBall.BallWidth--;
                newCubeBall.BallHeight++;
                break;
            case "F":
                newCubeBall.BallDepth--;
                newCubeBall.BallHeight++;
                break;
            case "B":
                newCubeBall.BallDepth++;
                newCubeBall.BallHeight++;
                break;
            case "FL":
                newCubeBall.BallDepth--;
                newCubeBall.BallWidth--;
                newCubeBall.BallHeight++;
                break;
            case "FR":
                newCubeBall.BallDepth--;
                newCubeBall.BallWidth++;
                newCubeBall.BallHeight++;
                break;
            case "BL":
                newCubeBall.BallDepth++;
                newCubeBall.BallWidth--;
                newCubeBall.BallHeight++;
                break;
            case "BR":
                newCubeBall.BallDepth++;
                newCubeBall.BallWidth++;
                newCubeBall.BallHeight++;
                break;
            default:
                throw new ArgumentException("Invalid command");
                
        }
        if (IsPassable(newCubeBall))
        {
            cubeBall = new Ball(newCubeBall);
        }
        else
        {
            PrintMessage();
            Environment.Exit(0);
        }
    }

    private static void PrintMessage()
    {
        string currentCell = cube[cubeBall.BallWidth, cubeBall.BallHeight, cubeBall.BallDepth];

        if (currentCell == "B" || cubeBall.BallHeight != height-1)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("Yes");
        }
        Console.WriteLine("{0} {1} {2}", cubeBall.BallWidth, cubeBall.BallHeight, cubeBall.BallDepth);
    }

    private static bool IsPassable(Ball ball)
    {
        if(ball.BallWidth >=0 && ball.BallHeight >=0 && ball.BallDepth >=0 &&
            ball.BallWidth < width && ball.BallHeight < height && ball.BallDepth < depth)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
     
    private static void ReadInput()
    {
        string[] rawNumbers = Console.ReadLine().Split();
        width = int.Parse(rawNumbers[0]);
        height = int.Parse(rawNumbers[1]);
        depth = int.Parse(rawNumbers[2]);

        cube = new string[width, height, depth];

        for (int h = 0; h < height; h++)
        {
            string[] lineFragment = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
            for (int d = 0; d < depth; d++)
            {
                string[] cubeContent = lineFragment[d].
                    Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = cubeContent[w];
                }
            }
        }
        string[] rawBallCoord = Console.ReadLine().Split();
        int ballWidth = int.Parse(rawBallCoord[0]);
        int ballDepth = int.Parse(rawBallCoord[1]);

        cubeBall = new Ball(ballWidth, 0 , ballDepth);

    }
}