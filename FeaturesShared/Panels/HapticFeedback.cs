using System;
using System.ComponentModel;
using Wisej.Hybrid;
using Wisej.Hybrid.Features;
using Wisej.Hybrid.Shared.HapticFeedback;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Hardware")]
	public partial class HapticFeedback : TestBase
	{
		public HapticFeedback()
		{
			InitializeComponent();
		}

		private void buttonExecute_Click(object sender, EventArgs e)
		{
			var selection = this.comboBoxHapticType.SelectedItem.ToString();

			var type = (HapticFeedbackType)Enum.Parse(typeof(HapticFeedbackType), selection);
			Device.HapticFeedback.Perform(type);
		}
	}
}
