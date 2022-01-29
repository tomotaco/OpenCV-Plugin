// Some copyright should be here...

using UnrealBuildTool;
using System.IO;

public class OpenCV : ModuleRules
{
	public OpenCV(ReadOnlyTargetRules Target) : base(Target)
	{
        // Startard Module Dependencies
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "ThirdParty", "OpenCVLibrary", "Includes"));
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "RHI", "RenderCore", "OpenCVLibrary" });
		PrivateDependencyModuleNames.AddRange(new string[] { "CoreUObject", "Engine", "Slate", "SlateCore" });
	}
}
