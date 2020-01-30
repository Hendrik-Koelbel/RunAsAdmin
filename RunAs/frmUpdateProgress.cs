using Onova;
using Serilog;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunAs
{
    public partial class frmUpdateProgress : Form
    {

        UpdateManager updateManager;
        CancellationTokenSource cts = new CancellationTokenSource();

        public frmUpdateProgress(UpdateManager manager)
        {
            InitializeComponent();

            Log.Logger = new LoggerConfiguration()
                .WriteTo.Async(a => a.RollingFile(Path.GetTempPath() + @"\RunAs\log-{Date}.log",
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level}] {Message}{NewLine}{Exception}", shared: true, retainedFileCountLimit: 7))
                .CreateLogger();

            updateManager = manager;
            this.labelPercentage.Text = "0%/100%";
        }

        private async void frmUpdateProgress_Shown(object sender, EventArgs e)
        {
            try
            {
                Log.Information("Update progress started");
                using (updateManager)
                {
                    Log.Information("Update initialized");
                    var updatesResult = await updateManager.CheckForUpdatesAsync();
                    Log.Information("The latest version is: " + updatesResult.LastVersion);
                    Log.Information("Program can be updated: " + updatesResult.CanUpdate);
                    Progress<double> progressIndicator = new Progress<double>(ReportProgress);

                    // Prepare an update by downloading and extracting the package
                    // (supports progress reporting and cancellation)
                    Log.Information("Update will now be downloaded and extracted");
                    await updateManager.PrepareUpdateAsync(updatesResult.LastVersion, progressIndicator, cts.Token);

                    // Launch an executable that will apply the update
                    // (can be instructed to restart the application afterwards)
                    Log.Information("Update will now be downloaded and extracted");
                    updateManager.LaunchUpdater(updatesResult.LastVersion);

                    // Terminate the running application so that the updater can overwrite files
                    Log.Information("Close application for restart");
                    Environment.Exit(0);
                }
            }
            catch (TaskCanceledException tex)
            {
                Log.Error(tex, tex.Message);
                MessageBox.Show(tex.Message, tex.GetType().Name, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
            }
        }

        public void ReportProgress(double value)
        {
            //Update the UI to reflect the progress value that is passed back.
            this.progressBarUpdate.Increment(Convert.ToInt32(value * 100));
            this.labelPercentage.Text = String.Format("{0}%/100%" ,Convert.ToInt32(value * 100));
            Log.Information("Update progress: {0}%/100%", Convert.ToInt32(value * 100));
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Log.Information("Update canceled");
            cts.Cancel();
        }
    }
}
