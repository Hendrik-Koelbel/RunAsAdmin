using System.Collections.Generic;
using System.Windows.Forms;

namespace RunAs
{
    public partial class frmLoggerView : Form
    {
        public string Path { get; set; }
        private LogFileMonitor Monitor { get; set; }
        //https://gist.github.com/ant-fx/989dd86a1ace38a9ac58
        public frmLoggerView(string path)
        {
            InitializeComponent();

            //var headerCokumns = new List<string>() { "Time", "Level", "Details" };
            //headerCokumns.ForEach(name => listViewLog.Columns.Add(name));

            Path = path;

            Monitor = new LogFileMonitor(Path, "\r\n");

            Monitor.OnLine += (s, ex) =>
            {
                // WARNING.. this will be a different thread...

                listViewLog.Items.Add(ex.Line);
            };
            Monitor.Start();
        }

        private void frmLoggerView_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Monitor.Stop();
        }
    }
}
