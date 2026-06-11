using UnrealBuildTool;

public class HackAndSlashEditorTarget : TargetRules
{
	public HackAndSlashEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("HackAndSlash");
	}
}
