using System;

class StudentGradeBook
{
    private double[] GradeBook;

    public StudentGradeBook()
    {
        GradeBook = new double[5];

    }
    public StudentGradeBook(int _size)
        {
            GradeBook = new double[_size];
        }
    // indexer
    public double this[int index]
    {
        set
        {
            if (index >= 0 && index < GradeBook.Length)
            {
                GradeBook[index] = value;

            }
        }
        get {
                if (index >= 0 && index < GradeBook.Length) 
                    return GradeBook[index]; 
                else 
                    return -1;  
            }
    }


}