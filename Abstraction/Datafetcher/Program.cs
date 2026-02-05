using System;
namespace Abstraction
{
    public interface Idatafetcher
    {
        string fetch();
    }
    public class Database : Idatafetcher
    {
        public string fetch()
        {
            return "Data from Database";
        }
    }
    public class Api : Idatafetcher
    {
        public string fetch()
        {
            return " Data from API";
        }
    }

    public class Localhost1 : Idatafetcher
    {
        public string fetch()
        {
            return "Data from system";
        }
    }

    public class Dataprocessor
    {
        public void Processdata(Idatafetcher datafetcher)
        {
            string data = datafetcher.fetch();
            Console.WriteLine($"{data}");
        }
    }
     class Program{
        public static void Main()
        {
            Idatafetcher db = new Database();
            Idatafetcher api = new Api();
            Idatafetcher localhost1 = new Localhost1();

            Dataprocessor dp = new();

            dp.Processdata(db);
            dp.Processdata(api);
            dp.Processdata(localhost1);

        }
    }
}
