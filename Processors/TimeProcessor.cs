using System;

namespace Keyword.Processors {
  public class TimeProcessor : KeywordProcessor {
    public TimeProcessor() : base("TIME") { }
    
    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return DateTime.Now.ToShortTimeString();
    }
  }
}