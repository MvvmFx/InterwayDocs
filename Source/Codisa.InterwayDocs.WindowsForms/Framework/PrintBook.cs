using System;
using System.ComponentModel;
using System.IO;
#if WISEJ
using Wisej.Web;
#else
using System.Windows.Forms;
#endif
using Codisa.InterwayDocs.Business;
using Codisa.InterwayDocs.Business.SearchObjects;
using Codisa.InterwayDocs.Configuration;
using Codisa.InterwayDocs.Rules;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using NPOI.XSSF.UserModel.Extensions;
using BorderStyle = NPOI.SS.UserModel.BorderStyle;
using HorizontalAlignment = NPOI.SS.UserModel.HorizontalAlignment;
using VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment;

namespace Codisa.InterwayDocs.Framework
{
    public class PrintBook
    {
        // Casts form I... to XSSF... cause this warning

        #region Parameters variables

        private IBindingList _model;
        private PropertyConfigurationList _configurationList;
        private IGenericCriteriaInformation _refreshCriteria;
        private DateTime _refreshDateTime;
        private int _headerLength;
        private string _filePrefix;
        private string _title;

        #endregion

        #region Excel processing variables

        private string _fileName;
        private XSSFWorkbook _workbook;
        private XSSFSheet _sheet;
        private XSSFCellStyle _generalStyle;
        private XSSFCellStyle _generalBoldStyle;
        private XSSFCellStyle _headerStyle;
        private XSSFCellStyle _generalGridStyle;
        private XSSFCellStyle _dateGridStyle;

        #endregion

        #region Initializers

        private PrintBook()
        {
            //force use of factory method DoPrintBook.
        }

        public static void DoPrintBook(IBookViewModel book, PropertyConfigurationList configurationList,
            IGenericCriteriaInformation refreshCriteria, DateTime refreshDateTime, int headerLength, string filePrefix,
            string title)
        {
            IBindingList model = book.Model as IBindingList;

            var instance = new PrintBook
            {
                _model = model,
                _configurationList = configurationList,
                _refreshCriteria = refreshCriteria,
                _refreshDateTime = refreshDateTime,
                _headerLength = headerLength,
                _filePrefix = filePrefix,
                _title = title
            };

            instance.DoPrintBook();
        }

        private void DoPrintBook()
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
                Filter = "ExcelWorkbook".GetUiTranslation(),
                DefaultExt = ".xlsx",
                FileName = string.Format("{0}-{1}",
                    _filePrefix,
                    _refreshDateTime.ToString("FilenameDateTimeFormat".GetUiTranslation()))
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
                _refreshDateTime.ToString("FilenameDateTimeFormat".GetUiTranslation()));
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
            string tmpFileName = Path.Combine(Application.StartupPath, "book.xlsx");

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

            // header
            _headerStyle = styleTable.CreateCellStyle();
            _headerStyle.SetFont(headerFont);
            _headerStyle.FillForegroundXSSFColor = myBlueColour;
            _headerStyle.FillPattern = FillPattern.SolidForeground;

            //general data
            _generalStyle = styleTable.CreateCellStyle();
            _generalStyle.SetFont(generalFont);

            //general bold data
            _generalBoldStyle = styleTable.CreateCellStyle();
            _generalBoldStyle.SetFont(boldFont);

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
                .GetFormat("DateTimeFormat".GetUiTranslation());
            _dateGridStyle.Alignment = HorizontalAlignment.Center;
            _dateGridStyle.SetVerticalAlignment((short) VerticalAlignment.Top);
        }

        private void PrintReport()
        {
            var firstRowNumber = 0;
            var firstDataRowNumber = firstRowNumber + _headerLength;

            var headerRow = _sheet.CreateRow(_headerLength) as XSSFRow;

            var column = 0;

            foreach (var item in _configurationList)
            {
                if (!item.IsVisible)
                    continue;

                var titleCell = headerRow.CreateCell(column) as XSSFCell;

                titleCell.SetCellType(CellType.String);
                titleCell.SetCellValue(item.FriendlyName);
                titleCell.CellStyle = _headerStyle;

                for (var index = 0; index < _model.Count; index++)
                {
                    XSSFRow dataRow;
                    if (column == 0)
                        dataRow = _sheet.CreateRow(_headerLength + index + 1) as XSSFRow;
                    else
                        dataRow = _sheet.GetRow(_headerLength + index + 1) as XSSFRow;

                    var dataCell = dataRow.CreateCell(column) as XSSFCell;
                    dataCell.SetCellType(CellType.String);

                    if (item.Name.IndexOf("Date", StringComparison.InvariantCulture) > -1)
                        dataCell.CellStyle = _dateGridStyle;
                    else
                        dataCell.CellStyle = _generalGridStyle;

                    var value = GetValue(index, item);
                    if (value != null)
                        dataCell.SetCellValue(value);
                }

                _sheet.AutoSizeColumn(column);
                if (_sheet.GetColumnWidth(column) < 3000)
                    _sheet.SetColumnWidth(column, 3000);
                if (_sheet.GetColumnWidth(column) > 13000)
                    _sheet.SetColumnWidth(column, 13000);
                if (_sheet.GetColumnWidth(column) < 13000 - 512)
                    _sheet.SetColumnWidth(column, _sheet.GetColumnWidth(column) + 512);

                column++;
            }

            BuildCriteriaHeader();

            var filterRange = new CellRangeAddress(firstDataRowNumber, _sheet.LastRowNum, headerRow.FirstCellNum,
                headerRow.LastCellNum - 1);
            _sheet.SetAutoFilter(filterRange);

            _sheet.CreateFreezePane(0, firstDataRowNumber + 1);

            _sheet.DisplayGridlines = false;
        }

        private dynamic GetValue(int index, PropertyConfigurationInfo info)
        {
            dynamic data = new object();

            if (_model is IncomingBook)
                data = _model[index] as IncomingInfo;
            else if (_model is OutgoingBook)
                data = _model[index] as OutgoingInfo;
            else if (_model is DeliveryBook)
                data = _model[index] as DeliveryInfo;

            if (data != null)
            {
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
            }

            return null;
        }

        #endregion

        #region Compose Header

        private void BuildCriteriaHeader()
        {
            BuilCriteriaHeaderLine1();
            BuilCriteriaHeaderLine2();
            BuilCriteriaHeaderLine3();
            BuilCriteriaHeaderLine4();
        }

        private void BuilCriteriaHeaderLine1()
        {
            var row = _sheet.CreateRow(0) as XSSFRow;

            var value = string.Format("BookReportTitle".GetUiTranslation(), _title, _refreshDateTime.ToString("G"));

            var titleLabel = row.CreateCell(0) as XSSFCell;
            titleLabel.SetCellType(CellType.String);
            titleLabel.SetCellValue("CommunReportTitle".GetUiTranslation());
            titleLabel.CellStyle = _generalStyle;

            var valueLabel = row.CreateCell(1) as XSSFCell;
            valueLabel.SetCellType(CellType.String);
            valueLabel.SetCellValue(value);
            valueLabel.CellStyle = _generalBoldStyle;
        }

        private void BuilCriteriaHeaderLine2()
        {
            var row = _sheet.CreateRow(2) as XSSFRow;

            var titleLabel = row.CreateCell(0) as XSSFCell;
            titleLabel.SetCellType(CellType.String);
            titleLabel.SetCellValue("LabelDates".GetUiTranslation() + ":");
            titleLabel.CellStyle = _generalStyle;

            var valueLabel = row.CreateCell(1) as XSSFCell;
            valueLabel.SetCellType(CellType.String);
            string value;

            if (_refreshCriteria.CriteriaStartDate == null && _refreshCriteria.CriteriaEndDate == null)
            {
                value = "Unspecified".GetUiTranslation();
                valueLabel.CellStyle = _generalStyle;
            }
            else if (_refreshCriteria.CriteriaStartDate != null && _refreshCriteria.CriteriaEndDate != null)
            {
                var startDate = _refreshCriteria.CriteriaStartDate.Date.ToString("DateTimeFormat".GetUiTranslation());
                var endDate = _refreshCriteria.CriteriaEndDate.Date.ToString("DateTimeFormat".GetUiTranslation());

                value = string.Format("BookReportDateRange".GetUiTranslation(),
                    _refreshCriteria.DateTypeList.GetDescription(_refreshCriteria.SelectedDateTypeName),
                    startDate,
                    endDate);

                valueLabel.CellStyle = _generalBoldStyle;
            }
            else if (_refreshCriteria.CriteriaStartDate == null && _refreshCriteria.CriteriaEndDate != null)
            {
                var endDate = _refreshCriteria.CriteriaEndDate.Date.ToString("DateTimeFormat".GetUiTranslation());

                value = string.Format("BookReportDateUpTo".GetUiTranslation(),
                    _refreshCriteria.DateTypeList.GetDescription(_refreshCriteria.SelectedDateTypeName),
                    endDate);

                valueLabel.CellStyle = _generalBoldStyle;
            }
            else //if (_refreshCriteria.CriteriaStartDate != null && _refreshCriteria.CriteriaEndDate == null)
            {
                var startDate = _refreshCriteria.CriteriaStartDate.Date.ToString("DateTimeFormat".GetUiTranslation());

                value = string.Format("BookReportDateSince".GetUiTranslation(),
                    _refreshCriteria.DateTypeList.GetDescription(_refreshCriteria.SelectedDateTypeName),
                    startDate);

                valueLabel.CellStyle = _generalBoldStyle;
            }

            valueLabel.SetCellValue(value);
        }

        private void BuilCriteriaHeaderLine3()
        {
            var row = _sheet.CreateRow(3) as XSSFRow;

            var titleLabel = row.CreateCell(0) as XSSFCell;
            titleLabel.SetCellType(CellType.String);
            titleLabel.SetCellValue("LabelFullText".GetUiTranslation() + ":");
            titleLabel.CellStyle = _generalStyle;

            var valueLabel = row.CreateCell(1) as XSSFCell;
            valueLabel.SetCellType(CellType.String);
            string value;
            if (string.IsNullOrEmpty(_refreshCriteria.FullText))
            {
                value = "Unspecified".GetUiTranslation();
                valueLabel.CellStyle = _generalStyle;
            }
            else
            {
                value = _refreshCriteria.FullText;
                valueLabel.CellStyle = _generalBoldStyle;
            }

            valueLabel.SetCellValue(value);
        }

        private void BuilCriteriaHeaderLine4()
        {
            var refreshCriteria = _refreshCriteria as IHaveArchiveLocation;
            if (refreshCriteria != null)
            {
                var row = _sheet.CreateRow(4) as XSSFRow;

                var titleLabel = row.CreateCell(0) as XSSFCell;
                titleLabel.SetCellType(CellType.String);
                titleLabel.SetCellValue("LabelArchiveLocation".GetUiTranslation() + ":");
                titleLabel.CellStyle = _generalStyle;

                var valueLabel = row.CreateCell(1) as XSSFCell;
                valueLabel.SetCellType(CellType.String);
                string value;
                if (string.IsNullOrEmpty(refreshCriteria.ArchiveLocation))
                {
                    value = "Unspecified".GetUiTranslation();
                    valueLabel.CellStyle = _generalStyle;
                }
                else
                {
                    value = refreshCriteria.ArchiveLocation;
                    valueLabel.CellStyle = _generalBoldStyle;
                }

                valueLabel.SetCellValue(value);
            }
        }

        #endregion
    }
}