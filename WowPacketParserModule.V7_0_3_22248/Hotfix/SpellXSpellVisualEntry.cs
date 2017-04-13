using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V7_0_3_22248.Hotfix
{
    [HotfixStructure(DB2Hash.SpellXSpellVisual, ClientVersionBuild.V7_0_3_22248, ClientVersionBuild.V7_2_0_23826, HasIndexInData = false)]
    public class SpellXSpellVisualEntry
    {
        public uint SpellID { get; set; }
        public float Unk620 { get; set; }
        [HotfixArray(2)]
        public ushort[] SpellVisualID { get; set; }
        public ushort PlayerConditionID { get; set; }
        public byte DifficultyID { get; set; }
        public byte Flags { get; set; }
        public uint ID { get; set; }
    }
}