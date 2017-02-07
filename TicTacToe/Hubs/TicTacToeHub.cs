using Microsoft.AspNet.SignalR;

namespace TicTacToe.Hubs
{
    /// <summary>
    /// hub for tictactoe accepting numbers
    /// </summary>
    public class TicTacToeHub : Hub
    {
        #region Public Methods

        public void Send(int number)
        {
            Clients.All.tictactoe(number);
        }

        #endregion
    }
}