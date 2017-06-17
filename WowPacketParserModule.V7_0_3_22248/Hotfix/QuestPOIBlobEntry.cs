using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V7_0_3_22248.Hotfix
{
    [HotfixStructure(DB2Hash.QuestPOIBlob, HasIndexInData = true)]
    public class QuestPOIBlobEntry
    {
        public uint ID { get; set; }
        public ushort MapID { get; set; }
        public ushort WorldMapAreaID { get; set; }
        public byte Unk1 { get; set; }
        public byte Unk2 { get; set; }
        public uint PlayerConditionID { get; set; }
        public uint QuestID { get; set; }
        public uint QuestObjectiveIndex { get; set; }
    }
}