# UnityKeywordProcessor
Unity Keyword Processor to be used in conjunction and to extend the functionality of Unity template files

# Installation

Clone the git repository into your `Assets` folder. It is preferred that you clone this within the `editor` directory within your project, however it can be placed anywhere without issue.

Example file strucutre:

- `Assets`
  - `editor`
    - `UnityKeywordProcessor`

Run this command to clone:

```bash
git clone https://github.com/PolymerCo/UnityKeywordProcessor.git
```

# Creating Templates

To create new script templates, create text files within the `Assets/ScriptTemplates` directory (you will have to create this directory yourself). In here, you can create new templates or override existing ones. You can see the already existant templates within your editor's data directory `{EditorPath}\Data\Resources\ScriptTemplates`.

For example, if you were to want to overwrite the default NewBehaviourScript template, as of Unity 2022.1.21f1 the following directory structure can be used:

- `Assets`
  - `ScriptTemplates`
    - `81-C# Script-NewBehaviourScript.cs`

# In-built Variables

Below are the current in-built variables, examples, and use:

| Variable | Example | Description |
|-|-|-|
| `NAMESPACE` | `script.path` | The scripts' namespace based on it's path.<sup>1</sup> |
| `YEAR` | `2022` | The current year. |

<sup>1</sup> the namespace will include all directories after the root `Assets` directory, excluding a number of keywords including: `scripts`, `src` <sup>2</sup>. For example, the file `Project/Assets/Scripts/World/Editor/WorldEditor.cs` will produce the namespace `World.Editor`.

<sup>2</sup> the excluded directories can be altered by editing the `Processors.NamespaceKeywordProcessor.NamespaceExclusions` array.

# Using Variables in a Template

The processor will currently act on the below extensions <sup>3</sup>:

- C# (`.cs`)
- Text (`.txt`)
- Shader (`.shader`)
- Compute Shaders (`.compute`)
- Assembly Definitions (`.asmdef`)
- Ray Tracing Shader (`.raytrace`)

To use the variable within a template, the variables name needs to be entered surrounded by `#` characters. For example, when using the namespace variable the string `#NAMESPACE#` should be used.

<sup>3</sup> the extensions can be altered by editing the `ScriptKeywordProcessor.ValidExtensions` array.

# Adding New Processors

To add a new processor, create a new class within the `processors` namespace and extend from the `KeywordProcessor` class. 

This class expects the keyword to be given as it's only constructor argument, this keyword will be used to mark what text will be replaced. For example, the namespace processor uses the keyword `"NAMESPACE"`.

There is a single abstract method that will need to be overwritten, `ProcessExecutor`. This method determines the replacement text for the keyword.  
