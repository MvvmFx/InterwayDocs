using MvvmFx.CaliburnMicro;

namespace Codisa.InterwayDocs.Setup
{
    public interface IMainFormViewModel : IScreen, IHaveViewNamedElements
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
    }
}