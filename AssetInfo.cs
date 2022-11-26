using System.IO;
using System.Linq;
using Keyword.Processors;

namespace Keyword {
  public sealed class AssetInfo {
    /** Temp filename associated with keyword processor temp files. */
    private const string TempExtension = "kwdtmp";
    
    /** Name of the asset as provided by Unity. */
    public string Name { get; }
    
    /* The full path of the asset file. */
    public string FilePath { get; }
    
    /** List of path entities. */
    public string[] FilePathEntities { get; }
    
    /* List of path entities, relative to the project root. */
    public string[] RelativeFilePathEntities { get; }
    
    /** The full path to the asset's parent directory. */
    public string ParentFilePath { get; }
    
    /** Filename of the asset. */
    public string FileName { get; }
    
    /** Filename of the asset, including the extension. */
    public string FullFileName { get; }
    
    /** File extension of the asset. */
    public string FileExtension { get; }
    
    /** Temporary file path when processing this asset. */
    public string TempFilePath { get; }

    public AssetInfo(string assetName) {
      Name = assetName;
      FilePath = Path.GetFullPath(assetName);
      FilePathEntities = FilePath.Split(Constants.DirectorySeparator);
      RelativeFilePathEntities = Name.Split(Constants.DirectorySeparator);
      ParentFilePath = string.Join(new string(Constants.DirectorySeparator), FilePathEntities.SkipLast(1));
      FileName = Path.GetFileNameWithoutExtension(FilePath);
      FullFileName = Path.GetFileName(FilePath);
      FileExtension = Path.GetExtension(FilePath);
      TempFilePath = $"{ParentFilePath}{Constants.DirectorySeparator}.{FullFileName}.{TempExtension}";
    }
  }
}