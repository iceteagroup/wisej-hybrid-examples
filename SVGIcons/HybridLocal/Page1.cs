using System.Drawing;
using Wisej.Hybrid;
using Wisej.Hybrid.Shared.TabBar;
using Wisej.Hybrid.Shared.Toolbar;
using Wisej.Web;

namespace HybridLocal
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void Page1_Load(object sender, System.EventArgs e)
		{
			// TabBar configuration.
			Device.TabBar.Visible = true;
			Device.TabBar.BackColor = Color.FromName("@toolbar");
			Device.TabBar.SelectedColor = Color.FromName("@primary");
			Device.TabBar.UnselectedColor = Color.FromName("@control");
			
			Device.TabBar.TabSelected += TabBar_TabSelected;

			Device.TabBar.Items =
			[
				new TabBarItem
				{
					Title = "Home",
					ImageSource = Wisej.Ext.MaterialDesign.Icons.HomeButton
				},
				new TabBarItem
				{
					Title = "Messages",
					ImageSource = Wisej.Ext.MaterialDesign.Icons.EmailInbox
				},
				new TabBarItem
				{
					Title = "Search",
					ImageSource = Wisej.Ext.MaterialDesign.Icons.SearchingMagnifyingGlass
				},
				new TabBarItem
				{
					Title = "Settings",
					ImageSource = Wisej.Ext.MaterialDesign.Icons.PhoneSettings
				}
			];

			// Toolbar configuration.
			Device.Toolbar.Visible = true;
			Device.Toolbar.BackColor = Color.FromName("@toolbar");
			Device.Toolbar.ForeColor = Color.FromName("@primary");

			Device.Toolbar.ItemClicked += Toolbar_ItemClicked;

			Device.Toolbar.Items =
			[
				new ToolbarItem
				{
					Text = "Back",
					ImageSource = Wisej.Ext.MaterialDesign.Icons.BackArrow
				},
				new ToolbarItem
				{
					Text = "Forward",
					ImageSource = Wisej.Ext.MaterialDesign.Icons.ForwardArrow
				},
				new ToolbarItem
				{
					Type = ToolbarItemType.FlexibleSpace
				},
				new ToolbarItem
				{
					Text = "Close",
					ImageSource = Wisej.Ext.MaterialDesign.Icons.CloseButton
				},
			];
		}

		private void Toolbar_ItemClicked(object sender, ToolbarItemClickedEventArgs e)
		{
			AlertBox.Show(e.ToolbarItem.Text);
		}

		private void TabBar_TabSelected(object sender, TabSelectedEventArgs e)
		{
			AlertBox.Show(e.SelectedTabBarItem.Title);
		}
	}
}
 