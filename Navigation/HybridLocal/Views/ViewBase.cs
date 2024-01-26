using System;

namespace HybridLocal.Views
{
	public partial class ViewBase : Wisej.Web.UserControl
	{

		#region Constructor

		public ViewBase()
		{
			InitializeComponent();
		}

		#endregion

		#region Properties

		public string Title
		{
			get => this.labelTitle.Text;
			set => this.labelTitle.Text = value;
		}

		#endregion

		#region Events

		public event EventHandler<Type> ViewRequested;

		#endregion

		#region Methods

		public void RequestView(Type viewType)
		{
			this.ViewRequested?.Invoke(this, viewType);
		}

		#endregion

	}
}
