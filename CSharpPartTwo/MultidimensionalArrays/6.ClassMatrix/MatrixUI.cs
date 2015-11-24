using System;

class MatrixUI
{
    static void Main()
    {
        Matrix matrixFirst = new Matrix(2,2);
        matrixFirst[0, 0] = 1;
        matrixFirst[1, 1] = -12;
        Matrix matrixSecond = new Matrix(2,2);
        matrixSecond[0, 1] = 2;
        matrixSecond[1, 1] = 24;

        Matrix matrixSum = matrixFirst + matrixSecond;
        Console.WriteLine(matrixSum.ToString());

        Matrix matrixSubtr = matrixFirst - matrixSecond;
        Console.WriteLine(matrixSubtr.ToString());

        Matrix matrixMult = matrixFirst * matrixSecond;
        Console.WriteLine(matrixMult.ToString());
    }
}
