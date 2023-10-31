using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Wisej.Hybrid.Shared.Sensor;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	public partial class AppItemView : UserControl
	{

		#region Properties

		private TestBase Instance;

		private Random random = new Random((int)DateTime.Now.Ticks);

		public string Title;

		public string ImageSource;

		#endregion

		#region Constructors

		public AppItemView()
		{
			InitializeComponent();
		}

		public AppItemView(TestBase instance)
		{
			InitializeComponent();

			if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
				return;

			this.Instance = instance;

			var category = GetCategory(instance.GetType());
			var title = String.Join(" ", Regex.Split(this.Instance.GetType().Name, @"(?<!^)(?=[A-Z])"));

			this.Title = title;

			if (!string.IsNullOrEmpty(category))
				this.ImageSource = $"resource.wx/{category}.svg?color={GetRandomColor()}";

			Application.ThemeChanged += Application_ThemeChanged;

			SetNativeColors();
		}

		private void Application_ThemeChanged(object sender, EventArgs e)
		{
			SetNativeColors();
		}

		#endregion

		#region Events

		public event WidgetEventHandler ViewRequested;

		private void OnViewRequested(WidgetEventArgs e)
		{
			this.ViewRequested?.Invoke(this, e);
		}

		#endregion

		private void AppItem_Load(object sender, EventArgs e)
		{
			this.labelTitle.Text = this.Title;
			this.pictureBoxIcon.ImageSource = this.ImageSource;
			this.labelDescription.Text = GetCategory(this.Instance.GetType());
		}

		private string GetRandomColor()
		{
			var color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
			return ColorTranslator.ToHtml(color);
		}

		public string GetDescription(Type type)
		{
			var attribute = Attribute.GetCustomAttribute(type, typeof(DescriptionAttribute));
			return ((DescriptionAttribute)attribute).Description ?? "";
		}

		public string GetCategory(Type type)
		{
			var attribute = Attribute.GetCustomAttribute(type, typeof(CategoryAttribute));
			return ((CategoryAttribute)attribute)?.Category ?? "";
		}

		private void AppItemView_Click(object sender, EventArgs e)
		{
			this.OnViewRequested(new WidgetEventArgs("ViewRequested", this.Instance));
		}

		private void SetNativeColors()
		{
			if (Application.Theme.Name == "Bootstrap-4")
			{
				this.BackColor = Color.White;
				this.CssStyle = "border-radius: 8px;\r\nbox-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;";
			}
			else
			{
				this.BackColor = ColorTranslator.FromHtml("#30343B");
				this.CssStyle = "border-radius: 8px;\r\nbox-shadow: rgba(0,0,0,0.31) 5px 5px 10px 0px;";
			}
		}

		private void AppItemView_Appear(object sender, EventArgs e)
		{
			if (this._supported == null)
			{
				this._supported = this.Instance != null && this.Instance.IsSupported();
				this.Enabled = (bool)this._supported;
			}
		}
		private bool? _supported = null;
	}
}
