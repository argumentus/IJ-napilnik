using Task03.Model;

namespace Task03
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Задача
            // Есть игра, у неё есть доступные игровые комнаты. Каждый игрок может создать игровую комнату
            // или присоединиться. Игрок не может находится в двух комната одновременно, но у игрока есть статус
            // относящийся к конкретной комнате. Игрок может быть готов или не готов к игре.
            //
            // У каждой комнаты есть максимальное количество игроков. Игрок не может вступить в комнату в которой
            // максимальное количество готовых к игре игроков.
            //
            // Игроки в комнате могут писать в чат и читать его.
            //
            // Когда достигается максимальное количество готовых игроков, комната переходит в режиме в игре.
            // Все игроки которые были в статусе неготов теряют возможность читать чат и писать в него.

            GameRoom gr1 = new GameRoom(2);

            Player player1 = new Player();
            player1.JoinedGameRoom(gr1);
            player1.Chat?.SendMessage("player 1 say Hello", player1);
            player1.SetReady();
            
            Player player2 = new Player();
            player2.JoinedGameRoom(gr1);
            player2.Chat?.SendMessage("player 2 say Hello", player2);
            player2.SetReady();
            
            Player player3 = new Player();
            player3.JoinedGameRoom(gr1);
            player3.Chat?.SendMessage("player 3 say Hello", player3);
            player3.SetReady();

        }
    }
}