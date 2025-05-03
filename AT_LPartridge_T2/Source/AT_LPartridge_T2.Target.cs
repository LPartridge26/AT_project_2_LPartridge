// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class AT_LPartridge_T2Target : TargetRules
{
	public AT_LPartridge_T2Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V4;

        ExtraModuleNames.AddRange( new string[] { "AT_LPartridge_T2" } );
	}
}
