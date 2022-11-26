using System;

namespace Keyword.Processors {
  public class ProjectNameProcessor : KeywordProcessor {
    public ProjectNameProcessor() : base("PROJECT_NAME") { }
    
    protected override string ProcessExecutor(AssetInfo assetInfo) {
      var entityCount = assetInfo.FilePathEntities.Length;
      
      // get the directory prior to the Assets directory, this can be assumed to be the product name
      for (var i = entityCount - 1; i >= 0; i--) {
        var current = assetInfo.FilePathEntities[i];

        if (!current.Equals(Constants.AssetsKeyword, StringComparison.OrdinalIgnoreCase)) {
          continue;
        }
        
        // if the next index is out of bounds, there has been an issue so should break out of the loop
        var next = i - 1;
        
        if (next < 0) break;
        
        return assetInfo.FilePathEntities[next];
      }

      // return nothing for error state
      return "";
    }
  }
}