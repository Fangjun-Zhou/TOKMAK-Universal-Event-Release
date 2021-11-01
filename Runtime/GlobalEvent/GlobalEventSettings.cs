using Hextant;
using UnityEngine.Serialization;
#if UNITY_EDITOR
using Hextant.Editor;
using UnityEditor;
#endif

namespace FinTOKMAK.EventSystem.Runtime.GlobalEvent
{
    /// <summary>
    /// The settings for global event, similar settings for local event
    /// </summary>
    [Settings( SettingsUsage.RuntimeProject, "FinTOKMAK Global Event" )]
    public sealed class GlobalEventSettings : Settings<GlobalEventSettings>
    {
        public UniversalEventConfig universalEventConfig;
        
#if UNITY_EDITOR
        [SettingsProvider]
        static SettingsProvider GetSettingsProvider() =>
            instance.GetSettingsProvider();
#endif
    }
}