using System;
using System.Collections.Generic;
using System.Linq;

namespace Task03.Model
{
    public class GameRoom
    {
        private readonly List<Player> _players = new List<Player>();
        private readonly int _maxPlayer;
        private readonly ChatStatus _chatStatus;
        public Chat Chat { get; private set; }

        public GameRoom(int maxPlayer)
        {
            _maxPlayer = maxPlayer;
            _chatStatus = new ChatStatus(true);
            Chat = new Chat(_players, _chatStatus);
        }

        public Player FindPlayer(Player player)
        {
            return _players.FirstOrDefault(pl => pl == player);
        }

        public bool IsJoined(Player player)
        {
            return FindPlayer(player) == player;
        }

        public bool Join(Player player)
        {
            if (IsReadyToStart())
                return false;
            
            _players.Add(player);
            player.JoinedGameRoom(this);
            player.GameRoomStatus.OnChanged += PlayerStatusChanged;

            return true;
        }

        public void Leave(Player player)
        {
            if (player.GameRoomStatus == null)
                player.GameRoomStatus.OnChanged -= PlayerStatusChanged;
            
            _players.Remove(player);
        }

        private void PlayerStatusChanged()
        {
            if (IsReadyToStart())
            {
                _chatStatus.IsAvailableOnlyPlayerReady = false;
                StartGame();
            } else
                _chatStatus.IsAvailableOnlyPlayerReady = true;
        }

        private void StartGame()
        {
            
        }

        private bool IsReadyToStart()
        {
            return GetCountReadyPlayers() == _maxPlayer;
        }

        private int GetCountReadyPlayers()
        {
            return _players.Count(pl => pl?.GameRoomStatus.GameStatus == GameRoomStatus.GameStatusType.Ready);
        }
        
    }
}