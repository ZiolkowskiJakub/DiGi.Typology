namespace DiGi.Typology.Visual.Constants
{
    /// <summary>
    /// Provides the format strings the assembly renders values with.
    /// </summary>
    public static class Format
    {
        /// <summary>
        /// The format a <see cref="System.DateTime"/> is rendered with by <see cref="Query.Key(object)"/>: ISO 8601 to
        /// the tick, with no offset or kind designator, so two instants equal to the tick share a key whatever their
        /// kind.
        /// </summary>
        public const string DateTime = "yyyy-MM-ddTHH:mm:ss.fffffff";
    }
}