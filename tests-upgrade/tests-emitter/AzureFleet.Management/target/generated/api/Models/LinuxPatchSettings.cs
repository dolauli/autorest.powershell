// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Specifies settings related to VM Guest Patching on Linux.</summary>
    public partial class LinuxPatchSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettings,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettingsInternal
    {

        /// <summary>Backing field for <see cref="AssessmentMode" /> property.</summary>
        private string _assessmentMode;

        /// <summary>
        /// Specifies the mode of VM Guest Patch Assessment for the IaaS virtual
        /// machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You
        /// control the timing of patch assessments on a virtual machine. <br /><br />
        /// **AutomaticByPlatform** - The platform will trigger periodic patch assessments.
        /// The property provisionVMAgent must be true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string AssessmentMode { get => this._assessmentMode; set => this._assessmentMode = value; }

        /// <summary>Backing field for <see cref="AutomaticByPlatformSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxVMGuestPatchAutomaticByPlatformSettings _automaticByPlatformSetting;

        /// <summary>
        /// Specifies additional settings for patch mode AutomaticByPlatform in VM Guest
        /// Patching on Linux.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxVMGuestPatchAutomaticByPlatformSettings AutomaticByPlatformSetting { get => (this._automaticByPlatformSetting = this._automaticByPlatformSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.LinuxVMGuestPatchAutomaticByPlatformSettings()); set => this._automaticByPlatformSetting = value; }

        /// <summary>Enables customer to schedule patching without accidental upgrades</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxVMGuestPatchAutomaticByPlatformSettingsInternal)AutomaticByPlatformSetting).BypassPlatformSafetyChecksOnUserSchedule; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxVMGuestPatchAutomaticByPlatformSettingsInternal)AutomaticByPlatformSetting).BypassPlatformSafetyChecksOnUserSchedule = value ?? default(bool); }

        /// <summary>
        /// Specifies the reboot setting for all AutomaticByPlatform patch installation
        /// operations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string AutomaticByPlatformSettingRebootSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxVMGuestPatchAutomaticByPlatformSettingsInternal)AutomaticByPlatformSetting).RebootSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxVMGuestPatchAutomaticByPlatformSettingsInternal)AutomaticByPlatformSetting).RebootSetting = value ?? null; }

        /// <summary>Internal Acessors for AutomaticByPlatformSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxVMGuestPatchAutomaticByPlatformSettings Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettingsInternal.AutomaticByPlatformSetting { get => (this._automaticByPlatformSetting = this._automaticByPlatformSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.LinuxVMGuestPatchAutomaticByPlatformSettings()); set { {_automaticByPlatformSetting = value;} } }

        /// <summary>Backing field for <see cref="PatchMode" /> property.</summary>
        private string _patchMode;

        /// <summary>
        /// Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual
        /// machines associated to virtual machine scale set with OrchestrationMode as
        /// Flexible.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - The
        /// virtual machine's default patching configuration is used. <br /><br />
        /// **AutomaticByPlatform** - The virtual machine will be automatically updated by
        /// the platform. The property provisionVMAgent must be true
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string PatchMode { get => this._patchMode; set => this._patchMode = value; }

        /// <summary>Creates an new <see cref="LinuxPatchSettings" /> instance.</summary>
        public LinuxPatchSettings()
        {

        }
    }
    /// Specifies settings related to VM Guest Patching on Linux.
    public partial interface ILinuxPatchSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies the mode of VM Guest Patch Assessment for the IaaS virtual
        /// machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You
        /// control the timing of patch assessments on a virtual machine. <br /><br />
        /// **AutomaticByPlatform** - The platform will trigger periodic patch assessments.
        /// The property provisionVMAgent must be true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the mode of VM Guest Patch Assessment for the IaaS virtual
        machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You
        control the timing of patch assessments on a virtual machine. <br /><br />
        **AutomaticByPlatform** - The platform will trigger periodic patch assessments.
        The property provisionVMAgent must be true.",
        SerializedName = @"assessmentMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("ImageDefault", "AutomaticByPlatform")]
        string AssessmentMode { get; set; }
        /// <summary>Enables customer to schedule patching without accidental upgrades</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enables customer to schedule patching without accidental upgrades",
        SerializedName = @"bypassPlatformSafetyChecksOnUserSchedule",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule { get; set; }
        /// <summary>
        /// Specifies the reboot setting for all AutomaticByPlatform patch installation
        /// operations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the reboot setting for all AutomaticByPlatform patch installation
        operations.",
        SerializedName = @"rebootSetting",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Unknown", "IfRequired", "Never", "Always")]
        string AutomaticByPlatformSettingRebootSetting { get; set; }
        /// <summary>
        /// Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual
        /// machines associated to virtual machine scale set with OrchestrationMode as
        /// Flexible.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - The
        /// virtual machine's default patching configuration is used. <br /><br />
        /// **AutomaticByPlatform** - The virtual machine will be automatically updated by
        /// the platform. The property provisionVMAgent must be true
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual
        machines associated to virtual machine scale set with OrchestrationMode as
        Flexible.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - The
        virtual machine's default patching configuration is used. <br /><br />
        **AutomaticByPlatform** - The virtual machine will be automatically updated by
        the platform. The property provisionVMAgent must be true",
        SerializedName = @"patchMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("ImageDefault", "AutomaticByPlatform")]
        string PatchMode { get; set; }

    }
    /// Specifies settings related to VM Guest Patching on Linux.
    internal partial interface ILinuxPatchSettingsInternal

    {
        /// <summary>
        /// Specifies the mode of VM Guest Patch Assessment for the IaaS virtual
        /// machine.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - You
        /// control the timing of patch assessments on a virtual machine. <br /><br />
        /// **AutomaticByPlatform** - The platform will trigger periodic patch assessments.
        /// The property provisionVMAgent must be true.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("ImageDefault", "AutomaticByPlatform")]
        string AssessmentMode { get; set; }
        /// <summary>
        /// Specifies additional settings for patch mode AutomaticByPlatform in VM Guest
        /// Patching on Linux.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxVMGuestPatchAutomaticByPlatformSettings AutomaticByPlatformSetting { get; set; }
        /// <summary>Enables customer to schedule patching without accidental upgrades</summary>
        bool? AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule { get; set; }
        /// <summary>
        /// Specifies the reboot setting for all AutomaticByPlatform patch installation
        /// operations.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Unknown", "IfRequired", "Never", "Always")]
        string AutomaticByPlatformSettingRebootSetting { get; set; }
        /// <summary>
        /// Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual
        /// machines associated to virtual machine scale set with OrchestrationMode as
        /// Flexible.<br /><br /> Possible values are:<br /><br /> **ImageDefault** - The
        /// virtual machine's default patching configuration is used. <br /><br />
        /// **AutomaticByPlatform** - The virtual machine will be automatically updated by
        /// the platform. The property provisionVMAgent must be true
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("ImageDefault", "AutomaticByPlatform")]
        string PatchMode { get; set; }

    }
}