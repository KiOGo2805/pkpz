using System;

enum Color { White, Black }
enum Type { Rook, Pawn }

class Figure(Type type, Color color, int x, int y)
{
    public Type Type { get; } = type;
    public Color Color { get; } = color;
    public int X { get; } = x;
    public int Y { get; } = y;

    public bool CanAttack(Figure other, Figure[] all)
    {
        if (Color == other.Color) return false;

        if (Type == Type.Rook)
        {
            if (X == other.X)
            {
                int start = Math.Min(Y, other.Y) + 1;
                int end = Math.Max(Y, other.Y);
                for (int y = start; y < end; y++)
                    for (int i = 0; i < all.Length; i++)
                        if (all[i] != null && all[i].X == X && all[i].Y == y)
                            return false;
                return true;
            }
            if (Y == other.Y)
            {
                int start = Math.Min(X, other.X) + 1;
                int end = Math.Max(X, other.X);
                for (int x = start; x < end; x++)
                    for (int i = 0; i < all.Length; i++)
                        if (all[i] != null && all[i].X == x && all[i].Y == Y)
                            return false;
                return true;
            }
            return false;
        }

        if (Type == Type.Pawn)
        {
            int dir = (Color == Color.White) ? 1 : -1;
            return (other.X == X - 1 || other.X == X + 1) && other.Y == Y + dir;
        }

        return false;
    }

    public override string ToString() =>
        $"{Color} {Type} ({X},{Y})";
}

class Program
{
    static void Main()
    {
        Figure[] figures = new Figure[4];

        Console.WriteLine("Enter coordinates for 2 White Rooks and 2 Black Pawns (X Y):");

        figures[0] = CreateFigure(Type.Rook, Color.White, figures);
        figures[1] = CreateFigure(Type.Rook, Color.White, figures);
        figures[2] = CreateFigure(Type.Pawn, Color.Black, figures);
        figures[3] = CreateFigure(Type.Pawn, Color.Black, figures);

        Console.WriteLine("\n--- Results ---");
        foreach (var fig in figures)
            ShowActions(fig, figures);
    }

    static Figure CreateFigure(Type type, Color color, Figure[] figures)
    {
        int x = 0, y = 0;
        bool isOccupied;

        do
        {
            Console.Write($"{color} {type} (X Y): ");
            string? line = Console.ReadLine();
            if (line == null)
            {
                Console.WriteLine("Input cannot be null. Please enter two numbers separated by space.");
                isOccupied = true;
                continue;
            }
            string[] input = line.Split();
            if (input.Length != 2 || !int.TryParse(input[0], out x) || !int.TryParse(input[1], out y))
            {
                Console.WriteLine("Invalid format. Enter two numbers separated by space.");
                isOccupied = true;
                continue;
            }

            if (x < 1 || x > 8 || y < 1 || y > 8)
            {
                Console.WriteLine("Coordinates must be between 1 and 8.");
                isOccupied = true;
                continue;
            }

            isOccupied = false;
            for (int i = 0; i < figures.Length; i++)
                if (figures[i] != null && figures[i].X == x && figures[i].Y == y)
                {
                    isOccupied = true;
                    break;
                }

            if (isOccupied)
                Console.WriteLine("This cell is already occupied. Enter different coordinates.");

        } while (isOccupied);

        return new Figure(type, color, x, y);
    }

    static void ShowActions(Figure fig, Figure[] all)
    {
        string attacks = "";
        string defenses = "";

        foreach (var other in all)
        {
            if (other == fig) continue;

            if (fig.CanAttack(other, all))
                attacks += other + " ";

            if (fig.Color == other.Color)
            {
                foreach (var enemy in all)
                {
                    if (enemy == fig || enemy.Color == fig.Color) continue;

                    if (enemy.CanAttack(other, all))
                    {
                        defenses += other + " ";
                        break;
                    }
                }
            }
        }

        Console.WriteLine(fig);

        if (attacks != "")
            Console.WriteLine("  Attack: " + attacks);
        else if (defenses != "")
            Console.WriteLine("  Defend: " + defenses);
        else
            Console.WriteLine("  Simple move");
    }
}
