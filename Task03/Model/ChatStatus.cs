using System.ComponentModel.Design.Serialization;

namespace Task03.Model
{
    public class ChatStatus
    {
        public bool IsAvailableOnlyPlayerReady = false;

        public ChatStatus(bool isAvailableOnlyPlayerReady)
        {
            IsAvailableOnlyPlayerReady = isAvailableOnlyPlayerReady;
        }
    }
}