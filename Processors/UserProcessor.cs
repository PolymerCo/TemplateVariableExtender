using System;

namespace Keyword.Processors {
  public class UserProcessor : KeywordProcessor {
    public UserProcessor() : base("USER") { }
    
    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return Environment.UserName;
    }
  }
}