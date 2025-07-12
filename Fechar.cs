using System;

class Fechar
{
    public string exit;
    public static void Exit(string exit)
    {
        if (exit == "3")
        {
            Environment.Exit(0);
        }
    }
}