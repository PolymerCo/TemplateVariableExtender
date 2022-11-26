using System;

namespace TemplateVariableExtender.Processors {
  public class HourProcessor : KeywordProcessor {
    public HourProcessor() : base("HOUR") { }
    
    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return DateTime.Now.ToString("HH");
    }
  }
}