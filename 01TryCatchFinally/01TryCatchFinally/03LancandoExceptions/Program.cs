try
{
    A.ProcessarA();
}
catch (Exception ex)
{
    Console.WriteLine("\nTratando o erro em Main\n");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}

Console.ReadKey();

class A
{
    public static void ProcessarA()
    {
        try
        {
            B.ProcessarB();
        }
        catch (Exception ex)
        {
            throw ex;
            Console.WriteLine("Tratando o erro em A");
        }    
    }
}
class B
{
    public static void ProcessarB()
    {

        try
        {
            C.ProcessarC();
        }
        catch (Exception ex)
        {
            throw ex;
            Console.WriteLine("Tratando o erro em B");
        }
      
    }
}
class C
{
    public static void ProcessarC()
    {
        throw new NotImplementedException("Método não implementado");
    }
}
