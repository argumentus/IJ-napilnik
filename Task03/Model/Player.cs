using System;

namespace Task03.Model
{
    public class Player
    {
        public GameRoomStatus GameRoomStatus { get; private set; }
        public Chat Chat => GameRoomStatus?.GameRoom?.Chat;


        public bool JoinedGameRoom(GameRoom gameRoom)
        {
            if (gameRoom == null)
                throw new ArgumentException(nameof(gameRoom));
                
            if (GameRoomStatus?.GameRoom != gameRoom)
                LeaveGameRoom();

            if (gameRoom.IsJoined(this))
                GameRoomStatus = new GameRoomStatus(gameRoom, GameRoomStatus.GameStatusType.NotReady);
            else
                gameRoom.Join(this);

            return true;
        }

        public void LeaveGameRoom()
        {
            GameRoomStatus?.GameRoom?.Leave(this);
        }

        public bool SetReady()
        {
            if (GameRoomStatus.GameRoom == null)
                return false;

            GameRoomStatus.GameStatus = GameRoomStatus.GameStatusType.Ready;

            return true;
        }

        public bool SetNotReady()
        {
            if (GameRoomStatus.GameRoom == null)
                return false;

            GameRoomStatus.GameStatus = GameRoomStatus.GameStatusType.NotReady;

            return true;
        }
        
    }
}