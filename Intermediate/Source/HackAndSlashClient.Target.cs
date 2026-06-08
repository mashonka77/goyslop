using UnrealBuildTool;

public class HackAndSlashClientTarget : TargetRules
{
	public HackAndSlashClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("HackAndSlash");
	}
}
