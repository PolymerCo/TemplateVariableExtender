# Template Variable Extender

Template Variable Extender is to be used in conjunction and to extend the functionality of Unity template files. This
tool expands the available template variables in order to match the functionality offered by other editors.

# Installation

Clone the git repository into your `Assets` folder. It is preferred that you clone this within the `editor` directory
within your project, however it can be placed anywhere without issue.

Example file structure:

- `Assets`
    - `editor`
        - `UnityKeywordProcessor`

Run this command to clone:

```bash
git clone https://github.com/PolymerCo/UnityKeywordProcessor.git
```

# Creating Templates

To create new script templates, create text files within the `Assets/ScriptTemplates` directory (you will have to create
this directory yourself). In here, you can create new templates or override existing ones. You can see the already
existent templates within your editor's data directory `{EditorPath}\Data\Resources\ScriptTemplates`.

It is also possible to modify/create new templates within the editor's data directory, however this may not be desired
as it makes collaboration more difficult.

For example, if you were to want to overwrite the default NewBehaviourScript template, as of Unity 2022.1.21f1 the
following directory structure can be used:

- `Assets`
<<<<<<< HEAD
    - `ScriptTemplates`
        - `81-C# Script-NewBehaviourScript.cs`
=======
  - `ScriptTemplates`
    - `81-C# Script-NewBehaviourScript.cs.txt`
>>>>>>> e37629da35b56d284ded5dddbcd9efacc375ba27

# Available Variables

| Variable           | Example                    | Description                                            |
|:-------------------|:---------------------------|:-------------------------------------------------------|
| `COPY`             | `©`                        | Copyright symbol.                                      |
| `NAMESPACE`        | `script.path`              | The scripts' namespace based on it's path.<sup>1</sup> |
| `DATE`             | `3/6/2022`                 | The current date.                                      |
| `DAY`              | `03`                       | The current day.                                       |
| `MONTH`            | `06`                       | The current month.                                     |
| `MONTH_NAME_SHORT` | `Jun`                      | The current month's short name.                        |
| `MONTH_NAME_FULL`  | `June`                     | The current month's full name.                         |
| `YEAR`             | `2022`                     | The current year.                                      |
| `TIME`             | `1:45 PM`                  | The current time.                                      |
| `HOUR`             | `13`                       | The current hour (24h format).                         |
| `MINUTE`           | `45`                       | The current minute.                                    |
| `SECOND`           | `32`                       | The current second.                                    |
| `DIR_PATH`         | `Assets/Scripts/MyFile.cs` | The path of the file from the project root.            |
| `FILE_NAME`        | `MyFile`                   | The name of the file without the extension.            |
| `FILE_NAME_FULL`   | `MyFile.cs`                | The name of the file with the extensions.              |
| `EXTENSION`        | `.cs`                      | The file extension.                                    |
| `PRODUCT_NAME`     | `Unity`                    | The name of the editor (will likely always be Unity!). |
| `PRODUCT_VERSION`  | `2022.1.21f1`              | The version of the Unity editor.                       |
| `PLATFORM`         | `WindowEditor`             | The platform of the editor.                            |
| `PROJECT_NAME`     | `MyProject`                | The name of your project.                              |
| `CLOUD_PROJECT_ID` | `1234`                     | The cloud project ID.                                  |
| `COMPANY`          | `MyCompany`                | Your company name.                                     |
| `USER`             | `john`                     | The user of the account running the Unity process.     |

<sup>1</sup> the namespace will include all directories after the root `Assets` directory, excluding a number of
keywords including: `scripts`, `src` <sup>2</sup>. For example, the
file `Project/Assets/Scripts/World/Viewer/WorldViewer.cs` will produce the namespace `World.Viewer`.

<sup>2</sup> the excluded directories can be altered by editing
the `Processors.NamespaceKeywordProcessor.NamespaceExclusions` array.

# Using Variables in a Template

The processor will currently act on the below extensions <sup>3</sup>:

- C# (`.cs`)
- Text (`.txt`)
- Shader (`.shader`)
- Compute Shaders (`.compute`)
- Assembly Definitions (`.asmdef`)
- Ray Tracing Shader (`.raytrace`)

To use the variable within a template, the variables name needs to be entered surrounded by `#` characters. For example,
when using the namespace variable the string `#NAMESPACE#` should be used.

<sup>3</sup> the extensions can be altered by editing the `ScriptKeywordProcessor.ValidExtensions` array.

# Adding New Processors

To add a new processor, create a new class within the `processors` namespace and extend from the `KeywordProcessor`
class.

This class expects the keyword to be given as it's only constructor argument, this keyword will be used to mark what
text will be replaced. For example, the namespace processor uses the keyword `"NAMESPACE"`.

There is a single abstract method that will need to be overwritten, `ProcessExecutor`. This method determines the
replacement text for the keyword.  
