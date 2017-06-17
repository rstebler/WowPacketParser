using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V7_0_3_22248.Hotfix
{
    [HotfixStructure(DB2Hash.QuestLine, HasIndexInData = false)]
    public class QuestLineEntry
    {
        public string Name { get; set; }
    }
}