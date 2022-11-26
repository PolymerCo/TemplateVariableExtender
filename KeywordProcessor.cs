
namespace editor.keyword {
  public abstract class KeywordProcessor {
    /** Wrapper for the keywords. */
    private const char KeywordWrapper = '#';

    /** Keyword to identify replacement targets. */
    private readonly string _keyword;

    protected KeywordProcessor(string identifier) {
      _keyword = $"{KeywordWrapper}{identifier}{KeywordWrapper}";
    }
    
    public string Process(AssetInfo assetInfo, string line) {
      return line.Contains(_keyword, StringComparison.OrdinalIgnoreCase) ? line.Replace(_keyword, ProcessExecutor(assetInfo)) : line;
    }

    protected abstract string ProcessExecutor(AssetInfo assetInfo);
  }
}