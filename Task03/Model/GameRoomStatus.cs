using System;

namespace Task03.Model
{
    public class GameRoomStatus
    {
        public enum GameStatusType
        {
            NotReady,
            Ready
        }
        
        private GameStatusType _gameRoomStatus;
        public GameStatusType GameStatus
        {
            get { return _gameRoomStatus; }
            set
            {
                _gameRoomStatus = value;
                OnChanged?.Invoke();
            }
        }

        public GameRoom GameRoom { get; private set; }
        
        public event Action OnChanged;

        public GameRoomStatus(GameRoom gameRoom, GameStatusType gameStatus)
        {
            GameRoom = gameRoom;
            _gameRoomStatus = gameStatus;
        }
    }
}