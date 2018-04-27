using System;

namespace HotChocolate.Language
{
    public sealed class BooleanValueNode
        : IValueNode
    {
        public BooleanValueNode(
            Location location,
            bool value)
        {
            Location = location;
            Value = value;
        }

        public NodeKind Kind { get; } = NodeKind.BooleanValue;
        public Location Location { get; }
        public bool Value { get; }
    }
}