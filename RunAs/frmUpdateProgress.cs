using Onova;
using System;
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
            updateManager = manager;
            this.labelPercentage.Text = "0%/100%";
        }

        private async void frmUpdateProgress_Shown(object sender, EventArgs e)
        {
            try
            {
                using (updateManager)
                {
                    var updatesResult = await updateManager.CheckForUpdatesAsync();

                    Progress<double> progressIndicator = new Progress<double>(ReportProgress);

                    // Prepare an update by downloading and extracting the package
                    // (supports progress reporting and cancellation)
                    await updateManager.PrepareUpdateAsync(updatesResult.LastVersion, progressIndicator, cts.Token);

                    // Launch an executable that will apply the update
                    // (can be instructed to restart the application afterwards)
                    updateManager.LaunchUpdater(updatesResult.LastVersion);

                    // Terminate the running application so that the updater can overwrite files
                    Environment.Exit(0);
                }
            }
            catch (TaskCanceledException tex)
            {
                MessageBox.Show(tex.Message, tex.GetType().Name, MessageBoxButtons.OK);
            }
            catch (Exception)
            {
            }
        }

        public void ReportProgress(double value)
        {
            //Update the UI to reflect the progress value that is passed back.
            this.progressBarUpdate.Increment(Convert.ToInt32(value * 100));
            this.labelPercentage.Text = String.Format("{0}%/100%" ,Convert.ToInt32(value * 100));
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }
    }
}
