using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Example number = new Example(1, 2);


            number.One = 4;


            if (number.One == 1)
            {
                number.IsOne = true;
            }

            if (number.Two == 2)
            {
                number.IsTwo = true;
            }




            if (number.IsOne)
            {
                Console.WriteLine("the first Number is one!");
            }
            else
            {
                Console.WriteLine("the first number is not one");
            }
            if (number.IsTwo)
            {
                Console.WriteLine("the second Number is two!");
            }
            else
            {
                Console.WriteLine("the second number is not two");
            }

        }
    }
}


class Example
{
    private int _one;
    private int _two;
    private bool _isOne;
    private bool _isTwo;

    public Example(int one, int two)
    {
        _one = one;
        _two = two;
    }

    public int one()
    {
        return _one;
    }


    public bool IsOne
    {
        get
        {
            return _isOne;
        }
        set
        {
            _isOne = value;
        }
    }

    public bool IsTwo
    {
        get
        {
            return _isTwo;
        }
        set
        {
            _isTwo = value;
        }
    }

    public int One
    {
        get
        {
            return _one;
        }
        set
        {
            _one = value;
        }
    }

    public int Two
    {
        get
        {
            return _two;
        }

        set
        {
            _two = value;
        }
    }


}