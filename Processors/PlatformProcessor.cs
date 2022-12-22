using UnityEngine;

namespace TemplateVariableExtender.Processors {
  public class PlatformProcessor : KeywordProcessor {
    public PlatformProcessor() : base("PLATFORM") { }

    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return Application.platform.ToString();
    }
  }
}