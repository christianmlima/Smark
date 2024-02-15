using System;

class ProtocolGenerator
{
    private static readonly object lockObject = new object();
    private static int sequentialNumber = 0;
    private static string currentDate = DateTime.UtcNow.ToString("yyyyMMdd");

    public static string GenerateProtocol(string companyIdentifier)
    {
        // realiza o lock para 
        lock (lockObject)
        {
            string today = DateTime.UtcNow.ToString("yyyyMMdd");

            if (today != currentDate)
            {
                currentDate = today;
                sequentialNumber = 0; // Reiniciar o sequentialNumber diariamente
            }

            string sequentialPart = (++sequentialNumber).ToString("D6");
            return $"{companyIdentifier}{currentDate}{sequentialPart}";
        }
    }
}

class Program
{
    static void Main()
    {
        string companyIdentifier = "319708";

        // Exemplo de utilização para gerar um protocolo
        string protocol = ProtocolGenerator.GenerateProtocol(companyIdentifier);
        Console.WriteLine($"Protocolo gerado: {protocol}");
    }
}