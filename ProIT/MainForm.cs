using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace ProIT
{
    public partial class MainForm : Form
    {        
        public Thread t;
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        uploadApplicationForm uAF = new uploadApplicationForm();
        createApplicationForm cAF = new createApplicationForm();
        UserControl uc = new UserControl();
        public MainForm()
        {
            InitializeComponent();
        }

        private SemaphoreSlim semaphore = new SemaphoreSlim(1);

        private async void btnNutzerverwaltung_Click(object sender, EventArgs e)
        {
            await semaphore.WaitAsync();
            try
            {
                log.Debug("Before the show dialog method");
                await Task.Run(() =>
                {
                    try
                    {
                        log.Debug("Before the invoke method");
                        this.Invoke(new Action(() =>
                        {
                            log.Debug("Before the show method");
                            uc.ShowDialog();
                            log.Debug("After the show method");
                        }));
                        log.Debug("After the invoke method");
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception
                    }
                });
                log.Debug("After the show dialog method");
            }
            finally
            {
                semaphore.Release();
            }
        }

        private async void btnInfoControl_Click(object sender, EventArgs e)
        {
            log.Debug("Before the show dialog method");
            await Task.Run(() =>
            {
                try
                {
                    log.Debug("Before the invoke method");
                    this.Invoke(new Action(() =>
                    {
                        log.Debug("Before the show method");
                        uAF.ShowDialog();
                        log.Debug("After the show method");
                    }));
                    log.Debug("After the invoke method");
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            });
            log.Debug("After the show dialog method");
        }

        private async void btnForms_Click(object sender, EventArgs e)
        {
            log.Debug("Before the show dialog method");
            await Task.Run(async () =>
            {
                try
                {
                    log.Debug("Before the invoke method");
                    await Task.WhenAll(
                        Task.Run(() =>
                        {
                            log.Debug("Before the show method for uAF");
                            uAF.ShowDialog();
                            log.Debug("After the show method for uAF");
                        }),
                        Task.Run(() =>
                        {
                            log.Debug("Before the show method for cAF");
                            cAF.ShowDialog();
                            log.Debug("After the show method for cAF");
                        })
                    );
                    log.Debug("After the Task.WhenAll method");
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            });
            log.Debug("After the show dialog method");
        }
        
        
        private async void save(object sender, EventArgs e)
        {
            try
            {
                // Save user data to database
                log.Debug("User data saved to database");

                // Display success message
                MessageBox.Show("Benutzerdaten wurden erfolgreich gespeichert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Log the exception
                log.Error("Error saving user data to database", ex);

                // Display error message
                MessageBox.Show("Beim Speichern der Benutzerdaten ist ein Fehler aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            try {
                t.Start();
            } catch (Exception load)
            {
                var exception = new Exception($"Error: {load}");
                log.Debug(exception);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try {
                //t.Abort(); // Abort the thread when the form is closing
            } catch (Exception close)
            {
                var exception = new Exception($"Error: {close}");
                log.Debug(exception);
            }
        }
    }
}