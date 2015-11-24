using System;
using System.Collections.Generic;

// Background stars for the galaxian game
// Предлагам да добавим звездити накрая, дори може и да направим някои редкации преди това,
// така че да не бързаме а да ги оставим за последно.

class Stars
{
    // define the stars' structure
    struct Star
    {
        // coordiates
        public int x;
        public int y;

        // star symbol
        public char starDesign;
    }

    static void Main()
    {
        // initiate two lists for the stars
        List<Star> backgroundStars = GenerateStars(50);
        List<Star> movedStars = new List<Star>(50);

        // remove scrollbar
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.BufferWidth;

        // make the cursor invisible
        Console.CursorVisible = false;

        while (true)
        {
            // move the stars
            movedStars = MoveStars(backgroundStars);

            // clear the screen of the old stars
            Console.Clear();

            // draw the new moved stars
            DrawStars(movedStars);

            // save the new stars into the old stars list
            backgroundStars.Clear();
            backgroundStars = new List<Star>(movedStars);
            movedStars.Clear();

            // slow down the program
            System.Threading.Thread.Sleep(100);
        }
    }

    // Generate stars
    static List<Star> GenerateStars(int count)
    {
        // init variables
        List<Star> stars = new List<Star>(count);
        Random randNumber = new Random();
        Star currentStar = new Star();

        // iterate count times through the empty list
        // adding the stars
        for (int i = 0; i < count; i++)
        {
            // generate random star coordinates
            currentStar.x = randNumber.Next(0, Console.WindowWidth);
            currentStar.y = randNumber.Next(0, Console.WindowHeight);

            // the star is a dot (.)
            currentStar.starDesign = '.';

            // add the star we generated in this iteration
            // to the list of stars
            stars.Add(currentStar);
        }

        // return the list with stars
        return stars;
    }

    // Draw the stars
    static void DrawStars(List<Star> stars)
    {
        // iterate through all the stars
        for (int i = 0; i < stars.Count; i++)
        {
            // draw the stars at the appropriate coordinates
            Console.SetCursorPosition(stars[i].x, stars[i].y);
            Console.Write(stars[i].starDesign);
        }
    }

    // Move the stars
    static List<Star> MoveStars(List<Star> oldStars)
    {
        // init variables
        List<Star> newStars = new List<Star>(50);
        Star currentStar = new Star();
        Random randNumber = new Random();

        // move every star
        for (int i = 0; i < oldStars.Count; i++)
        {
            // check whether the current star has reached
            // the end of the screen
            if (oldStars[i].y + 1 < Console.WindowHeight)
            {
                // if it hasn't reached the end, move one position down
                currentStar.x = oldStars[i].x;
                currentStar.y = oldStars[i].y + 1;
            }
            else
            {
                // if it has, generate a new star at the top of the screen
                currentStar.y = 0;
                currentStar.x = randNumber.Next(0, Console.WindowWidth);
            }

            // star design
            currentStar.starDesign = oldStars[i].starDesign;

            // add the current star to the list
            newStars.Add(currentStar);
        }

        // return the new list with moved stars
        return newStars;
    }

}


