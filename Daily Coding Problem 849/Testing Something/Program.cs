using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{

    /*
     * Complete the 'distanceTraversed' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY lot as parameter.
     */

    public static int distanceTraversed(List<List<int>> lot)
    {
        //Result variable.
        int tilesTraveled = 0;

        //Position tracking.
        int[] startPos = {0,0};
        int[] targetPos = new int[2];

        Robot robot = new Robot(startPos);

        //Find target position. O(n^2) time;
        for (int x = 0; x < lot.Count(); x++)
        {
            for (int y = 0; y < lot[x].Count(); y++)
            {
                if (lot[x][y] == 9)
                {
                    targetPos[0] = x;
                    targetPos[1] = y;
                }
            }
        }

        return tilesTraveled;

    }

}

class Robot
{
    public Robot(int[] initialPosition)
    {
        this.Position = initialPosition;
    }

    private int[] Position { get; set; }

    public int[] moveRight(int x, int y)
    {

        return new int[] { x + 1 ,  y };
    }

    public int[] moveLeft(int x, int y)
    {
        return new int[] { x - 1 ,  y  };
    }

    public int[] moveUp(int x, int y)
    {
        return new int[] {  x , y + 1 };
    }

    public int[] moveDown(int x, int y)
    {
        return new int[] { x , y - 1 };
    }

    public bool canMoveNextTile(int nextTileData)
    {
        if (nextTileData == 1 || nextTileData == 9)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int lotRows = Convert.ToInt32(Console.ReadLine().Trim());
        int lotColumns = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> lot = new List<List<int>>();

        for (int i = 0; i < lotRows; i++)
        {
            lot.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(lotTemp => Convert.ToInt32(lotTemp)).ToList());
        }

        int result = Result.distanceTraversed(lot);

        Console.WriteLine(result);
        //textWriter.WriteLine(result);

        //textWriter.Flush();
       // textWriter.Close();
    }
}
