using Enum_Downcasting_Practic.Models;
using System;

namespace Enum_Downcasting_Practic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Params
            //GetElements(1, 2, 3, 4, 5);
            #endregion

            #region Enum
            //CheckRole(0);
            #endregion

            #region Nullable
            //Test test = new Test();
            //Console.WriteLine(test.Number);

            //string name = null;
            //int? age = null;

            //var result = age == null ? 55 : 60;

            //var result = age ?? 60;

            //Console.WriteLine(result);

            //Test test = null;
            //Console.WriteLine(test.Word.Tostring());
            #endregion

            #region Struct
            //Test1 test = new Test1("Emil");
            //Console.WriteLine(test.Num);

            //Test2 test2 = new Test2();
            #endregion

            #region UpcastingBoxingImplicit
            //EurocopterEC135 eurocopterEC1351 = new EurocopterEC135();
            //EurocopterEC135 eurocopterEC1353 = new EurocopterEC135();
            //Bell407 bell4071 = new Bell407();
            //Helicopters bell4072 = new Bell407();

            //Helicopters eurocopterEC1352 = eurocopterEC1351;

            //Helicopters[] helicoptersModels = { eurocopterEC1351, eurocopterEC1352, eurocopterEC1353, bell4071, bell4072 };

            //foreach (var item in helicoptersModels)
            //{
            //    item.Speed();
            //}
            #endregion

            #region DowncastingUnboxingExplicit
            //Bell407 bell4071 = new Bell407();
            //Helicopters bell4072 = new Bell407();

            //Bell407 bell4073 = (Bell407)bell4072;

            //object[] objects = { 2, 5, "P130", bell4072 };

            //foreach (var item in objects)
            //{
            //    Bell407 bell407 = item as Bell407;

            //    if (bell407 != null)
            //    {
            //        Console.WriteLine(bell407.HorsePower);
            //    }
            //    if (item is Bell407)
            //    {
            //        ((Bell407)item).HorsePower = 420;

            //        Console.WriteLine(((Bell407)item).HorsePower);
            //    }
            //}
            #endregion
        }
        #region Params
        //public static void GetElements(params int[] nums)
        //{
        //    foreach (var item in nums)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        #endregion

        #region Enum
        //static void CheckRole(int roleId)
        //{
        //    switch (roleId)
        //    {
        //        case (int)Roles.Mudur:
        //            Console.WriteLine("Mudur");
        //            break;

        //        case (int)Roles.Muavin:
        //            Console.WriteLine("Muavin");
        //            break;

        //        case (int)Roles.Ishci:
        //            Console.WriteLine("Ishci");
        //            break;

        //        default:
        //            Console.WriteLine("Role Id tapilmadi");
        //            break;
        //    }
        //}
        #endregion
    }
    #region Enum
    //enum Roles
    //{
    //    Mudur,
    //    Muavin,
    //    Ishci
    //}
    #endregion

    #region Nullable
    //class Test
    //{
    //    public int? Number { get; set; }
    //    public string Word { get; set; }
    //}
    #endregion

    #region Struct
    //struct Test1
    //{
    //    public int Num { get; set; }

    //    public Test1(string name)
    //    {
    //        Num = 66;
    //        Console.WriteLine(Num);
    //    }
    //}

    //class Test2
    //{
    //    public int MyProperty { get; set; } = 66;

    //    public Test2()
    //    {
    //        Console.WriteLine("Bosh");
    //    }
    //    public Test2(int b)
    //    {
    //        Console.WriteLine("Dolu");
    //    }
    //}
    #endregion
}
