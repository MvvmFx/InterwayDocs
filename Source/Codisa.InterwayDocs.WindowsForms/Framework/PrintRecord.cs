using System;
using System.IO;
#if WISEJ
using Wisej.Web;
#else
using System.Windows.Forms;
#endif
using Codisa.InterwayDocs.Business;
using Codisa.InterwayDocs.Configuration;
using Codisa.InterwayDocs.Properties;
using Csla;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.XSSF.UserModel.Extensions;
using BorderStyle = NPOI.SS.UserModel.BorderStyle;
using HorizontalAlignment = NPOI.SS.UserModel.HorizontalAlignment;
using VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment;

namespace Codisa.InterwayDocs.Framework
{
    public class PrintRecord
    {
        // Casts form I... to XSSF... cause this warning

        #region Parameters variables

        private IDetailViewModel _detail;
        private IBusinessBase _model;
        private DateTime _refreshDateTime;
        private int _headerLength;
        private string _filePrefix;
        private string _title;
        private int _registerId;

        #endregion

        #region Excel processing variables

        private string _fileName;
        private XSSFWorkbook _workbook;
        private XSSFSheet _sheet;
        private XSSFCellStyle _generalStyle;
        private XSSFCellStyle _generalBoldStyle;
        private XSSFCellStyle _generalGridStyle;
        private XSSFCellStyle _dateGridStyle;

        #endregion

        #region Initializers

        private PrintRecord()
        {
            //force use of factory method DoPrintRecord.
        }

        public static void DoPrintRecord(IDetailViewModel detail, DateTime refreshDateTime, int headerLength,
            string filePrefix, string title, int registerId)
        {
            IBusinessBase model = detail.Model as IBusinessBase;

            var instance = new PrintRecord
            {
                _detail = detail,
                _model = model,
                _refreshDateTime = refreshDateTime,
                _headerLength = headerLength,
                _filePrefix = filePrefix,
                _title = title,
                _registerId = registerId
            };

            instance.DoPrintRecord();
        }

        private void DoPrintRecord()
        {
            if (SelectFile())
            {
                PrepareWorkbook();
                PrepareSheet();
                SetupStyles();
                PrintReport();
                SaveWorkbook();
            }
        }

        #endregion

        #region Preparation

        private bool SelectFile()
        {
#if WINFORMS
            using (var diag = new SaveFileDialog
            {
                AutoUpgradeEnabled = true,
                CheckPathExists = true,
                OverwritePrompt = true,
                SupportMultiDottedExtensions = false,
                AddExtension = true,
                Filter = Resources.ExcelWorkbook,
                DefaultExt = ".xlsx",
                FileName = string.Format("{0} {1}-{2}",
                    _filePrefix,
                    _registerId,
                    _refreshDateTime.ToString(Resources.FilenameDateTimeFormat))
            })
            {
                var result = diag.ShowDialog();
                if (result == DialogResult.Cancel)
                    return false;

                _fileName = diag.FileName;
            }
#else
            _fileName = string.Format("{0}-{1}.xlsx",
                _filePrefix,
                _refreshDateTime.ToString(Resources.FilenameDateTimeFormat));
#endif
            return true;
        }

        private void PrepareWorkbook()
        {
            _workbook = new XSSFWorkbook();
        }

        private void PrepareSheet()
        {
            _sheet = _workbook.CreateSheet(_filePrefix) as XSSFSheet;
        }

        private void SaveWorkbook()
        {
#if WINFORMS
            using (var fileStream = new FileStream(_fileName, FileMode.Create, FileAccess.Write))
            {
                _workbook.Write(fileStream);
                fileStream.Close();
            }
#else
            string tmpFileName = Path.Combine(Application.StartupPath, "record.xlsx");

            using (var fileStream = new FileStream(tmpFileName, FileMode.Create, FileAccess.Write))
            {
                _workbook.Write(fileStream);
                fileStream.Close();
            }

            using (var fileStream = new FileStream(tmpFileName, FileMode.Open))
            {
                Application.Download(fileStream, _fileName);
                fileStream.Close();
            }

            File.Delete(tmpFileName);
#endif
        }

        #endregion

        #region Hard work

        private void SetupStyles()
        {
            var myBlueColour = new XSSFColor(new byte[] {31, 73, 125});

            var styleTable = _workbook.GetStylesSource();

            // fonts
            var headerFont = _workbook.CreateFont() as XSSFFont;
            headerFont.Boldweight = (short) FontBoldWeight.Bold;
            headerFont.Color = HSSFColor.White.Index;

            var generalFont = _workbook.CreateFont() as XSSFFont;
            generalFont.SetColor(myBlueColour);

            var boldFont = _workbook.CreateFont() as XSSFFont;
            boldFont.SetColor(myBlueColour);
            boldFont.Boldweight = (short) FontBoldWeight.Bold;

            //general data
            _generalStyle = styleTable.CreateCellStyle();
            _generalStyle.SetFont(generalFont);
            _generalStyle.SetVerticalAlignment((short) VerticalAlignment.Top);

            //general bold data
            _generalBoldStyle = styleTable.CreateCellStyle();
            _generalBoldStyle.SetFont(boldFont);
            _generalBoldStyle.SetVerticalAlignment((short) VerticalAlignment.Top);

            //general grid data
            _generalGridStyle = styleTable.CreateCellStyle();
            _generalGridStyle.SetFont(generalFont);
            _generalGridStyle.BorderLeft = BorderStyle.Thin;
            _generalGridStyle.SetBorderColor(BorderSide.LEFT, myBlueColour);
            _generalGridStyle.BorderTop = BorderStyle.Thin;
            _generalGridStyle.SetBorderColor(BorderSide.TOP, myBlueColour);
            _generalGridStyle.BorderRight = BorderStyle.Thin;
            _generalGridStyle.SetBorderColor(BorderSide.RIGHT, myBlueColour);
            _generalGridStyle.BorderBottom = BorderStyle.Thin;
            _generalGridStyle.SetBorderColor(BorderSide.BOTTOM, myBlueColour);
            _generalGridStyle.Alignment = HorizontalAlignment.Left;
            _generalGridStyle.SetVerticalAlignment((short) VerticalAlignment.Top);
            _generalGridStyle.WrapText = true;

            //Date grid data
            _dateGridStyle = styleTable.CreateCellStyle();
            _dateGridStyle.SetFont(generalFont);
            _dateGridStyle.BorderLeft = BorderStyle.Thin;
            _dateGridStyle.SetBorderColor(BorderSide.LEFT, myBlueColour);
            _dateGridStyle.BorderTop = BorderStyle.Thin;
            _dateGridStyle.SetBorderColor(BorderSide.TOP, myBlueColour);
            _dateGridStyle.BorderRight = BorderStyle.Thin;
            _dateGridStyle.SetBorderColor(BorderSide.RIGHT, myBlueColour);
            _dateGridStyle.BorderBottom = BorderStyle.Thin;
            _dateGridStyle.SetBorderColor(BorderSide.BOTTOM, myBlueColour);
            _dateGridStyle.DataFormat = _workbook.GetCreationHelper()
                .CreateDataFormat()
                .GetFormat(Resources.DateTimeFormat);
            _dateGridStyle.Alignment = HorizontalAlignment.Left;
            _dateGridStyle.SetVerticalAlignment((short) VerticalAlignment.Top);
        }

        private void PrintReport()
        {
            BuildCriteriaHeader();

            var rowNumber = 0;

            foreach (var item in (_detail as IHaveConfigurationList).ConfigurationList)
            {
                if (!item.IsVisible)
                    continue;

                var row = _sheet.CreateRow(_headerLength + rowNumber) as XSSFRow;

                var titleCell = row.CreateCell(0) as XSSFCell;

                titleCell.SetCellType(CellType.String);
                titleCell.SetCellValue(item.FriendlyName);
                titleCell.CellStyle = _generalBoldStyle;

                var dataCell = row.CreateCell(1) as XSSFCell;
                dataCell.SetCellType(CellType.String);

                if (item.Name.IndexOf("Date", StringComparison.InvariantCulture) > -1)
                    dataCell.CellStyle = _dateGridStyle;
                else
                    dataCell.CellStyle = _generalGridStyle;

                var value = GetValue(item);
                if (value != null)
                    dataCell.SetCellValue(value);

                rowNumber++;
                var thinRow = _sheet.CreateRow(_headerLength + rowNumber) as XSSFRow;
                thinRow.Height = 100;

                rowNumber++;
            }

            for (var column = 0; column < 2; column++)
            {
                _sheet.AutoSizeColumn(column);
                if (_sheet.GetColumnWidth(column) < 3000)
                    _sheet.SetColumnWidth(column, 3000);
                if (_sheet.GetColumnWidth(column) > 26000)
                    _sheet.SetColumnWidth(column, 26000);
                if (_sheet.GetColumnWidth(column) < 26000 - 512)
                    _sheet.SetColumnWidth(column, _sheet.GetColumnWidth(column) + 512);
            }

            _sheet.DisplayGridlines = false;
        }

        private dynamic GetValue(PropertyConfigurationInfo info)
        {
            dynamic data = new object();

            if (_model is IncomingRegister)
                data = _model as IncomingRegister;
            else if (_model is OutgoingRegister)
                data = _model as OutgoingRegister;
            else if (_model is DeliveryRegister)
                data = _model as DeliveryRegister;

            if (info.Name == "RegisterId")
                return data.RegisterId;
            if (info.Name == "RegisterDate")
                if (!string.IsNullOrEmpty(data.RegisterDate))
                    return DateTime.Parse(data.RegisterDate);
            if (info.Name == "DocumentType")
                return data.DocumentType;
            if (info.Name == "DocumentReference")
                return data.DocumentReference;
            if (info.Name == "DocumentEntity")
                return data.DocumentEntity;
            if (info.Name == "DocumentDept")
                return data.DocumentDept;
            if (info.Name == "DocumentClass")
                return data.DocumentClass;
            if (info.Name == "DocumentDate")
                if (!string.IsNullOrEmpty(data.DocumentDate))
                    return DateTime.Parse(data.DocumentDate);

            // Incoming & Outgoing
            if (info.Name == "Subject")
                return data.Subject;
            if (info.Name == "Notes")
                return data.Notes;
            if (info.Name == "ArchiveLocation")
                return data.ArchiveLocation;

            // Incoming
            if (info.Name == "SenderName")
                return data.SenderName;

            // Incoming & Delivery
            if (info.Name == "ReceptionDate")
                if (!string.IsNullOrEmpty(data.ReceptionDate))
                    return DateTime.Parse(data.ReceptionDate);
            if (info.Name == "RoutedTo")
                return data.RoutedTo;

            // Outgoing & Delivery
            if (info.Name == "RecipientName")
                return data.RecipientName;
            if (info.Name == "SendDate")
                if (!string.IsNullOrEmpty(data.SendDate))
                    return DateTime.Parse(data.SendDate);
            if (info.Name == "RecipientTown")
                return data.RecipientTown;

            // Delivery
            if (info.Name == "ExpeditorName")
                return data.ExpeditorName;
            if (info.Name == "ReceptionName")
                return data.ReceptionName;

            return null;
        }

        #endregion

        #region Compose Header

        private void BuildCriteriaHeader()
        {
            BuilCriteriaHeaderLine1();
            BuilCriteriaHeaderLine2();
        }

        private void BuilCriteriaHeaderLine1()
        {
            var row = _sheet.CreateRow(0) as XSSFRow;

            var friendlyName = "RegisterId";
            var configurationList = (_detail as IHaveConfigurationList).ConfigurationList;
            if (configurationList != null)
            {
                var property = configurationList.FindPropertyConfigurationInfoByName(friendlyName);
                if (property != null)
                    friendlyName = property.FriendlyName;
            }

            var value = string.Format(Resources.RegisterReportTitle,
                _title,
                friendlyName,
                _registerId,
                _refreshDateTime.ToString("G"));

            var titleLabel = row.CreateCell(0) as XSSFCell;
            titleLabel.SetCellType(CellType.String);
            titleLabel.SetCellValue(Resources.CommunReportTitle);
            titleLabel.CellStyle = _generalStyle;

            var valueLabel = row.CreateCell(1) as XSSFCell;
            valueLabel.SetCellType(CellType.String);
            valueLabel.SetCellValue(value);
            valueLabel.CellStyle = _generalBoldStyle;
        }

        private void BuilCriteriaHeaderLine2()
        {
            var row = _sheet.CreateRow(2) as XSSFRow;

            var value = AuditFormater.Format((_model as IHaveAudit).CreateDate, (_model as IHaveAudit).ChangeDate);

            var titleLabel = row.CreateCell(0) as XSSFCell;
            titleLabel.SetCellType(CellType.String);
            titleLabel.SetCellValue(Resources.ReportLabelAudit);
            titleLabel.CellStyle = _generalStyle;

            var valueLabel = row.CreateCell(1) as XSSFCell;
            valueLabel.SetCellType(CellType.String);
            valueLabel.SetCellValue(value);
            valueLabel.CellStyle = _generalBoldStyle;
        }

        #endregion
    }
}