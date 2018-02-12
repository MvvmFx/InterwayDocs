using Codisa.InterwayDocs.Framework;
using MvvmFx.CaliburnMicro;

namespace Codisa.InterwayDocs
{
    public interface IMainFormViewModel : IScreen, IHaveViewNamedElements, IRefreshTranslation
    {
        /// <summary>
        /// Gets or sets a value indicating whether the search panel is expected to be open.
        /// </summary>
        /// <value>
        /// <c>true</c> if the search panel is supposed to be open; otherwise, <c>false</c>.
        /// </value>
        bool IsSearchPanelOpen { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the detail panel is expected to be open.
        /// </summary>
        /// <value>
        /// <c>true</c> if the detail panel is supposed to be open; otherwise, <c>false</c>.
        /// </value>
        bool IsDetailPanelOpen { get; set; }

        /// <summary>
        /// Gets a value indicating whether to use long names on entities.
        /// </summary>
        /// <value>
        ///   <c>true</c> if use long names on entities; otherwise, <c>false</c>.
        /// </value>
        bool UseLongNameEntities { get; }
    }
}