using Microsoft.Win32;
using System.Collections.Generic;

namespace MceRemoteMapper
{
    /// <summary>
    /// Functionality to load/save remote mappings.
    /// </summary>
    class Remote
    {
        /// <summary>
        /// Key location in registry.
        /// </summary>
        private const string subKey = @"SYSTEM\CurrentControlSet\Services\HidIr\Remotes\745a17a0-74d3-11d0-b6fe-00a0c90f57da";

        /// <summary>
        /// Value key in registry.
        /// </summary>
        private const string valueKey = "ReportMappingTable";

        /// <summary>
        /// Mapping data.
        /// </summary>
        private readonly byte[] data;

        /// <summary>
        /// Detect if remote reciver is present.
        /// </summary>
        /// <returns></returns>
        public static bool Detect()
        {
            using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(subKey))
                return registryKey != null && new List<string>(registryKey.GetValueNames()).Contains(valueKey);
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public Remote()
        {
            // Load data.
            using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(subKey))
                data = ((byte[])registryKey.GetValue(valueKey));

            // Create mapping instances.
            Mappings = new List<Mapping>();
            for (int offset = 0; offset < data.Length; offset += 7)
            {
                var mapping = new Mapping(data, offset);
                if (mapping.Type == MappingType.SendKeyStroke)
                    Mappings.Add(mapping);
            }
        }

        /// <summary>
        /// Mappings.
        /// </summary>
        public List<Mapping> Mappings { get; private set; }

        /// <summary>
        /// Save mappings.
        /// </summary>
        public void Save()
        {
            using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(subKey, true))
                registryKey.SetValue(valueKey, data);           
        }
    }
}