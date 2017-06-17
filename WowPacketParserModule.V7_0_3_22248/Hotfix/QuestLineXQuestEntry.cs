using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V7_0_3_22248.Hotfix
{
    [HotfixStructure(DB2Hash.QuestLineXQuest, HasIndexInData = false)]
    public class QuestLineXQuestEntry
    {
        public ushort QuestLineID { get; set; }
        public ushort QuestID { get; set; }
        public byte QuestIndex { get; set; }
    }
}