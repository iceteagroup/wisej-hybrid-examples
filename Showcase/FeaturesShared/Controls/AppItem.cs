using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	public partial class AppItem : UserControl
	{

		#region Properties

		private TestBase _instance;
		private readonly Type _viewType;

		private readonly Random _rand = new((int)DateTime.Now.Ticks);

		public string Title;

		public string ImageSource;

		#endregion

		#region Constructors

		public AppItem()
		{
			InitializeComponent();
		}

		public AppItem(Type viewType)
		{
			InitializeComponent();

			if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
				return;

			this._viewType = viewType;

			var category = GetCategory(viewType);
			var title = String.Join(" ", Regex.Split(viewType.Name, @"(?<!^)(?=[A-Z])"));

			this.Title = title;

			if (!string.IsNullOrEmpty(category))
				this.ImageSource = $"resource.wx/{category}.svg?color={GetRandomColor()}";

			Application.ThemeChanged += Application_ThemeChanged;
			this.Disposed += (_, _) =>
			{
				Application.ThemeChanged -= Application_ThemeChanged;
				if (this._instance != null && !this._instance.IsDisposed)
					this._instance.Dispose();
			};

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
			if (this._viewType == null)
				return;
			this.labelDescription.Text = GetCategory(this._viewType);

			if (DemoCapabilities.IsPinned(this._viewType))
				BringToFront();
		}

		private string GetRandomColor()
		{
			var color = Color.FromArgb(_rand.Next(256), _rand.Next(256), _rand.Next(256));
			return ColorTranslator.ToHtml(color);
		}

		public string GetDescription(Type type)
		{
			var attribute = Attribute.GetCustomAttribute(type, typeof(DescriptionAttribute));
			return ((DescriptionAttribute)attribute)?.Description ?? "";
		}

		public string GetCategory(Type type)
		{
			var attribute = Attribute.GetCustomAttribute(type, typeof(CategoryAttribute));
			return ((CategoryAttribute)attribute)?.Category ?? "";
		}

		private void AppItemView_Click(object sender, EventArgs e)
		{
			try
			{
				if (this._viewType == null || !DemoCapabilities.IsSupported(this._viewType))
					return;

				if (this._instance == null || this._instance.IsDisposed)
					this._instance = (TestBase)Activator.CreateInstance(this._viewType);

				if (this._instance.IsSupported())
					this.OnViewRequested(new WidgetEventArgs("ViewRequested", this._instance));
			}
			catch (Exception ex)
			{
				AlertBox.Show($"Unable to open {this.Title}: {ex.GetBaseException().Message}");
			}
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
			this.Enabled = this._viewType != null && DemoCapabilities.IsSupported(this._viewType);
		}
	}
}
