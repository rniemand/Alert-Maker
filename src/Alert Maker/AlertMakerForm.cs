using System.Windows.Forms;
using System.Diagnostics;
using System;
using System.Collections.ObjectModel;

namespace Alert_Maker
{
  public partial class AlertMakerForm : Form
  {
    private readonly Collection<EventLog> _eventLogs;
    private readonly Collection<EventLogEntryType> _severities;

    public AlertMakerForm()
    {
      _eventLogs = new Collection<EventLog>();
      _severities = new Collection<EventLogEntryType>();

      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      RefreshEventLogs();
      RefreshSeverity();
      ClearUserMessage();
    }

    private void ClearUserMessage()
    {
      label_Output.Text = "";
    }

    private void DisplayUserMessage(string msg)
    {
      label_Output.Text = msg;
    }

    private void RefreshEventLogs()
    {
      var logs = EventLog.GetEventLogs();

      // Remove the current data source
      if (comboBox_eventLog.DataSource != null)
      {
        comboBox_eventLog.DataSource = null;
      }

      // Ensure that we have access to some event logs
      if (logs.Length <= 0)
      {
        return;
      }

      // Loop through the event logs and add them to our "_eventLogs" collection
      _eventLogs.Clear();

      foreach (var log in logs)
      {
        _eventLogs.Add(log);
      }

      // Set our select dropdowns data source and select a default eventlog
      comboBox_eventLog.DataSource = _eventLogs;
      comboBox_eventLog.DisplayMember = "Log";
      comboBox_eventLog.SelectedIndex = 0;
    }

    private void RefreshSeverity()
    {
      if (comboBox_severity.DataSource != null)
      {
        comboBox_severity.DataSource = null;
      }

      _severities.Clear();

      _severities.Add(EventLogEntryType.Information);
      _severities.Add(EventLogEntryType.Warning);
      _severities.Add(EventLogEntryType.Error);
      _severities.Add(EventLogEntryType.SuccessAudit);
      _severities.Add(EventLogEntryType.FailureAudit);

      comboBox_severity.DataSource = _severities;
    }

    public void CreateAlertClick(object sender, EventArgs e)
    {
      DisplayUserMessage("Attempting to write event");

      // Work all info that is needed
      var targetLogName = _eventLogs[comboBox_eventLog.SelectedIndex];
      var eventSeverity = _severities[comboBox_severity.SelectedIndex];
      var eventMessage = richTextBox_alertText.Text;
      var eventSource = textBox_eventSource.Text;

      // Determine an eventId to use for logging
      int.TryParse(textBox_alertID.Text, out var eventId);
      if (eventId == 0)
      {
        eventId = 100;
      }

      // Attempt to log the event
      try
      {
        // Ensure that our event source exists
        if (!EventLog.SourceExists(eventSource))
        {
          EventLog.CreateEventSource(eventSource, targetLogName.Log);
        }

        EventLog.WriteEntry(eventSource, eventMessage, eventSeverity, eventId);
        DisplayUserMessage("Event Created");
      }
      catch (Exception ex)
      {
        var errorMessage = $"There was an error creating your event! {Environment.NewLine}" +
                           $"{Environment.NewLine}" +
                           $"Error Type: {ex.GetType().Name}{Environment.NewLine}" +
                           $"Error: {ex.Message}";

        MessageBox.Show(errorMessage);
        DisplayUserMessage("Unable to create event");
      }
    }

    public void CloseClick(object sender, EventArgs e)
    {
      Close();
    }
  }
}
