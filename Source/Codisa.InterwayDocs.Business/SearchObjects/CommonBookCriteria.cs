namespace Codisa.InterwayDocs.Business.SearchObjects
{
    public class CommonBookCriteria
    {
        #region Business Properties

        /// <summary>
        /// Gets or sets the fast date index.
        /// </summary>
        /// <value>The fast date index.</value>
        public int SelectedFastDateIndex { get; set; }

        /// <summary>
        /// Gets or sets the date type index.
        /// </summary>
        /// <value>The date type index.</value>
        public int SelectedDateTypeIndex { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>The start date.</value>
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>The end date.</value>
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or sets the Archive Location.
        /// </summary>
        /// <value>The Archive Location.</value>
        public string ArchiveLocation { get; set; }

        /// <summary>
        /// Gets or sets the Full Text.
        /// </summary>
        /// <value>The Full Text.</value>
        public string FullText { get; set; }

        #endregion
    }
}