using System;

namespace FactoryPatternExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            
            Console.WriteLine("Which database do you wish to access?");
            Console.WriteLine("1) [list] 2) [sql] 3) [mongo]");

            input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "1":
                case "list":

                    var dataList = DataAccessFactory.GetDataAccessType("list");
                    dataList.LoadData();
                    dataList.SaveData();
                    break;
                case "2":
                case "sql":

                    dataList = DataAccessFactory.GetDataAccessType("sql");
                    dataList.LoadData();
                    dataList.SaveData();
                    break;
                case "3":
                case "mongo":

                    dataList = DataAccessFactory.GetDataAccessType("mongo");
                    dataList.LoadData();
                    dataList.SaveData();
                    break;
                default:
                    Console.WriteLine("Were the instructions really that hard?");
                    break;
            }
        }
    }
}
