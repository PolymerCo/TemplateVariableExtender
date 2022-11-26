namespace Keyword.Processors {
  public class FileNameProcessor : KeywordProcessor {
    public FileNameProcessor() : base("FILE_NAME") { }
    
    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return assetInfo.FileName;
    }
  }
}