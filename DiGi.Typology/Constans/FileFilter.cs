namespace DiGi.Typology.Constans
{
    public static class FileFilter
    {
        public static Core.IO.Classes.FileFilter TypologyFile { get; } = Core.IO.Create.FileFilter(FileTypeName.TypologyFile, FileExtension.TypologyFile);
    }
}