using UnrealBuildTool;

public class SEU1stPartForTarget : TargetRules
{
	public SEU1stPartForTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("SEU1stPartFor");
	}
}
