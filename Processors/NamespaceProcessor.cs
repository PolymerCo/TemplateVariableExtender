using System;
using System.Linq;
using UnityEngine;

namespace Keyword.Processors {
  public class NamespaceProcessor : KeywordProcessor {
    /** Separator used for namespaces. */
    private const string NamespaceSeparator = ".";
      
    /** Words to exclude from the namespace. */
    private static readonly string[] NamespaceExclusions = { "scripts", "src", "editor" };
    
    public NamespaceProcessor() : base("NAMESPACE") { }
    
    protected override string ProcessExecutor(AssetInfo assetInfo) {
      var targetNamespaceEntities = assetInfo.RelativeFilePathEntities
        .SkipLast(1) // remove filename
        .Skip(1)
        .Where(filename => !NamespaceExclusions.Contains(filename, StringComparer.CurrentCultureIgnoreCase)); // remove invalid namespace directories

      return string.Join(NamespaceSeparator, targetNamespaceEntities);
    }
  }
}