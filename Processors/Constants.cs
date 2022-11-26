using System.IO;

namespace TemplateVariableExtender.Processors {
  public static class Constants {
    public static readonly char[] DirectorySeparator = {
      Path.DirectorySeparatorChar,
      Path.AltDirectorySeparatorChar
    };
  }
}