# OpenCV Plugin

[<img align="right" src="https://raw.github.com/Brandon-Wilson/OpenCV-Plugin/master/Plugins/OpenCV/Resources/Icon128.png" width="128" height="128"/>](https://raw.github.com/Brandon-Wilson/OpenCV-Plugin/master/Plugins/OpenCV/Resources/Icon128.png)
A simple OpenCV plugin that integrates the OpenCV library into UE4. The plugin includes some blueprint classes that demonstrate how OpenCV can interact with the engine.
This fork was modified to work on OpenCV 4.5.5 and UE4.27 on Windows10(64bit).

## Installing

- Copy Plugins/OpenCV directory below Plugins folder of your project.If you don't have any source code, open the editor and add c++ source in the file menu.

- Download OpenCV binary package for Windows(`opencv-4.5.5-vc14_vc15.exe`) from https://github.com/opencv/opencv/releases/tag/4.5.5 .
  Extract the package and copy some dlls and libs. (See [here](Plugins/OpenCV/Source/ThirdParty/OpenCVLibrary/Includes/Readme.md) and [here](Plugins/OpenCV/Source/ThirdParty/OpenCVLibrary/Libraries/Win64/Readme.md) for details.)

- Comment out the following parts in Plugins/OpenCV/Source/ThirdParty/OpenCVLibrary/Includes/opencv2/core/utility.hpp to fix compilation error. (This fix is same as OpenCV 3.2.0)

  - `utility.hpp` line 52:
    ```
    //#if defined(check)
    //#  warning Detected Apple 'check' macro definition, it can cause build conflicts. Please, include this header before any Apple headers.
    //#endif
    ```
  - `utility.hpp` line 934:
    ```
    //bool check() const;
    ```

Afterwards, be sure to regenerate project files. For visual studios, right click your project (.uasset) file and select 'generate visual studio project files' after deleting your previous visual studios file.

## Usage

Add the "OpenCV" public module dependency to your project's Build.CS file to write custom OpenCV code in your project.

Enable the Computer Vision > OpenCV plugin in the editor's Edit > Plguins menu to gain access to the blueprint classes in-editor.

For an in-depth description of the plugin, please see the [tutorial.](https://unrealcommunity.wiki/integrating-opencv-into-unreal-engine-4-z0dpdgkn)

# License

Licensed under the BSD License. Please see the LICENSE file included with the plugin's source code.
