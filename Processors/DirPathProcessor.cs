namespace TemplateVariableExtender.Processors {
  public class DirPathProcessor : KeywordProcessor {
    public DirPathProcessor() : base("DIR_PATH") { }

    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return assetInfo.Name;
    }
  }
}