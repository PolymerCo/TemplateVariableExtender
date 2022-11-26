using System;

namespace TemplateVariableExtender.Processors {
  public class MonthProcessor : KeywordProcessor {
    public MonthProcessor() : base("MONTH") { }
    
    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return DateTime.Now.ToString("M");
    }
  }
}