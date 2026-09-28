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

		public override void Activate()
		{
			Device.LocalNotification.Presented += Notification_Changed;
			Device.LocalNotification.Responded += Notification_Changed;
		}

		public override void Deactivate()
		{
			Device.LocalNotification.Presented -= Notification_Changed;
			Device.LocalNotification.Responded -= Notification_Changed;
		}

		private void Notification_Changed(object sender, dynamic e)
		{
			AlertBox.Show(JSON.Stringify(e));
		}
	}
}
