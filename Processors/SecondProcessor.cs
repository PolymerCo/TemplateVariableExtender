using System;

namespace TemplateVariableExtender.Processors {
  public class SecondProcessor : KeywordProcessor {
    public SecondProcessor() : base("SECOND") { }
    
    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return DateTime.Now.ToString("ss");
    }
  }
}