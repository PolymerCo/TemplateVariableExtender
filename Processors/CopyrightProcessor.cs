namespace TemplateVariableExtender.Processors {
  public class CopyrightProcessor : KeywordProcessor {
    public CopyrightProcessor() : base("COPY") { }
    
    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return "©";
    }
  }
}