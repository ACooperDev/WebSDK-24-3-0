//*******************************************************************************
// Copyright (C) 2021 Cognex Corporation
//
// Subject to Cognex Corporation's terms and conditions and license agreement,
// you are authorized to use and modify this sample source code in any way you find
// useful, provided the Software and/or the modified Software is used solely in
// conjunction with a Cognex Machine Vision System.  Furthermore you acknowledge
// and agree that Cognex has no warranty, obligations or liability for your use
// of the Software.
//
// NuGet packages may need to be added:
//  -Microsoft.Build by Microsoft 17.8.3
//  -WebSocketSharp.Standard by web-sharp-standard 1.0.3
//*******************************************************************************

using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Cognex.InSight.Web;
using Cognex.InSight.Web.Controls;
using Cognex.SimpleCogSocket;
using Cognex.InSight.Remoting.Serialization;
using System.Net;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using JsonSerializer = Cognex.SimpleCogSocket.JsonSerializer;

namespace WebAPISampleApp
{
  /// <summary>
  /// This a class that shows a simple example of a Web API application.
  /// 
  /// The application constructs a CvsInSight instance to access Web API functionality.
  /// 
  /// A PictureBox is used to render the current image.
  /// </summary>
  public partial class MainForm : Form
  {
    // Holds the connection to the camera and provides an abstraction for the API
    private CvsInSight _inSight;

    private int _startTicks;
       
    public MainForm()
    {
      InitializeComponent();

      _startTicks = Environment.TickCount;

      _inSight = new CvsInSight();
      _inSight.PreviewMessage += _inSight_PreviewMessage;
      _inSight.ResultsChanged += _inSight_ResultsChanged;
      _inSight.ConnectedChanged += _inSight_ConnectedChanged;
      _inSight.ConnectingChanged += _inSight_ConnectingChanged;
      _inSight.StateChanged += _inSight_StateChanged;
      _inSight.LiveModeChanged += _inSight_LiveModeChanged;
      _inSight.JobInfoChanged += _inSight_JobInfoChanged;
      _inSight.JobLoadingChanged += _inSight_JobLoadingChanged;
      _inSight.EditorAttachedChanged += _inSight_EditorAttachedChanged;
    

      cvsSpreadsheet.SetInSight(_inSight);
      cvsCustomView.SetInSight(_inSight);
      cvsDisplay.SetInSight(_inSight);
      cvsFilmstrip.SetInSight(_inSight);
    }

    /// <summary>
    /// Unsubscribe any events before shutting down.
    /// </summary>
    private void UnsubscribeEvents()
    {
      _inSight.PreviewMessage -= _inSight_PreviewMessage;
      _inSight.ResultsChanged -= _inSight_ResultsChanged;
      _inSight.ConnectedChanged -= _inSight_ConnectedChanged;
      _inSight.StateChanged -= _inSight_StateChanged;
      _inSight.LiveModeChanged -= _inSight_LiveModeChanged;
      _inSight.JobInfoChanged -= _inSight_JobInfoChanged;
      _inSight.JobLoadingChanged -= _inSight_JobLoadingChanged;
      _inSight.EditorAttachedChanged -= _inSight_EditorAttachedChanged;
    }

    private void _inSight_JobInfoChanged(object sender, EventArgs e)
    {
      InitForNewJob(); // Handle sheet re-format
      _inSight_ResultsChanged(sender, e); // Be sure we re-process the result after job load
      UpdateState();
    }

    private void _inSight_JobLoadingChanged(object sender, EventArgs e)
    {
      InitForNewJob();
    }

    private async void _inSight_EditorAttachedChanged(object sender, EventArgs e)
    {
      InitForNewJob();
      UpdateState();
      await cvsDisplay.UpdateResults();
      cvsFilmstrip.UpdateResults();
    }
        
    /// <summary>
    /// Optionally displays the messages that are sent and received on the CogSocket.
    /// </summary>
    private void _inSight_PreviewMessage(object sender, MessagePayloadPreviewEventArgs e)
    {
      string msg = (e.Payload?.ToString() ?? "");
      int len = msg.Length;

      if (msg.Length > 150)
      {
        msg = msg.Substring(0, 100) + "..." + msg.Substring(msg.Length - 50, 50);
      }

      if (_inSight.Connected)
      {
        Debug.WriteLine($"[{Name}] [Len:{len}] {msg}");
      }

      if (msg.Contains("manualTrigger"))
      {
        _startTicks = Environment.TickCount;
      }
/*
      if (msg.Contains("resultChanged"))
      {
        Debug.WriteLine(String.Format("resultChanged ticks: {0}", (Environment.TickCount - _startTicks).ToString()));
        MessageBox.Show(String.Format("resultChanged ticks: {0}", (Environment.TickCount - _startTicks).ToString()));
      }*/
    /*
      //#if SHOW_ALL_MESSAGES
      Debug.WriteLine("Ticks: " + (Environment.TickCount - _startTicks).ToString());
      var header = e.IsIncoming ? "Incoming" : "Outgoing";
      var json = JToken.Parse((string)e.Payload);
      long id = -1;
      string objType = (string)json["$type"];

      string lenStr = (string)(e.Payload);

      if (objType != "event")
        id = (long)json["id"];

      if (e.IsIncoming)
      {
        Debug.WriteLine($"Incoming({id} {lenStr.Length}):");
      }
      else
      {
        Debug.WriteLine($"Outgoing({id} {lenStr.Length}):");
      }

      string payload = e.Payload.ToString();
      string formattedJson = payload.Substring(0,Math.Min(100,payload.Length));
      Debug.WriteLine(formattedJson);*/
//#endif
    }

    /// <summary>
    /// Handles the ResultsChanged event by updating the displayed image and results.
    /// </summary>
    private async void _inSight_ResultsChanged(object sender, EventArgs e)
    {
      JToken results = _inSight.Results;

      cvsSpreadsheet.UpdateResults(results);
      cvsCustomView.UpdateResults(results);
      UpdateMessages();
      await cvsDisplay.UpdateResults();
      cvsFilmstrip.UpdateResults();
    }

    /// <summary>
    /// Handles the ConnectedChanged event by updating the controls that use the state.
    /// </summary>
    private void _inSight_ConnectedChanged(object sender, EventArgs e)
    {
      InitForNewJob(); // Re-format the sheet
      UpdateState();
    }

    /// <summary>
    /// Handles the ConnectingChanged event by updating the controls that use the state.
    /// </summary>
    private void _inSight_ConnectingChanged(object sender, EventArgs e)
    {
      UpdateState();
    }

    /// <summary>
    /// Handles the StateChanged event by updating the controls that use the state.
    /// </summary>
    private void _inSight_StateChanged(object sender, EventArgs e)
    {
      UpdateState();
    }

    /// <summary>
    /// Handles the LiveModeChanged event by updating the controls that use the state.
    /// </summary>
    private void _inSight_LiveModeChanged(object sender, EventArgs e)
    {
      UpdateState();
    }


    private void InitForNewJob()
    {
      cvsSpreadsheet.Invoke((Action)delegate
      {
        cvsSpreadsheet.InitSpreadsheet(); // Clear the spreadsheet
        cvsCustomView.InitSpreadsheet(); // Clear the custom View
        cvsDisplay.InitDisplay(); // Clear the graphics
      });
    }

    /// <summary>
    /// Updates the controls that use the state (i.e.  not connected/connected, offline/online, live mode)
    /// </summary>
    private void UpdateState()
    {
      try
      {
        lblState.Invoke((Action)delegate
        {
          btnConnectDisconnect.Enabled = !_inSight.Connecting;
          btnConnectDisconnect.Text = _inSight.Connected ? "Disconnect" : "Connect";
          if (_inSight.Connected)
          {
            string stateText = _inSight.Online ? "Online" : "Offline";
            if (_inSight.EditorAttached)
              stateText = "Editor Attached, " + stateText;

            lblState.Text = stateText;
            onlineMenuItem.Text = _inSight.Online ? "Go Offline" : "Go Online";
            liveModeMenuItem.Checked = _inSight.LiveMode;
          }
          else
          {
            lblState.Text = _inSight.Connecting ? "Connecting..." : "Not Connected";
            onlineMenuItem.Text = "Go Online";
            liveModeMenuItem.Checked = false;
          }

          aboutMenuItem.Enabled = _inSight.Connected;

          bool connectedButNotBusy = _inSight.Connected && !_inSight.EditorAttached && !_inSight.JobLoading;
          bool isOffline = connectedButNotBusy && !_inSight.Online;
          triggerMenuItem.Enabled = connectedButNotBusy;
          onlineMenuItem.Enabled = connectedButNotBusy;
          liveModeMenuItem.Enabled = isOffline;
          loadImageMenuItem.Enabled = isOffline;
          loadHmiCellsMenuItem.Enabled = isOffline;
          saveImageMenuItem.Enabled = connectedButNotBusy;
          loadJobMenuItem.Enabled = isOffline;
          hmiCustomViewMenuItem.Enabled = isOffline;
          hmiSettingsMenuItem.Enabled = isOffline;
          openHMIMenuItem.Enabled = connectedButNotBusy;

          cvsFilmstrip.Enabled = _inSight.Connected && !_inSight.JobLoading;
          saveQueuedImagesToolStripMenuItem.Enabled = _inSight.Connected;

          this.splitContainer1.Panel2Collapsed = !showSpreadsheetToolStripMenuItem.Checked;

          cvsCustomView.Visible = _inSight.Connected && !_inSight.JobLoading && (_inSight.CustomViewSettings.Length > 0) && (_inSight.CustomViewSettings?[0] != null) && showCustomViewToolStripMenuItem.Checked;
          if (cvsCustomView.Visible)
          {
            CenterCustomView();
          }
        });
      }
      catch (Exception)
      {
        // Ignore
      }
    }

    private void CenterCustomView()
    {
      if ((_inSight != null) && (_inSight.CustomViewSettings != null))
      {
        HmiCustomViewSettings cvSettings = _inSight.CustomViewSettings?[0];
        if (cvSettings != null)
        {
          // Always display it centered for now,
          cvsCustomView.SetBounds((cvsDisplay.Width - cvSettings.Width) / 2, (cvsDisplay.Height - cvSettings.Height) / 2, cvSettings.Width, cvSettings.Height);
        }
      }
    }
    
    protected override void OnSizeChanged(EventArgs e)
    {
      if (cvsCustomView.Visible)
      {
        CenterCustomView();
      }
      base.OnSizeChanged(e);
    }

    protected override void OnClientSizeChanged(EventArgs e)
    {
      if (cvsCustomView.Visible)
      {
        CenterCustomView();
      }
      base.OnClientSizeChanged(e);
    }


    #region Formatting/Output

    // Holds the content for the tbMessages when it will be updated.
    private string _loggedMessages = "";

    /// <summary>
    /// Add a message for the tbMessages.
    /// </summary>
    /// <param name="msg">The message to log</param>
    private void LogMessage(string msg)
    {
      _loggedMessages = msg;
    }

    /// <summary>
    /// Invokes to update the display messages.
    /// </summary>
    private void UpdateMessages()
    {
      tbMessages.Invoke((Action)delegate
      {
        tbMessages.Text = _loggedMessages;
      });
    }

    /// <summary>
    /// Formats the JSON so that it is readable.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    private static string JsonPrettify(string json)
    {
      using (var stringReader = new StringReader(json))
      using (var stringWriter = new StringWriter())
      {
        var jsonReader = new JsonTextReader(stringReader);
        var jsonWriter = new JsonTextWriter(stringWriter) { Formatting = Formatting.Indented };
        jsonWriter.WriteToken(jsonReader);
        return stringWriter.ToString();
      }
    }

    #endregion Formatting/Output

    /// <summary>
    /// Cleans up before the form is closed.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void MainForm_Closing(object sender, FormClosingEventArgs e)
    {
      try
      {
        UnsubscribeEvents();
        await _inSight.Disconnect();
      }
      catch (Exception)
      {
        MessageBox.Show("Error on disconnect");
      }
    }

    /// <summary>
    /// Handles the click event to connect and disconnect from a camera.
    /// </summary>
    private async void btnConnectDisconnect_Click(object sender, EventArgs e)
    {
      try
      {
        if (_inSight.Connected)
        {
          await _inSight.Disconnect();
          _loggedMessages = "";
          UpdateMessages();
        }
        else
        {
          // To limit the cell results that are returned, use the following...
          HmiSessionInfo sessionInfo = new HmiSessionInfo();
          sessionInfo.SheetName = "Inspection";
          sessionInfo.CellNames = new string[1] { "A0:Z599" }; // Designating a cell range requires 6.3 or newer firmware
          sessionInfo.EnableQueuedResults = true; // When the queue is frozen, then show the queued results
          sessionInfo.IncludeCustomView = true;
          await _inSight.Connect(tbIpAddressWithPort.Text, tbUsername.Text, tbPassword.Text, sessionInfo);

          await cvsDisplay.OnConnected();
          cvsFilmstrip.OnConnected();
        }

        UpdateState();
      }
      catch (Exception ex)
      {
        Debug.WriteLine("Connect error: " + ex.Message);
        MessageBox.Show("Unable to connect: " + ex.Message);
      }
    }
    
    /// <summary>
    /// Makes sure that the controls are in the correct state when the application begins.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MainForm_Load(object sender, EventArgs e)
    {
      InitForNewJob(); // Initialize the sheet
      UpdateState();
    }
                       
    /// <summary>
    /// Handles the click event to display information about the camera.
    /// </summary>
    private void aboutMenuItem_Click(object sender, EventArgs e)
    {
      CvsCameraInfo info = _inSight.CameraInfo;
      if (info != null)
      {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Name: " + info.HostName);
        sb.AppendLine("IP Address: " + info.IPAddress);
        sb.AppendLine("Model: " + info.ModelNumber);
        sb.AppendLine("MAC: " + info.MacAddress);
        sb.AppendLine("Serial: " + info.SerialNumber);
        sb.AppendLine("Firmware: " + info.FirmwareVersion);
        sb.AppendLine("HMI API: " + info.ApiVersion);
        MessageBox.Show(sb.ToString(), "Camera Info");
      }
    }

    private async void hmiSettingsMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        if (_inSight.Connected)
        {
          JToken hmiSettingsToken = _inSight.Settings.SelectToken("hmi");
          string hmiSettingsAsString = hmiSettingsToken.ToString();
          hmiSettingsAsString = Prompt.ShowDialog("Enter HMI Settings:", hmiSettingsAsString, "HMI Settings");
          
          if (hmiSettingsAsString.Length > 0)
          {
            HmiSettings hmiSettings = CvsInSight.JsonSerializer.DeserializeObject(hmiSettingsAsString) as HmiSettings;

            await _inSight.SetHmiSettingsAsync(hmiSettings);
          }
        }
      }
      catch (Exception ex)
      {
        Debug.WriteLine($"HmiSettings Exception: {ex.Message}");
      }
    }

    /// <summary>
    /// Handles the click event to go online/offline.
    /// </summary>
    private async void onlineMenuItem_Click(object sender, EventArgs e)
    {
      if (_inSight.Connected)
      {
        try
        {
          await _inSight.SetSoftOnlineAsync(!_inSight.SoftOnline);
        }
        catch (Exception)
        {
          MessageBox.Show("Error setting soft online. Verify that ISE is not connected.");
        }
      }
    }

    private async void liveModeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (_inSight.Connected)
      {
        try
        {
          bool nextLiveMode = !_inSight.LiveMode;
          await _inSight.SetLiveModeAsync(nextLiveMode);
          this.showSpreadsheetToolStripMenuItem.Checked = !nextLiveMode;
        }
        catch (Exception)
        {
          MessageBox.Show("Error setting live mode. Verify that ISE is not connected.");
        }
      }
    }

    private void openHMIMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        if (_inSight.Connected)
        {
          System.Diagnostics.Process.Start(_inSight.RemoteIPAddressUrl);
        }
      }
      catch (Exception ex)
      {
        Debug.WriteLine($"OpenHmi Exception: {ex.Message}");
      }
    }

    private async void hmiCustomViewMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        if (_inSight.Connected)
        {
          HmiCustomViewSettings[] settings = _inSight.CustomViewSettings;
          if (settings == null || settings.Length == 0)
          {
            settings = new HmiCustomViewSettings[] { new HmiCustomViewSettings() };
          }
          CvsCustomViewSettingsDialog dlg = new CvsCustomViewSettingsDialog(settings);
          DialogResult res = dlg.ShowDialog();
          if (res == DialogResult.OK)
          {
            await _inSight.SetCustomViewSettingsAsync(dlg.Settings);
          }
        }
      }
      catch (Exception ex)
      {
        Debug.WriteLine($"CustomViewSettings Exception: {ex.Message}");
      }
    }

    /// <summary>
    /// Handles the click event to perform a manual acquisition.
    /// </summary>
    private async void triggerMenuItem_Click(object sender, EventArgs e)
    {
      if (_inSight.Connected)
      {
        try
        {
          Debug.WriteLine("Manual Acquire Ticks: " + (Environment.TickCount - _startTicks).ToString());
          await _inSight.ManualAcquire();
        }
        catch (Exception)
        {
          MessageBox.Show("Error sending manual trigger");
        }
      }
    }

    private async void loadJobMenuItem_Click(object sender, EventArgs e)
    {
      if (_inSight.Connected)
      {
        var filePath = string.Empty;

        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
          openFileDialog.InitialDirectory = "c:\\";
          openFileDialog.Filter = "Job files (*.jobx, *.job)|*.jobx;*.job";
          openFileDialog.FilterIndex = 1;
          openFileDialog.RestoreDirectory = true;

          if (openFileDialog.ShowDialog() == DialogResult.OK)
          {
            //Get the path of specified file
            filePath = openFileDialog.FileName;

            try
            {
              await _inSight.LoadJobData(filePath).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
              Debug.WriteLine($"LoadJob Exception: {ex.Message}");
            }
          }
        }
      }
    }

    private async void saveJobMenuItem_Click(object sender, EventArgs e)
    {
        if (_inSight.Connected)
        {
            var filePath = string.Empty;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "Job files (*.jobx, *.job)|*.jobx;*.job";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = saveFileDialog.FileName;

                    try
                    {
                        // get the job name
                        var jobNameResp = await _inSight.GetJobName();
                        var resp = (JObject)await _inSight.SaveJobData(jobNameResp).ConfigureAwait(false);
                        if (resp == null)
                        {
                            string title = "Save Job";
                            string message = "Error saving job";
                            MessageBox.Show(title, message);
                            return;
                        }
                        
                        var byteStr = resp["base64"].Value<string>();
                        var byteArr = Convert.FromBase64String(byteStr);

                        File.WriteAllBytes(filePath, byteArr);

                    }
                    catch (Exception ex)
                    {
                        string title = "Save Job";
                        string message = $"Error saving job: {ex.Message}";
                        MessageBox.Show(title, message);
                    }
                }
            }
        }
    }

    private void loadImageMenuItem_Click(object sender, EventArgs e)
    {
      if (_inSight.Connected)
      {
        var filePath = string.Empty;

        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
          openFileDialog.InitialDirectory = "c:\\";
          openFileDialog.Filter = "BMP files (*.bmp)|*.bmp";
          openFileDialog.FilterIndex = 1;
          openFileDialog.RestoreDirectory = true;

          if (openFileDialog.ShowDialog() == DialogResult.OK)
          {
            //Get the path of specified file
            filePath = openFileDialog.FileName;

            try
            {
              _inSight.LoadImage(filePath);
            }
            catch (Exception ex)
            {
              Debug.WriteLine($"LoadImage Exception: {ex.Message}");
            }
          }
        }
      }
    }

    private void saveImageMenuItem_Click(object sender, EventArgs e)
    {
      if (_inSight.Connected)
      {
        string imageUrl = _inSight.GetMainImageUrl();
        if (imageUrl.Length > 0)
        {
          var filePath = string.Empty;

          using (SaveFileDialog saveFileDialog = new SaveFileDialog())
          {
            saveFileDialog.InitialDirectory = "c:\\";
            saveFileDialog.Filter = "BMP files (*.bmp)|*.bmp";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
              // Get the path of specified file
              filePath = saveFileDialog.FileName;

              try
              {
                using (WebClient webClient = new WebClient())
                {
                  byte[] data = webClient.DownloadData(imageUrl);

                  using (MemoryStream mem = new MemoryStream(data))
                  {
                    using (var myImage = Image.FromStream(mem))
                    {
                      myImage.Save(filePath, ImageFormat.Bmp);
                    }
                  }
                }
              }
              catch (Exception ex)
              {
                Debug.WriteLine($"LoadImage Exception: {ex.Message}");
              }
            }
          }
        }
      }
    }

    private void showCustomViewToolStripMenuItem_Click(object sender, EventArgs e)
    {
      UpdateState();
    }

    private void loadHmiCellsMenuItem_Click(object sender, EventArgs e)
    {
      if (_inSight.Connected)
      {
        var filePath = string.Empty;

        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
          openFileDialog.InitialDirectory = ".";
          openFileDialog.Filter = "JSON files (*.json)|*.json";
          openFileDialog.FilterIndex = 1;
          openFileDialog.RestoreDirectory = true;

          if (openFileDialog.ShowDialog() == DialogResult.OK)
          {
            // Get the path of specified file
            filePath = openFileDialog.FileName;

            try
            {
              string strHmiCells = File.ReadAllText(filePath);
              HmiSpreadsheetCells hmiCells = CvsInSight.JsonSerializer.DeserializeObject(strHmiCells) as HmiSpreadsheetCells;
              if (hmiCells != null)
              {
                hmiCells.FilePath = filePath;
              }
              cvsCustomView.SetHmiSpreadsheetCells(hmiCells);
              cvsSpreadsheet.SetHmiSpreadsheetCells(hmiCells);
            }
            catch (Exception ex)
            {
              Debug.WriteLine($"LoadImage Exception: {ex.Message}");
            }
          }
        }
      }
    }

    private void showSpreadsheetToolStripMenuItem_Click(object sender, EventArgs e)
    {
      UpdateState();
    }

    private async void getQueuedImageURLsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (_inSight.Connected)
      {
        JToken results = _inSight.Results;
        if (results != null)
        {
          try
          {
            var timer = new Stopwatch();
            timer.Start();
            await _inSight.FreezeQueue(true);
            timer.Stop();
            Console.WriteLine($"{timer.ElapsedMilliseconds} ms");

            JToken token = results.SelectToken("rq.slots");
            if (token == null)
              return;

            StringBuilder sb = new StringBuilder();

            int numSlots = (int)token.ToObject(typeof(int));
            if (numSlots > 0)
            {
              for (int n = 0; n < numSlots; n++)
              {
                string url = await _inSight.RequestQueuedImageUrl(n);
                url = _inSight.RemoteIPAddressUrl + url; // Complete the URL
                sb.AppendLine(url);
              }

              MessageBox.Show(sb.ToString(), "Result Queue URLs");
            }
            else
            {
              MessageBox.Show("None", "Result Queue URLs");
            }
          }
          finally
          {
            await _inSight.SendReady(); // Be sure that the next result will be accepted into the session
            await _inSight.FreezeQueue(false);
          }
        }
        
      }
    }

   
    }
}
