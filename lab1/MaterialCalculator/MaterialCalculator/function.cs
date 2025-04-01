using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialCalculator
{

        public interface IMaterialCalculator
        {
            double CalculateMaterial(double length, double width, double height, double materialSize);
        }

        public class WallpaperCalculator : IMaterialCalculator
        {
            public double CalculateMaterial(double length, double width, double height, double materialSize)
            {
                double area = 2 * (length + width) * height;
                return Math.Ceiling(area / materialSize);
            }
        }

        public class LaminateCalculator : IMaterialCalculator
        {
            public double CalculateMaterial(double length, double width, double height, double materialSize)
            {
                double area = length * width;
                return Math.Ceiling(area / materialSize);
            }
        }

        public class TileCalculator : IMaterialCalculator
        {
            public double CalculateMaterial(double length, double width, double height, double materialSize)
            {
                double area = length * width;
                return Math.Ceiling(area / materialSize);
            }
        }

        public static class MaterialCalculatorFactory
        {
            public static IMaterialCalculator GetCalculator(string materialType)
            {
                switch (materialType)
                {
                    case "Обои": return new WallpaperCalculator();
                    case "Ламинат": return new LaminateCalculator();
                    case "Плитка": return new TileCalculator();
                    default: throw new ArgumentException($"Неизвестный тип материала: {materialType}");
                }
            }
        }
    }

