using System;
using System.Text;
using System.IO;

namespace lab5
{  
}
    class Program
{
    static void Main(string[] args)
    {
        
        string path_x = @"C:\Users\giros\source\repos\lab5\x.txt";
        string path_y = @"C:\Users\giros\source\repos\lab5\y.txt";

        
        double[] arr_x = FilesToGetArrays(path_x);
        double[] arr_y = FilesToGetArrays(path_y);
        double[] arr_z = new double[arr_x.Length];

        Console.WriteLine($"Array X: {string.Join(' ', arr_x)}");
        Console.WriteLine($"Array Y: {string.Join(' ', arr_y)}");

        SubstractionOfArrayX(ref arr_x);
        SettingOfArrayZ(arr_x, arr_y, ref arr_z);

        Console.WriteLine($"Array X (after changes): {string.Join(' ', arr_x)}");
        Console.WriteLine($"Array Z: {string.Join(' ', arr_z)}");

    }

    public static double[] FilesToGetArrays(string link)
    {
        string[] fileTxt = File.ReadAllText(link).Split(", ");
        double[] tempArr = new double[fileTxt.Length];
        for (int i = 0; i < fileTxt.Length; i++)
        {
            try
            {
                tempArr[i] = Convert.ToDouble(fileTxt[i]);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        return tempArr;
    }
    public static void SubstractionOfArrayX(ref double[] arr_x)
    {
        for (int i = 0; i < arr_x.Length; i++)
        {
            if (arr_x[i] <0)
            {
                arr_x[i] = arr_x[i] / -1;
            }
        }
    }
    public static void SettingOfArrayZ(double[] arr_x, double[] arr_y, ref double[] arr_z)
    {
        for (int i = 0; i < arr_x.Length; i++)
        {
            arr_z[i] = (arr_x[i] + arr_y[i]) / 2;
        }
    }

}

