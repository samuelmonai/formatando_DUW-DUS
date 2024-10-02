class Program
{
    static void Main(string[] args)
    {
        // Substitua pela porta serial que você está utilizando e a taxa de transmissão
        SerialBot bot = new SerialBot("COM3", 9600);

        // Envie o login e a senha que o dispositivo espera
        bot.Connect("seu_login", "sua_senha");
    }
}
