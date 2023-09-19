using System;

namespace QA_Lab3_Batyuk
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Circle ps = new Circle(2, 2, 2);
            Console.WriteLine("Circle");
            ps.Display();
            Console.WriteLine("\nDistance to center:" + ps.GetCenterDist());

            Cylinder cs = new Cylinder(2, 2, 2, 2);
            Console.WriteLine("\nCylinder");
            cs.Display();
            Console.WriteLine("Distance to center:" + cs.GetCenterDist());

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс, представляющий круг в двумерном пространстве.
    /// </summary>
    class Circle
    {
        protected int _x, _y, _r;

        /// <summary>
        /// Конструктор класса Circle.
        /// </summary>
        /// <param name="x">X-координата центра круга.</param>
        /// <param name="y">Y-координата центра круга.</param>
        /// <param name="r">Радиус круга.</param>
        public Circle(int x, int y, int r)
        {
            _x = x;
            _y = y;
            _r = r;
        }

        /// <summary>
        /// Инициализирует параметры круга.
        /// </summary>
        /// <param name="x">X-координата центра круга.</param>
        /// <param name="y">Y-координата центра круга.</param>
        /// <param name="r">Радиус круга.</param>
        /// ![Image](../images/example.jpg)

        public void Init(int x, int y, int r)
        {
            _x = x;
            _y = y;
            _r = r;
        }

        /// <summary>
        /// Отображает параметры круга.
        /// </summary>
        public void Display()
        {
            Console.Write("x:" + _x + " y:" + _y + " r:" + _r);
        }

        /// <summary>
        /// Возвращает радиус круга.
        /// </summary>
        public int GetR()
        {
            return _r;
        }

        /// <summary>
        /// Возвращает X-координату центра круга.
        /// </summary>
        public int GetX()
        {
            return _x;
        }

        /// <summary>
        /// Возвращает Y-координату центра круга.
        /// </summary>
        public int GetY()
        {
            return _y;
        }

        /// <summary>
        /// Рассчитывает и возвращает расстояние от центра круга до начала координат.
        /// </summary>
        public double GetCenterDist()
        {
            return Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2));
        }
    }

    /// <summary>
    /// Класс, представляющий цилиндр в трехмерном пространстве.
    /// </summary>
    class Cylinder : Circle
    {
        private int _z;

        /// <summary>
        /// Конструктор класса Cylinder.
        /// </summary>
        /// <param name="x">X-координата центра круга.</param>
        /// <param name="y">Y-координата центра круга.</param>
        /// <param name="r">Радиус круга.</param>
        /// <param name="z">Высота цилиндра.</param>
        public Cylinder(int x, int y, int r, int z) : base(x, y, r)
        {
            _z = z;
        }

        /// <summary>
        /// Инициализирует параметры цилиндра.
        /// </summary>
        /// <param name="x">X-координата центра круга.</param>
        /// <param name="y">Y-координата центра круга.</param>
        /// <param name="r">Радиус круга.</param>
        /// <param name="z">Высота цилиндра.</param>
        public void Init(int x, int y, int r, int z)
        {
            base.Init(x, y, r);
            _z = z;
        }

        /// <summary>
        /// Отображает параметры цилиндра.
        /// </summary>
        public new void Display()
        {
            base.Display();
            Console.WriteLine(" z:" + _z);
        }

        /// <summary>
        /// Рассчитывает и возвращает расстояние от центра цилиндра до начала координат.
        /// \f$ √((x^2) + (y^2)) \f$
        /// </summary>
        public new double GetCenterDist()
        {
            double a = Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2));
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(_z, 2));
        }
    }
}