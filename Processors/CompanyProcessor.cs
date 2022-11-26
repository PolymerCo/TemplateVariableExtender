using UnityEngine;

namespace TemplateVariableExtender.Processors {
  public class CompanyProcessor : KeywordProcessor {
    public CompanyProcessor() : base("COMPANY") { }
    
    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return Application.companyName;
    }
  }
}