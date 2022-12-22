namespace TemplateVariableExtender.Processors {
  public class FileNameFullProcessor : KeywordProcessor {
    public FileNameFullProcessor() : base("FILE_NAME_FULL") { }

    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return assetInfo.FullFileName;
    }
  }
}