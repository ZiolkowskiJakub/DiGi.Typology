namespace DiGi.Typology.Constants
{
    /// <summary>
    /// Provides file filter constants for typology files.
    /// </summary>
    public static class FileFilter
    {
        /// <summary>
        /// Gets the file filter used for Typology files.
        /// </summary>
        public static Core.IO.Classes.FileFilter TypologyFile { get; } = Core.IO.Create.FileFilter(FileTypeName.TypologyFile, FileExtension.TypologyFile);
    }
}
