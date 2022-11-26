using System.Linq;

namespace editor.keyword.processors {
  public class NamespaceKeywordProcessor : KeywordProcessor {
    /** Keyword to identity the Assets directory. */
    private const string AssetsKeyword = "Assets";

    /** Separator used for namespaces. */
    private const string NamespaceSeparator = ".";
      
    /** Words to exclude from the namespace. */
    private static readonly string[] NamespaceExclusions = { "scripts", "src" };
    
    public NamespaceKeywordProcessor() : base("NAMESPACE") { }
    
    protected override string ProcessExecutor(AssetInfo assetInfo) {
      var targetNamespaceEntities = assetInfo.FilePathEntities
        .SkipLast(1) // remove filename
        .Reverse() // reverse so that going up the tree
        .TakeWhile(filename => !filename.Equals(AssetsKeyword)) // take all directories until reach Assets
        .Reverse() // reverse again to regain order
        .Where(filename => !NamespaceExclusions.Contains(filename)); // remove invalid namespace directories

      return string.Join(NamespaceSeparator, targetNamespaceEntities);
    }
  }
}