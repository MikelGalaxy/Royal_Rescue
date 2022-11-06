using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Dtos
{
    [Serializable]
    public class Conversation
    {
        public int Id;
        public int[] NpcIds;
    }

    public class ConversationJson
    {
        public Conversation[] Conversations;
    }
}
