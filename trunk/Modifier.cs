using System;

namespace MceRemoteMapper
{
    /// <summary>
    /// Modifiers.
    /// </summary>
    [Flags]
    enum Modifier : byte
    {
        None = 0,
        Control = 1,
        Shift = 2,
        Alt = 4,
        Windows = 8,
    }
}
