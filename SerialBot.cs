using System;
using System.IO

public class SerialBot
{
    private SerialPort _serialPort;

    public SerialBot(string portName, int baudRate)
    {
        // Configura a porta serial com os parâmetros desejados
        _serialPort = new SerialPort(portName, baudRate);
        _serialPort.Parity = Parity.None;
        _serialPort.DataBits = 8;
        _serialPort.StopBits = StopBits.One;
        _serialPort.Handshake = Handshake.None;
        
        // Timeout para leitura/escrita
        _serialPort.ReadTimeout = 500;
        _serialPort.WriteTimeout = 500;
    }

    public void Connect(string username, string password)
    {
        try
        {
            // Abrir conexão serial
            _serialPort.Open();
            Console.WriteLine("Conexão serial aberta");

            // Enviar login
            SendCommand(username);
            // Pode haver um delay, então é importante esperar ou validar a resposta.
            System.Threading.Thread.Sleep(500); 

            // Enviar senha
            SendCommand(password);
            System.Threading.Thread.Sleep(500);

            // Aqui você pode esperar por uma resposta de sucesso ou falha do login
            string response = ReadResponse();
            Console.WriteLine("Resposta: " + response);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
        finally
        {
            // Fechar a porta serial quando terminar
            _serialPort.Close();
            Console.WriteLine("Conexão serial fechada");
        }
    }

    private void SendCommand(string command)
    {
        if (_serialPort.IsOpen)
        {
            _serialPort.WriteLine(command + "\r"); // O "\r" é o retorno de carro, comum em comunicações seriais.
            Console.WriteLine("Comando enviado: " + command);
        }
    }

    private string ReadResponse()
    {
        try
        {
            return _serialPort.ReadLine();
        }
        catch (TimeoutException)
        {
            return "Timeout de leitura atingido.";
        }
    }
}
