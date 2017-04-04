using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("conversation_line_template")]
    public sealed class ConversationLineTemplate : IDataModel
    {
        [DBFieldName("Id", true)]
        public uint? Id;

        [DBFieldName("PreviousLineDuration")]
        public uint? PreviousLineDuration;

        [DBFieldName("Unk2")]
        public uint? Unk2;

        [DBFieldName("Unk3")]
        public uint? Unk3;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
}
