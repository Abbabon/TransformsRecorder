# Transforms Recorder

[![openupm]()
[![Hits](https://hits.seeyoufarm.com/api/count/incr/badge.svg?url=https%3A%2F%2Fgithub.com%2FAbbabon%2FTransformsRecorder&count_bg=%2379C83D&title_bg=%23555555&icon=&icon_color=%23E7E7E7&title=hits&edge_flat=false)](https://hits.seeyoufarm.com)

This tool can be used to record a complex hierarchy of GameObject's child transforms (during editor or runtime) in a ScriptableObject. This allows you to pose the character around your scene, take marketing screenshots, or anything similar.

More motivations and implementation details [can be found at my blog](https://abbabon.github.io/2020-11-09-serializing-transforms/)

# Install

## Open UPM

TransformsRecorder can be installed via [OpenUPM](https://openupm.com/). It's recommended to install it via [openupm-cli](https://github.com/openupm/openupm-cli):

`openupm add com.mezookan.transforms-recorder`

## Git Dependency

You can add the package to your project as a [git upm dependency](https://docs.unity3d.com/Manual/upm-git.html).

Either add the following line to your project's `Packages/manifest.json` file's dependencies:

    "com.mezookan.transforms-recorder":"https://github.com/abbabon/TransformsRecorder.git?path=Packages/TransformsRecorder",

or via the `Windows/PackageManager` menu, by adding the following git repo: `https://github.com/abbabon/TransformsRecorder.git?path=Packages/TransformsRecorder`

# How to use

1. Place the 'TransformRecorder' script on any object in your scene. 
2. Drag the parent of the transform hierarchy you wish to record to the 'Parent Transform' field. 
3. Create a scriptable object from TransformDataContainer by right clicking on you project window, and then `Create->ScriptableObjects->TransformDataContainer`
4. Drag the new TransformDataContainer to the TransformRecorder's relevant field.

You can now save the transform hierarchy by pressing the 'Record Transforms' button, or load with 'Load Transforms'.
Just remember to create a scriptable object for each pose / sate. I encourage you to experiment further and expand the system.

An example scene is setup in the [repo](https://github.com/Abbabon/TransformsRecorder) (not in the package), so you can see it in action.

# License

Free to use under the [MIT License](https://opensource.org/licenses/MIT)

# Third Party Notices

'The Boss' Model and animations supplied by Adobe (taken from Mixamo.com).