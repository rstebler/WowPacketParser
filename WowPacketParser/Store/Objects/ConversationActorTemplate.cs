using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("conversation_actor_template")]
    public sealed class ConversationActorTemplate : IDataModel
    {
        [DBFieldName("Id", true)]
        public uint? Id;

        [DBFieldName("CreatureId")]
        public uint? CreatureId;

        [DBFieldName("Unk1")]
        public uint? Unk1;

        [DBFieldName("Unk2")]
        public uint? Unk2;

        [DBFieldName("Unk3")]
        public uint? Unk3;

        [DBFieldName("Unk4")]
        public uint? Unk4;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
}
