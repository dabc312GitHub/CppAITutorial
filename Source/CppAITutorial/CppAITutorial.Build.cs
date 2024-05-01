// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CppAITutorial : ModuleRules
{
	public CppAITutorial(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "EnhancedInput" });
	}
}
