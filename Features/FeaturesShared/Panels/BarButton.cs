using System.ComponentModel;
using System.Drawing;
using Wisej.Hybrid.Shared.TabBar;
using Wisej.Hybrid.Shared.Toolbar;
using Wisej.Web;

namespace Wisej.Hybrid.Features.Panels
{
	public partial class BarButton : UserControl
	{
		public BarButton()
		{
			InitializeComponent();
		}

		public Image Icon
		{
			get { return this.pictureBox1.Image; }
			set { this.pictureBox1.Image = value; }
		}

		[TypeConverter("Wisej.Design.ImageSourceConverter, Wisej.Framework.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=17bef35e11b84171")]
		public string IconSource
		{
			get { return this.pictureBox1.ImageSource; }
			set { this.pictureBox1.ImageSource = value; }
		}

		public string Label
		{
			get { return this.textBox1.Text; }
			set { this.textBox1.Text = value; }
		}

		public new bool Show
		{
			get { return this.checkBox1.Checked; }
			set { this.checkBox1.Checked = value; }
		}

		internal TabBarItem ToTabBarItem()
		{
			return new TabBarItem() 
			{
				Title = this.Label,
				ImageSource = this.pictureBox1.ImageSource,
			};
		}

		internal ToolbarItem ToToolbarItem()
		{
			return new ToolbarItem()
			{
				Text = this.Label,
				ImageSource = this.pictureBox1.ImageSource
			};
		}
	}
}
