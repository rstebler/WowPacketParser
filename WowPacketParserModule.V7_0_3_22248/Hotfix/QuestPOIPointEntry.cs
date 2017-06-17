using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V7_0_3_22248.Hotfix
{
    [HotfixStructure(DB2Hash.QuestPOIPoint, HasIndexInData = true)]
    public class QuestPOIPointEntry
    {
        public uint BlobID { get; set; }
        public ushort X { get; set; }
        public ushort Y { get; set; }
        public uint ID { get; set; }
    }
}