using System;

namespace MceRemoteMapper
{
    /// <summary>
    /// Represents one remote button to key press mapping.
    /// </summary>
    class Mapping
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="data">Data.</param>
        /// <param name="offset">Offset in data.</param>
        public Mapping(byte[] data, int offset)
        {
            this.data = data;
            this.offset = offset;
        }

        /// <summary>
        /// Offset.
        /// </summary>
        private readonly int offset;

        /// <summary>
        /// Data.
        /// </summary>
        private readonly byte[] data;
        
        /// <summary>
        /// Id.
        /// </summary>
        public byte Id { get { return data[offset + 0]; } }

        /// <summary>
        /// Remote button.
        /// </summary>
        public RemoteButton RemoteButton { get { return Enum.IsDefined(typeof(RemoteButton), Id) ? (RemoteButton)Id : RemoteButton.Unknown; } }

        /// <summary>
        /// Type.
        /// </summary>
        public MappingType Type { get { return (MappingType)data[offset + 4]; } set { data[offset + 4] = (byte)value; } }

        /// <summary>
        /// Scan code.
        /// </summary>
        public ScanCode ScanCode { get { return (ScanCode)data[offset + 6]; } set { data[offset + 6] = (byte)value; } }

        /// <summary>
        /// Modifier.
        /// </summary>
        private Modifier Modifier { get { return (Modifier)data[offset + 5]; } set { data[offset + 5] = (byte)value; } }

        /// <summary>
        /// Shift.
        /// </summary>
        public bool Shift { get { return GetModifier(Modifier.Shift); } set { SetModifier(Modifier.Shift, value); } }

        /// <summary>
        /// Alt.
        /// </summary>
        public bool Alt { get { return GetModifier(Modifier.Alt); } set { SetModifier(Modifier.Alt, value); } }

        /// <summary>
        /// Control.
        /// </summary>
        public bool Control { get { return GetModifier(Modifier.Control); } set { SetModifier(Modifier.Control, value); } }

        /// <summary>
        /// Windows.
        /// </summary>
        public bool Windows { get { return GetModifier(Modifier.Windows); } set { SetModifier(Modifier.Windows, value); } }
     
        /// <summary>
        /// Get modifier.
        /// </summary>
        /// <param name="modifier">Modifier to check.</param>
        /// <returns>True or false if modifier is set or not.</returns>
        private bool GetModifier(Modifier modifier)
        {
            return (Modifier & modifier) == modifier;
        }

        /// <summary>
        /// Sets value of given modifier.
        /// </summary>
        /// <param name="modifier">Modifier to set or unset.</param>
        /// <param name="value">Value - true to set, false to unset.</param>
        private void SetModifier(Modifier modifier, bool value)        
        {
            Modifier = value ? Modifier | modifier : Modifier & ~modifier;
        }
    }
}
