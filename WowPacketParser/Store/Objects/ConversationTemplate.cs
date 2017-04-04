using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("conversation_template")]
    public sealed class ConversationTemplate : IDataModel
    {
        [DBFieldName("Id", true)]
        public uint? Id;

        [DBFieldName("FirstLineId")]
        public uint? FirstLineId;

        [DBFieldName("LastLineDuration")]
        public uint? LastLineDuration;

        [DBFieldName("comment")]
        public string Comment;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
}
