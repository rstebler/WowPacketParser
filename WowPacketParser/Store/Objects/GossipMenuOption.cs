using WowPacketParser.Enums;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("gossip_menu_option")]
    public class GossipMenuOption : IDataModel
    {
        [DBFieldName("menu_id", true)]
        public uint? MenuId;

        [DBFieldName("id", true)]
        public uint? OptionIndex;

        [DBFieldName("option_icon")]
        public GossipOptionIcon? OptionIcon;

        [DBFieldName("option_text")]
        public string OptionText;

        [DBFieldName("OptionBroadcastTextID")]
        public int? OptionBroadcastTextId;

        public string BroadcastTextIDHelper;
    }
}
