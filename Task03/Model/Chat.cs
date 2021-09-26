using System;
using System.Collections.Generic;

namespace Task03.Model
{
    public class Chat
    {
        private readonly List<Player> _players;
        private readonly ChatStatus _chatStatus;

        public Chat(List<Player> players, ChatStatus chatStatus)
        {
            _players = players;
            _chatStatus = chatStatus;
        }

        public void SendMessage(string message, Player player)
        {
            foreach (Player playerInList in _players)
            {
                if (_chatStatus.IsAvailableOnlyPlayerReady 
                    && playerInList.GameRoomStatus.GameStatus != GameRoomStatus.GameStatusType.NotReady)
                    continue;

                if (player != playerInList)
                    Console.WriteLine($"{nameof(player)}: {message}");
            }
        }
    }
}