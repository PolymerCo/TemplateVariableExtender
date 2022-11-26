using System;
using System.Linq;

namespace Keyword.Processors {
  public class NamespaceProcessor : KeywordProcessor {
    /** Separator used for namespaces. */
    private const string NamespaceSeparator = ".";
      
    /** Words to exclude from the namespace. */
    private static readonly string[] NamespaceExclusions = { "scripts", "src", "editor" };
    
    public NamespaceProcessor() : base("NAMESPACE") { }
    
    protected override string ProcessExecutor(AssetInfo assetInfo) {
      var targetNamespaceEntities = assetInfo.FilePathEntities
        .SkipLast(1) // remove filename
        .Reverse() // reverse so that going up the tree
        .TakeWhile(filename => !filename.Equals(Constants.AssetsKeyword, StringComparison.OrdinalIgnoreCase)) // take all directories until reach Assets
        .Reverse() // reverse again to regain order
        .Where(filename => !NamespaceExclusions.Contains(filename, StringComparer.CurrentCultureIgnoreCase)); // remove invalid namespace directories

      return string.Join(NamespaceSeparator, targetNamespaceEntities);
    }
  }
}