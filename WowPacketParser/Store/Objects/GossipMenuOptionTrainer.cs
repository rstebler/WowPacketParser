using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("gossip_menu_option")]
    public class GossipMenuOptionTrainer : IDataModel
    {
        [DBFieldName("menu_id", true)]
        public uint? MenuId;

        [DBFieldName("id", true)]
        public uint? OptionIndex;

        //[DBFieldName("TrainerId")]
        public uint? TrainerId;
    }
}
