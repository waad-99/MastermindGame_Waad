using System;
using System.Linq;

public static class CodeGenerator
{
    public static string GenerateCode()
    {
        Random rnd = new Random();
        return string.Join("", Enumerable.Range(0, 9).OrderBy(x => rnd.Next()).Take(4));
    }
}