using UnityEngine;

namespace TemplateVariableExtender.Processors {
  public class CloudProjectIdProcessor : KeywordProcessor {
    public CloudProjectIdProcessor() : base("CLOUD_PROJECT_ID") { }

    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return Application.cloudProjectId;
    }
  }
}