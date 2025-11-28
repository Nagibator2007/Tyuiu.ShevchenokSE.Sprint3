using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShevchenokSE.Sprint3.Task3.V10.Lib
{
    public class DataService : ISprint3Task3V10
    {
        public string DeleteCharInString(string value, char item)
        {
            string delS = "";
            foreach (char p in value)
            {
                if (p == item) continue;
                else delS += p;
            }
            return delS;
        }
    }
}
