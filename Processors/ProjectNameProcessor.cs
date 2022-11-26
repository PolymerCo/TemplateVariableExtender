using System;
using UnityEngine;

namespace Keyword.Processors {
  public class ProjectNameProcessor : KeywordProcessor {
    public ProjectNameProcessor() : base("PROJECT_NAME") { }
    
    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return Application.productName;
    }
  }
}