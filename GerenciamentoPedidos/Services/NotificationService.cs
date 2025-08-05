namespace GerenciamentoPedidos.Services
{
    public class NotificationService
    {
        public event Action<string, string>? OnNotify;

        public void Notify(string mensagem, string tipo = "success") =>
            OnNotify?.Invoke(mensagem, tipo);
    }
}
