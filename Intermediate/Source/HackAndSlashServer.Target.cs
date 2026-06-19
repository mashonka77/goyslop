using UnrealBuildTool;

public class HackAndSlashServerTarget : TargetRules
{
	public HackAndSlashServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("HackAndSlash");
	}
}
