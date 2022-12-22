using System;

namespace TemplateVariableExtender.Processors {
  public class DateProcessor : KeywordProcessor {
    public DateProcessor() : base("DATE") { }

    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return DateTime.Now.ToShortDateString();
    }
  }
}