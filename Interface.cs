using System.Collections.Generic;

public class formatacao_strings{
    public void linha(){
        Console.WriteLine("---------------------------");
    }
    public void cabecalho(string txt){
        linha();
        Console.WriteLine(txt);
        linha();
    }
}