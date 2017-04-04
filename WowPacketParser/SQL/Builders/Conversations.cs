using System.Collections.Generic;
using System.Linq;
using System.Text;
using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Store;
using WowPacketParser.Store.Objects;

namespace WowPacketParser.SQL.Builders
{
    [BuilderClass]
    public static class Conversations
    {
        [BuilderMethod(true, Conversations = true)]
        public static string ConversationTemplate(Dictionary<WowGuid, Conversation> conversations)
        {
            if (conversations.Count == 0)
                return string.Empty;

            if (!Settings.SQLOutputFlag.HasAnyFlagBit(SQLOutput.conversation_template))
                return string.Empty;

            var conversationTemplates = new DataBag<ConversationTemplate>();
            foreach (var conversation in conversations)
            {
                var conv = conversation.Value;

                var conversationTemplate = new ConversationTemplate
                {
                    Id = conversation.Key.GetEntry(),
                    FirstLineId = conv.GetFirstLineId(),
                    LastLineDuration = conv.LastLineDuration,
                    Comment = string.Empty
                };

                if (conversationTemplates.ContainsKey(conversationTemplate))
                    continue;

                conversationTemplates.Add(conversationTemplate);
            }

            var rows = new RowList<ConversationTemplate>();
            foreach (var conversationTemplate in conversationTemplates)
            {
                rows.Add(conversationTemplate.Item1);
            }

            StringBuilder result = new StringBuilder();
            var sql = new SQLInsert<ConversationTemplate>(rows, false);
            result.Append(sql.Build());

            return result.ToString();

            /*var templateDb = SQLDatabase.Get(conversationTemplates);

            return SQLUtil.Compare(conversationTemplates, templateDb, StoreNameType.None);*/
        }

        [BuilderMethod(true, Conversations = true)]
        public static string ConversationActorTemplate(Dictionary<WowGuid, Conversation> conversations)
        {
            if (conversations.Count == 0)
                return string.Empty;

            if (!Settings.SQLOutputFlag.HasAnyFlagBit(SQLOutput.conversation_actor_template))
                return string.Empty;

            var conversationActorTemplates = new DataBag<ConversationActorTemplate>();
            foreach (var conversation in conversations)
            {
                foreach (var actor in conversation.Value.Actors)
                {
                    var conversationActorTemplate = new ConversationActorTemplate
                    {
                        Id = actor.Id,
                        CreatureId = actor.CreatureId,
                        Unk1 = actor.Unk1,
                        Unk2 = actor.Unk2,
                        Unk3 = actor.Unk3,
                        Unk4 = actor.Unk4
                    };

                    if (conversationActorTemplates.ContainsKey(conversationActorTemplate))
                        continue;

                    conversationActorTemplates.Add(conversationActorTemplate);
                }
            }


            var rows = new RowList<ConversationActorTemplate>();
            foreach (var conversationActorTemplate in conversationActorTemplates)
            {
                rows.Add(conversationActorTemplate.Item1);
            }

            StringBuilder result = new StringBuilder();
            var sql = new SQLInsert<ConversationActorTemplate>(rows, false);
            result.Append(sql.Build());

            return result.ToString();

            //var templateDb = SQLDatabase.Get(conversationActorTemplates);

            //return SQLUtil.Compare(conversationActorTemplates, templateDb, StoreNameType.None);
        }

        [BuilderMethod(true, Conversations = true)]
        public static string ConversationLineTemplate(Dictionary<WowGuid, Conversation> conversations)
        {
            if (conversations.Count == 0)
                return string.Empty;

            if (!Settings.SQLOutputFlag.HasAnyFlagBit(SQLOutput.conversation_line_template))
                return string.Empty;

            var conversationLineTemplates = new DataBag<ConversationLineTemplate>();
            foreach (var conversation in conversations)
            {
                foreach (var line in conversation.Value.Lines)
                {
                    var conversationLineTemplate = new ConversationLineTemplate
                    {
                        Id = line.Id,
                        PreviousLineDuration = line.PreviousLineDuration,
                        Unk2 = line.Unk2,
                        Unk3 = line.Unk3
                    };

                    if (conversationLineTemplates.ContainsKey(conversationLineTemplate))
                        continue;

                    conversationLineTemplates.Add(conversationLineTemplate);
                }
            }

            var rows = new RowList<ConversationLineTemplate>();
            foreach (var conversationLineTemplate in conversationLineTemplates)
            {
                rows.Add(conversationLineTemplate.Item1);
            }

            StringBuilder result = new StringBuilder();
            var sql = new SQLInsert<ConversationLineTemplate>(rows, false);
            result.Append(sql.Build());

            return result.ToString();

            /*var templateDb = SQLDatabase.Get(conversationLineTemplates);

            return SQLUtil.Compare(conversationLineTemplates, templateDb, StoreNameType.None);*/
        }

        [BuilderMethod(true, Conversations = true)]
        public static string ConversationActors(Dictionary<WowGuid, Conversation> conversations)
        {
            if (conversations.Count == 0)
                return string.Empty;

            if (!Settings.SQLOutputFlag.HasAnyFlagBit(SQLOutput.conversation_actors))
                return string.Empty;

            var conversationActors = new DataBag<ConversationActors>();
            foreach (var conversation in conversations)
            {
                uint index = 0;
                foreach (var actor in conversation.Value.Actors)
                {
                    var conversationActor = new ConversationActors
                    {
                        ConversationId = conversation.Key.GetEntry(),
                        ConversationActorId = actor.Id,
                        Idx = index
                    };

                    if (conversationActors.ContainsKey(conversationActor))
                        continue;

                    conversationActors.Add(conversationActor);
                    index++;
                }
            }

            var rows = new RowList<ConversationActors>();
            foreach (var conversationActor in conversationActors)
            {
                rows.Add(conversationActor.Item1);
            }

            StringBuilder result = new StringBuilder();
            var sql = new SQLInsert<ConversationActors>(rows, false);
            result.Append(sql.Build());

            return result.ToString();

            /*var templateDb = SQLDatabase.Get(conversationActors);

            return SQLUtil.Compare(conversationActors, templateDb, StoreNameType.None);*/
        }
    }
}
