using System;

namespace editor.keyword.processors {
  public class YearKeywordProcessor : KeywordProcessor {
    public YearKeywordProcessor() : base("YEAR") { }
    
    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return DateTime.Now.Year.ToString();
    }
  }
}