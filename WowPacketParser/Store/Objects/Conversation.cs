using System.Collections.Generic;
using System.Linq;
using WowPacketParser.Enums;
using WowPacketParser.Misc;

namespace WowPacketParser.Store.Objects
{
    public sealed class Conversation : WoWObject
    {
        public struct Actor
        {
            public uint Id;
            public uint CreatureId;
            public uint Unk1;
            public uint Unk2;
            public uint Unk3;
            public uint Unk4;
        }

        public struct Line
        {
            public uint Id;
            public uint PreviousLineDuration;
            public uint Unk2;
            public uint Unk3;
        }

        public uint? LastLineDuration;
        public List<Actor> Actors = new List<Actor>();
        public List<Line> Lines = new List<Line>();


        public override void LoadValuesFromUpdateFields()
        {
            LastLineDuration = UpdateFields.GetValue<ConversationField, uint?>(ConversationField.CONVERSATION_FIELD_LAST_LINE_DURATION);

            UpdateField a = UpdateFields[1000 + (int)ConversationDynamicField.CONVERSATION_DYNAMIC_FIELD_ACTORS];
            Dictionary<int, UpdateField> dynamicUpdateFields = a.Dynamic;
            for (int i = 0; i + 5 < dynamicUpdateFields.Count; i += 6)
            {
                Actor actor = new Objects.Conversation.Actor();
                actor.Id = dynamicUpdateFields[i].UInt32Value;
                actor.CreatureId = dynamicUpdateFields[i+1].UInt32Value;
                actor.Unk1 = dynamicUpdateFields[i+2].UInt32Value;
                actor.Unk2 = dynamicUpdateFields[i+3].UInt32Value;
                actor.Unk3 = dynamicUpdateFields[i+4].UInt32Value;
                actor.Unk4 = dynamicUpdateFields[i+5].UInt32Value;
                Actors.Add(actor);
            }

            a = UpdateFields[1000 + (int)ConversationDynamicField.CONVERSATION_DYNAMIC_FIELD_LINES];
            dynamicUpdateFields = a.Dynamic;
            for (int i = 0; i + 3 < dynamicUpdateFields.Count; i += 4)
            {
                Line line = new Objects.Conversation.Line();
                line.Id = dynamicUpdateFields[i].UInt32Value;
                line.PreviousLineDuration = dynamicUpdateFields[i + 1].UInt32Value;
                line.Unk2 = dynamicUpdateFields[i + 2].UInt32Value;
                line.Unk3 = dynamicUpdateFields[i + 3].UInt32Value;
                Lines.Add(line);
            }
        }

        public uint GetFirstLineId()
        {
            if (Lines.Count == 0)
                return 0;
            return Lines.First().Id;
        }

    }
}
