using System;

namespace Keyword.Processors {
  public class MonthNameFullProcessor : KeywordProcessor {
    public MonthNameFullProcessor() : base("MONTH_NAME_FULL") { }
    
    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return DateTime.Now.ToString("MMMM");
    }
  }
}