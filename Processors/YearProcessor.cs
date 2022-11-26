using System;

namespace Keyword.Processors {
  public class YearProcessor : KeywordProcessor {
    public YearProcessor() : base("YEAR") { }
    
    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return DateTime.Now.ToString("yyyy");
    }
  }
}