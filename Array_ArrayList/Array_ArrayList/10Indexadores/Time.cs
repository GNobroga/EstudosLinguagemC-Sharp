namespace _10Indexadores;

public class Time
{
    //definir os limites do array
    string[] valor = new string[10];

    public string this[int i]
    {
        get
        { 
            if(i >=0 && i < valor.Length)
            {
                //retornar o valor
                return valor[i];
            }
            return "Erro";
        }
        set 
        { 
            if(i >=0 && i < valor.Length)
            {
                //atribuir o valor
                valor[i] = value;
            }
        }
    }
}
