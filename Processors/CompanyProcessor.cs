using UnityEngine;

namespace Keyword.Processors {
  public class CompanyProcessor : KeywordProcessor {
    public CompanyProcessor() : base("COMPANY") { }
    
    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return Application.companyName;
    }
  }
}