using System.Collections.Generic;
using System.Windows.Forms;
using MvvmFx.CaliburnMicro;
using Screen = MvvmFx.CaliburnMicro.Screen;

namespace Codisa.InterwayDocs.Setup
{
    public class MainFormViewModel : Conductor<Screen>, IMainFormViewModel
    {
        #region Fields and properties

        /// <summary>
        /// Gets or sets the control objects of the view.
        /// </summary>
        /// <value>
        /// The control objects of the view.
        /// </value>
        public List<Control> ViewNamedElements { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the search panel is expected to be open.
        /// </summary>
        /// <value>
        /// <c>true</c> if the search panel is supposed to be open; otherwise, <c>false</c>.
        /// </value>
        public bool IsSearchPanelOpen { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the detail panel is expected to be open.
        /// </summary>
        /// <value>
        /// <c>true</c> if the detail panel is supposed to be open; otherwise, <c>false</c>.
        /// </value>
        public bool IsDetailPanelOpen { get; set; } = true;

        #endregion

        #region Initializers

        protected override void OnInitialize()
        {
            DisplayName = "InterwayDocs Setup";
            BindMenuItems();

            OpenDatabase();
        }

        private void BindMenuItems()
        {
            var mainForm = GetView() as IMainForm;
            if (mainForm != null)
                mainForm.BindMenuItems(ViewNamedElements);
        }

        #endregion

        #region Action methods

        public void OpenDatabase()
        {
            /*if (ActiveItem != null)
            {
                if (ActiveItem.GetType() != typeof (DatabaseViewModel))
                    ActiveItem.TryClose();
            }
            ActivateItem(new DatabaseViewModel());*/
            MarkActiveMenuItem("Database");
        }

        public void OpenObjectProperties()
        {
            /*if (ActiveItem != null)
            {
                if (ActiveItem.GetType() != typeof (ObjectPropertiesViewModel))
                    ActiveItem.TryClose();
            }
            ActivateItem(new ObjectPropertiesViewModel());*/
            MarkActiveMenuItem("ObjectProperties");
        }

        public void OpenOtherCustomizations()
        {
            /*if (ActiveItem != null)
            {
                if (ActiveItem.GetType() != typeof (OtherCustomizationsViewModel))
                    ActiveItem.TryClose();
            }
            ActivateItem(new OtherCustomizationsViewModel());*/
            MarkActiveMenuItem("OtherCustomizations");
        }

        private void MarkActiveMenuItem(string menuItem)
        {
            var mainForm = GetView() as IMainForm;
            if (mainForm != null)
                mainForm.MarkActiveMenuItem(menuItem);
        }

        #endregion

        #region Exit

        public void Exit()
        {
            TryClose();
        }

        #endregion
    }
}