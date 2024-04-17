// Made by Steven Kearney

using UnrealBuildTool;
using System.Collections.Generic;

public class LDPTarget : TargetRules
{
	public LDPTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "LDP" } );
	}
}
