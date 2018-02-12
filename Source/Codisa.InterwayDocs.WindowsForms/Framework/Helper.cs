#if WISEJ
using Wisej.Web;
#else
using System.Windows.Forms;
#endif
using Codisa.InterwayDocs.Configuration;

namespace Codisa.InterwayDocs.Framework
{
    internal static class Helper
    {
        #region Control

        internal static void SetElementConfiguration(Control control, PropertyConfigurationList configurationList)
        {
            var controlName = GetBaseControlName(control.Name).ToUpper();
            foreach (var configurationInfo in configurationList)
            {
                if (controlName == configurationInfo.Name.ToUpper())
                {
                    if (control is Label)
                        control.Text = configurationInfo.FriendlyName;
                    else
                        control.Enabled = !configurationInfo.IsReadOnly;

                    control.Visible = configurationInfo.IsVisible;
                    break;
                }
            }
        }

        private static string GetBaseControlName(string controlName)
        {
            const string labelSufix = "Label";
            const string modelPrefix = "model_";
            const string criteriaPrefix = "criteria_";

            if (controlName.EndsWith(labelSufix))
            {
                controlName = controlName.Substring(0, controlName.Length - labelSufix.Length);
            }
            else if (controlName.StartsWith(modelPrefix))
            {
                controlName = controlName.Substring(modelPrefix.Length);
            }
            else if (controlName.StartsWith(criteriaPrefix))
            {
                controlName = controlName.Substring(criteriaPrefix.Length);
            }

            return controlName;
        }

        #endregion

        #region DataGridViewTextBoxColumn

        internal static void SetElementConfiguration(DataGridViewTextBoxColumn element,
            PropertyConfigurationList configurationList)
        {
            var controlName = GetBaseDataGridViewTextBoxColumnName(element.Name).ToUpper();
            foreach (var configurationInfo in configurationList)
            {
                if (controlName == configurationInfo.Name.ToUpper())
                {
                    element.HeaderText = configurationInfo.FriendlyName;
                    element.Visible = configurationInfo.IsVisible;
                    break;
                }
            }
        }

        private static string GetBaseDataGridViewTextBoxColumnName(string elementName)
        {
            const string labelSufix = "DataGridViewTextBoxColumn";

            if (elementName.EndsWith(labelSufix))
            {
                elementName = elementName.Substring(0, elementName.Length - labelSufix.Length);
            }

            return elementName;
        }

        #endregion
    }
}