using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using Wisej.Web;

namespace Wisej.Hybrid.Features
{
	[Category("Base")]
	public partial class TestBase : UserControl
	{
		public event WidgetEventHandler ViewRequested;

		public bool Pinned { get; set; }

		public string Hint
		{
			get
			{
				return this.hint.Text;
			}
			set
			{
				this.hint.Text = value;
			}
		}

		public void OnViewRequested(WidgetEventArgs e)
		{
			this.ViewRequested?.Invoke(this, e);
		}

		public TestBase()
		{
			InitializeComponent();
			this.BackColor = System.Drawing.Color.FromName("@window");
			this.Disposed += (_, _) => SetActive(false);
		}

		private bool _active;
		private bool _loaded;

		private void SetActive(bool active)
		{
			if (this._active == active)
				return;

			this._active = active;
			if (active)
				Activate();
			else
				Deactivate();
		}

		private void TestBase_Load(object sender, EventArgs e)
		{
			if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
				return;

			this._loaded = true;
			SetActive(this.Visible);

			this.labelTitle.Text = String.Join(" ", Regex.Split(this.GetType().Name, "(?<!^)(?=[A-Z])"));
			this.hint.Visible = !String.IsNullOrEmpty(this.Hint);
		}

		public void MinimizeTitle()
		{
			if (this.labelTitle.Height != 40)
			{
				this.labelTitle.Height = 40;
				this.labelTitle.Font = new System.Drawing.Font("@itemTitleLandscape", 24, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			}
		}

		public void MaximizeTitle()
		{
			if (this.labelTitle.Height != 68)
			{
				this.labelTitle.Height = 68;
				this.labelTitle.Font = new System.Drawing.Font("@itemTitle", 36, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			}
		}

		private void buttonSource_Click(object sender, EventArgs e)
		{
			var name = this.GetType().Name;
			Device.Browser.Open($"https://github.com/iceteagroup/wisej-hybrid-examples/tree/4.1/Showcase/FeaturesShared/Panels/{name}.cs", BrowserLaunchMode.SystemPreferred);
		}

		public virtual bool IsSupported()
		{
			return DemoCapabilities.IsSupported(GetType());
		}

		public virtual void Activate() { }

		public virtual void Deactivate() { }

		private void TestBase_VisibleChanged(object sender, EventArgs e)
		{
			if (this._loaded)
				SetActive(this.Visible);
		}
	}
}
