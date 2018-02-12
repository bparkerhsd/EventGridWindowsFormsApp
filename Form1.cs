using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventGridWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EventTopicTextBox.Text = "https://xxxxxxxxxxxxxxxxxx.eastus-1.eventgrid.azure.net/api/events";
        }

        private async void sendEvent_Click(object sender, EventArgs e)
        {
            var responseMessage = await MakeRequestEvent();
            MessageBox.Show($"Event sent. Status Code: {responseMessage.StatusCode}");
        }

        private async Task<HttpResponseMessage> MakeRequestEvent()
        {
            string topicEndpoint = EventTopicTextBox.Text;

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("aeg-sas-key", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

            List<CustomEvent<SampleEventData>> events = new List<CustomEvent<SampleEventData>>();
            var customEvent = new CustomEvent<SampleEventData>();
            customEvent.EventType = "eventgridtest";
            customEvent.Subject = "Event Grid Test";
            customEvent.Data = new SampleEventData() { Name = "Parker" };
            events.Add(customEvent);
            var jsonContent = JsonConvert.SerializeObject(events);
            Console.WriteLine(jsonContent);

            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            return await httpClient.PostAsync(topicEndpoint, content);
        }

    }
    public class CustomEvent<T>
    {

        public string Id { get; private set; }

        public string EventType { get; set; }

        public string Subject { get; set; }

        public string EventTime { get; private set; }

        public T Data { get; set; }

        public CustomEvent()
        {
            Id = Guid.NewGuid().ToString();

            DateTime localTime = DateTime.Now;
            DateTime utcTime = DateTime.UtcNow;
            DateTimeOffset localTimeAndOffset = new DateTimeOffset(localTime, TimeZoneInfo.Local.GetUtcOffset(localTime));
            EventTime = localTimeAndOffset.ToString("o");
        }
    }

    public class SampleEventData
    {
        public string Name { get; set; }
    }
}
