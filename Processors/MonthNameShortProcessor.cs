using System;

namespace Keyword.Processors {
  public class MonthNameShortProcessor : KeywordProcessor {
    public MonthNameShortProcessor() : base("MONTH_NAME_SHORT") { }
    
    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return DateTime.Now.ToString("MMM");
    }
  }
}