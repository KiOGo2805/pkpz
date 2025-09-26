    using System;

    class Program
    {
        static void Main()
        {
            double x, y;
            Console.WriteLine("Введіть координату x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть координату y:");
            y = Convert.ToDouble(Console.ReadLine());

            double a = 5;
            double b = 3;
            double R = 4;

            bool onCircle = (x * x + y * y == R * R);
            if (onCircle)
            {
                bool onRectangle = (x < 0 && y < 0 && y > (-b)) || (x > 0 && y > 0 && y < (-b));
                Console.WriteLine("На межі");
                return;
            }

            bool inCircle = (x * x + y * y < R * R);
            if (inCircle)
            {
                bool inRectangle = (x > (-a) && x <= 0 && y >= (-b) && y <= 0);
                if (inRectangle)
                {
                    bool onRectangle = (x == 0 || y == (-b) || y == 0);
                    if (onRectangle)
                    {
                        Console.WriteLine("На межі");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Так");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Ні");
                    return;
                }
            }
            else
            {
                bool inRectangle = (x > 0 && x <= a && y >= 0 && y <= b);
                if (inRectangle)
                {
                    bool onRectangle = (x == a || y == b || y == 0);
                    if (onRectangle)
                    {
                        Console.WriteLine("На межі");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Так");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Ні");
                    return;
                }
            }
        }
    }
