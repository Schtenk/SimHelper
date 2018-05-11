using System;
using System.Threading;
using System.Windows.Forms;

namespace SimHelper.Services
{
    class ClipboardService : IDisposable
    {
        public delegate void ClipboardService_NewTextFound(string Text);
        public event ClipboardService_NewTextFound NewTextFound;

        private Thread CheckThread;
        private bool stopRunning = false;
        private string LastTextFound = "";

        public void Start()
        {
            CheckThread = new Thread(new ThreadStart(CheckClipBoard));
            CheckThread.SetApartmentState(ApartmentState.STA);
            CheckThread.Start();
        }
        
        public bool SetClipboardText(string text)
        {
            try
            {
                Clipboard.SetText(text);
                return true;
            }
            catch(Exception e)
            {
                if (Properties.Settings.Default.showErrorMessages)
                    MessageBox.Show($"{e}-{e.Message}");
                return false;
            }
        }
    
        private void CheckClipBoard()
        {
            while(!stopRunning)
            {
                try
                {
                    string temp = Clipboard.GetText(TextDataFormat.Text);
                    if (!string.IsNullOrWhiteSpace(temp))
                    {
                        if (temp != LastTextFound)
                        {
                            if (NewTextFound != null) NewTextFound(temp);
                            LastTextFound = temp;
                        }
                    }
                }
                catch(Exception e)
                {
                    if(Properties.Settings.Default.showErrorMessages)
                        MessageBox.Show($"{e}-{e.Message}");
                }
                finally
                {
                    Thread.Sleep(1000);
                }
                
            }
        }



        public void Dispose()
        {
                stopRunning = true;
                CheckThread.Join(1000);
        }
    }
}
