using UnityEngine;

namespace Keyword.Processors {
  public class ProductNameProcessor : KeywordProcessor {
    public ProductNameProcessor() : base("PRODUCT_NAME") { }
    
    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return "Unity";
    }
  }
}