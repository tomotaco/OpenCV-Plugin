using System.IO;
using UnrealBuildTool;

public class OpenCVLibrary : ModuleRules
{
    private string SDKBasePath
    {
        get { return Path.Combine(ModuleDirectory, Name); }
    }

    private string SDKIncludePath
    {
        get { return Path.Combine(SDKBasePath, "Includes"); }
    }

    private string SDKLibraryPath
    {
        get {
	        	return Path.Combine(SDKBasePath, "Libraries", "Win64");
        }
    }

    public OpenCVLibrary(ReadOnlyTargetRules Target) : base(Target)
    {
        Type = ModuleType.External;

        //Add Include path 
        PublicIncludePaths.AddRange(new string[] { SDKIncludePath });

        //Add Static Libraries
        PublicAdditionalLibraries.Add(Path.Combine(SDKLibraryPath, "opencv_world455.lib"));

        //Add Dynamic Libraries
        PublicDelayLoadDLLs.Add(Path.Combine(SDKLibraryPath, "opencv_world455.dll"));
        PublicDelayLoadDLLs.Add(Path.Combine(SDKLibraryPath, "opencv_videoio_ffmpeg455_64.dll"));
        PublicDelayLoadDLLs.Add(Path.Combine(SDKLibraryPath, "opencv_videoio_msmf455_64.dll"));

        RuntimeDependencies.Add(Path.Combine(SDKLibraryPath, "opencv_world455.dll"));
        RuntimeDependencies.Add(Path.Combine(SDKLibraryPath, "opencv_videoio_ffmpeg455_64.dll"));
        RuntimeDependencies.Add(Path.Combine(SDKLibraryPath, "opencv_videoio_msmf455_64.dll"));

        RuntimeDependencies.Add(Path.Combine("$(BinaryOutputDir)", "opencv_world455.dll"), Path.Combine(SDKLibraryPath, "opencv_world455.dll"));
        RuntimeDependencies.Add(Path.Combine("$(BinaryOutputDir)", "opencv_videoio_ffmpeg455_64.dll"), Path.Combine(SDKLibraryPath, "opencv_videoio_ffmpeg455_64.dll"));
        RuntimeDependencies.Add(Path.Combine("$(BinaryOutputDir)", "opencv_videoio_msmf455_64.dll"), Path.Combine(SDKLibraryPath, "opencv_videoio_msmf455_64.dll"));

        PublicDefinitions.Add("WITH_OPENCV_BINDING=1");
        PublicDefinitions.Add("USE_IMPORT_EXPORT");
	}
}
