// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ProjectOops : ModuleRules
{
	public ProjectOops(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ProjectOops",
			"ProjectOops/Variant_Platforming",
			"ProjectOops/Variant_Platforming/Animation",
			"ProjectOops/Variant_Combat",
			"ProjectOops/Variant_Combat/AI",
			"ProjectOops/Variant_Combat/Animation",
			"ProjectOops/Variant_Combat/Gameplay",
			"ProjectOops/Variant_Combat/Interfaces",
			"ProjectOops/Variant_Combat/UI",
			"ProjectOops/Variant_SideScrolling",
			"ProjectOops/Variant_SideScrolling/AI",
			"ProjectOops/Variant_SideScrolling/Gameplay",
			"ProjectOops/Variant_SideScrolling/Interfaces",
			"ProjectOops/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
