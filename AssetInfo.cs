using System.IO;
using System.Linq;

namespace Keyword {
  public sealed class AssetInfo {
    /** Temp filename associated with keyword processor temp files. */
    private const string TempExtension = "kwdtmp";
    
    public string Name { get; }
    public string FilePath { get; }
    public string[] FilePathEntities { get; }
    public string ParentFilePath { get; }
    public string FileName { get; }
    public string FullFileName { get; }
    public string FileExtension { get; }
    public string TempFilePath { get; }

    public AssetInfo(string assetName) {
      Name = assetName;
      FilePath = Path.GetFullPath(assetName);
      FilePathEntities = FilePath.Split(Path.DirectorySeparatorChar);
      ParentFilePath = string.Join(Path.DirectorySeparatorChar, FilePathEntities.SkipLast(1));
      FileName = Path.GetFileNameWithoutExtension(FilePath);
      FullFileName = Path.GetFileName(FilePath);
      FileExtension = Path.GetExtension(FilePath);
      TempFilePath = $"{ParentFilePath}{Path.DirectorySeparatorChar}.{FullFileName}.{TempExtension}";
    }
  }
}