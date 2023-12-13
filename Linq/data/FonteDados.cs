namespace Linq.data
{

  static public class DataSource {

    public static List<int> GenerateNumbers(int max = 10)
    {
      var random = new Random();
      var list = new List<int>();

      for (int i = 0 ; i < max ; i++) 
      {
        list.Add(random.Next(1000));
      }

      return list;
    }
  }

}