namespace Keyword.Processors {
  public class ExtensionProcessor : KeywordProcessor {
    public ExtensionProcessor() : base("EXTENSION") { }
    
    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return assetInfo.FileExtension;
    }
  }
}