using HybridLocal.Services;
using System;
using Wisej.Services;
using Wisej.Web;

namespace HybridLocal.Views
{
	public partial class ViewBase : UserControl
	{
		#region Constructor

		public ViewBase()
		{
			InitializeComponent();
			Application.Services.Inject(this);
		}

		#endregion

		#region Properties

		[Inject]
		internal UserService UserService { get; set; }

		public string Title
		{
			get => labelTitle.Text;
			set => labelTitle.Text = value;
		}

		public bool Busy { get; private set; }

		#endregion

		#region Events

		public event EventHandler<Type> PushView;
		public event EventHandler<Type> PopToView;
		public event EventHandler PopView;

		#endregion

		#region Methods

		public void TryPushView(Type viewType) => PushView?.Invoke(this, viewType);

		public void TryPopView() => PopView?.Invoke(this, EventArgs.Empty);

		public void TryPopToView(Type viewType) => PopToView?.Invoke(this, viewType);

		#endregion

		#region View Transitions

		public void PushAppear()
		{
			this.Busy = true;

			BringToFront();
			animationPushAppear.Run(this);
		}

		public void PushDisappear()
		{
			this.Busy = true;

			animationPushDisappear.Run(this);
			this.CssStyle = "filter: brightness(95%);transition: filter 0.3s ease;";
		}

		public void PopAppear()
		{
			this.Busy = true;

			Show();

			this.CssStyle = "";
			animationPopAppear.Run(this);
		}

		public void PopDisappear()
		{
			this.Busy = true;

			this.SendToBack();
			animationPopDisappear.Run(this);
			this.CssStyle = "filter: brightness(95%);transition: filter 0.3s ease;";
		}

		#endregion

		#region Animation Event Handlers

		private void animationPushDisappear_End(object sender, AnimationEventArgs e)
		{
			Hide();

			this.Busy = false;
		}

		private void animationPopDisappear_End(object sender, AnimationEventArgs e)
		{
			Dispose();
		}

		private void animationAppear_End(object sender, AnimationEventArgs e)
		{
			BringToFront();

			this.Busy = false;
		}

		#endregion

	}
}
