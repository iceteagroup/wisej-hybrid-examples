using System;
using System.ComponentModel;
using Wisej.Hybrid;
using Wisej.Hybrid.Features;
using Wisej.Web;

namespace FeaturesShared.Panels
{
	[Category("UI")]
	public partial class LocalNotification : TestBase
	{
		public LocalNotification()
		{
			InitializeComponent();
		}

		private void Schedule(DateTime scheduleDate)
		{
			var title = this.textBoxTitle.Text;
			var description = this.textBoxDescription.Text;
			var badge = this.numericUpDownBadge.Value;

			Device.LocalNotification.Schedule(title, description, scheduleDate, (int)badge);
		}

		private void button5s_Click(object sender, EventArgs e)
		{
			Schedule(DateTime.Now.AddSeconds(5));
		}

		private void buttonTomorrow_Click(object sender, EventArgs e)
		{
			Schedule(DateTime.Now.AddDays(1));
		}

		private void LocalNotification_Load(object sender, EventArgs e)
		{
			Device.LocalNotification.Received += (s, e) =>
			{
				AlertBox.Show(JSON.Stringify(e));
			};
		}
	}
}
