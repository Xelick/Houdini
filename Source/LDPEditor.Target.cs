// Made by Steven Kearney

using UnrealBuildTool;
using System.Collections.Generic;

public class LDPEditorTarget : TargetRules
{
	public LDPEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "LDP" } );
	}
}
