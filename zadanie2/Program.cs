double input(string msg)
{
    System.Console.WriteLine(msg);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double[] inputline(int num)
{
    double[] linedata = new double[2];
    linedata[CF1] = input($"Введите коэфициент для {num} прямой > ");
    linedata[cons1] = input($"Введите константу для {num} прямой > ");
    return linedata;
}

double[] coords(double x, double y)
{
    double[] coord = new double[2];
    coord[x_cord] = (x[cons1] - y[cons1])/(y[CF1]-x[CF1]);
    coord[y_cord] = x[cons1] * coord[x_cord] + x[cons1];
    return coord;
}

bool validate(double[] x, double[] y)
{
    if(x[CF1] == y[CF1])
    {
        if(x[cons1] == y[cons1])
        {
            System.Console.WriteLine("Прямы совпадают ");
            return false;
        }
        else
        {
            System.Console.WriteLine("Прямы паралельны ");
            return false;
        }
    }
    return true;
}

const int CF = 0;
const int cons = 1;
const int x_cord = 0;
const int y_cord = 1;
const int line1 = 1;
const int line2 = 2;
double[] x = input(line1);
double[] y = input(line2);

if (validate(x, y))
{
    double[] coord = coords(x, y);
    System.Console.Write($"Точка пересечений уравнений y={x[CF]}*x + {x[cons]} и y={y[CF]}*x + {y[cons]} имеет координаты ({coord[x_coord]} и {coord[y_coord]})");
}
