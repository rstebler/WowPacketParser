﻿using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("gossip_menu_option")]
    public class GossipMenuOptionBox : IDataModel
    {
        [DBFieldName("menu_id", true)]
        public uint? MenuId;

        [DBFieldName("id", true)]
        public uint? OptionIndex;

        [DBFieldName("box_coded")]
        public bool? BoxCoded;

        [DBFieldName("box_money")]
        public uint? BoxMoney;

        [DBFieldName("box_text")]
        public string BoxText;

        [DBFieldName("BoxBroadcastTextID")]
        public int? BoxBroadcastTextId;

        public bool IsEmpty { get { return !BoxCoded.HasValue || !BoxCoded.Value; } }

        public string BroadcastTextIdHelper;
    }
}
