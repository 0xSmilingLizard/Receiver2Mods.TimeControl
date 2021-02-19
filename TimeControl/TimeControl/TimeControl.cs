using BepInEx;
using BepInEx.Configuration;

using Receiver2;

namespace TimeControl
{
    [BepInProcess("Receiver2.exe")]
    [BepInPlugin("SmilingLizard.plugins.timecontrol", "Time Control", "1.1")]
    public class MediaModeControls : BaseUnityPlugin
    {
        #region MediaModeValues

        private bool _MM_Enabled
        {
            get => ConfigFiles.global.media_mode_enabled;
            set => ConfigFiles.global.media_mode_enabled = value;
        }

        private float _MM_TimeScale
        {
            set => ConfigFiles.global.media_mode_time_scale = value;
        }

        #endregion MediaModeValues

        #region ConfigValues

        private ConfigEntry<KeyboardShortcut> _keyToggleMM_Enabled;

        private ConfigEntry<float> _mmTimeScale1;
        private ConfigEntry<KeyboardShortcut> _keySetMM_TimeScale1;

        private ConfigEntry<float> _mmTimeScale2;
        private ConfigEntry<KeyboardShortcut> _keySetMM_TimeScale2;

        private ConfigEntry<float> _mmTimeScale3;
        private ConfigEntry<KeyboardShortcut> _keySetMM_TimeScale3;

        private ConfigEntry<float> _mmTimeScale4;
        private ConfigEntry<KeyboardShortcut> _keySetMM_TimeScale4;

        private ConfigEntry<float> _mmTimeScale5;
        private ConfigEntry<KeyboardShortcut> _keySetMM_TimeScale5;

        #endregion ConfigValues

        public void Awake()
        {
            this._keyToggleMM_Enabled = this.Config.Bind(
                "MediaMode", "Toggle Enabled", KeyboardShortcut.Empty);

            this._keySetMM_TimeScale1 = this.Config.Bind(
                "Timescale Preset 1", "Set", KeyboardShortcut.Empty);
            this._mmTimeScale1 = this.Config.Bind(
                "Timescale Preset 1", "Value", 1f, new ConfigDescription(
                    "", new AcceptableValueRange<float>(0.001f, 2f)));

            this._keySetMM_TimeScale2 = this.Config.Bind(
                "Timescale Preset 2", "Set", KeyboardShortcut.Empty);
            this._mmTimeScale2 = this.Config.Bind(
                "Timescale Preset 2", "Value", 1f, new ConfigDescription(
                    "", new AcceptableValueRange<float>(0.001f, 2f)));

            this._keySetMM_TimeScale3 = this.Config.Bind(
                "Timescale Preset 3", "Set", KeyboardShortcut.Empty);
            this._mmTimeScale3 = this.Config.Bind(
                "Timescale Preset 3", "Value", 1f, new ConfigDescription(
                    "", new AcceptableValueRange<float>(0.001f, 2f)));

            this._keySetMM_TimeScale4 = this.Config.Bind(
                "Timescale Preset 4", "Set", KeyboardShortcut.Empty);
            this._mmTimeScale4 = this.Config.Bind(
                "Timescale Preset 4", "Value", 1f, new ConfigDescription(
                    "", new AcceptableValueRange<float>(0.001f, 2f)));

            this._keySetMM_TimeScale5 = this.Config.Bind(
                "Timescale Preset 5", "Set", KeyboardShortcut.Empty);
            this._mmTimeScale5 = this.Config.Bind(
                "Timescale Preset 5", "Value", 1f, new ConfigDescription(
                    "", new AcceptableValueRange<float>(0.001f, 2f)));
        }

        public void Update()
        {
            if (UnityEngine.Input.GetKeyDown(this._keyToggleMM_Enabled.Value.MainKey))
            {
                this._MM_Enabled = !this._MM_Enabled;
            }
            if (UnityEngine.Input.GetKeyDown(this._keySetMM_TimeScale1.Value.MainKey))
            {
                this._MM_TimeScale = this._mmTimeScale1.Value;
            }
            if (UnityEngine.Input.GetKeyDown(this._keySetMM_TimeScale2.Value.MainKey))
            {
                this._MM_TimeScale = this._mmTimeScale2.Value;
            }
            if (UnityEngine.Input.GetKeyDown(this._keySetMM_TimeScale3.Value.MainKey))
            {
                this._MM_TimeScale = this._mmTimeScale3.Value;
            }
            if (UnityEngine.Input.GetKeyDown(this._keySetMM_TimeScale4.Value.MainKey))
            {
                this._MM_TimeScale = this._mmTimeScale4.Value;
            }
            if (UnityEngine.Input.GetKeyDown(this._keySetMM_TimeScale5.Value.MainKey))
            {
                this._MM_TimeScale = this._mmTimeScale5.Value;
            }
        }
    }
}