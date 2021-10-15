using DevExpress.Xpf.Core;
using System;
using System.Data;
using System.IO;
using System.Windows;
using System.Xml;
using System.Xml.Linq;

namespace HeatmapDataSource {

    public partial class MainWindow : ThemedWindow {
        public MainWindow() {
            InitializeComponent();
            DataContext = DataLoader.CreateDataSet("/Data/BalanceOfTrade.xml");
        }
    }
    public static class DataLoader {
        static Stream GetStream(string fileName) {
            Uri uri = new Uri(fileName, UriKind.RelativeOrAbsolute);
            return Application.GetResourceStream(uri).Stream;
        }
        public static XDocument LoadXDocumentFromResources(string fileName) {
            try {
                return XDocument.Load(GetStream(fileName));
            } catch {
                return null;
            }
        }
        public static XmlDocument LoadXmlDocumentFromResources(string fileName) {
            XmlDocument document = new XmlDocument();
            try {
                document.Load(GetStream(fileName));
                return document;
            } catch {
                return null;
            }
        }
        public static DataTable CreateDataSet(string fileName) {
            if (!string.IsNullOrWhiteSpace(fileName)) {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(GetStream(fileName));
                if (dataSet.Tables.Count > 0)
                    return dataSet.Tables[0];
            }
            return null;
        }
    }
}
