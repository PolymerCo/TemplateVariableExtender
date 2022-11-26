using System;

namespace Keyword.Processors {
  public class DayProcessor : KeywordProcessor {
    public DayProcessor() : base("DAY") { }
    
    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return DateTime.Now.ToString("dd");
    }
  }
}