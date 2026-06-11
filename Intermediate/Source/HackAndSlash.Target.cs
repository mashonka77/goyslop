using UnrealBuildTool;

public class HackAndSlashTarget : TargetRules
{
	public HackAndSlashTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("HackAndSlash");
	}
}
