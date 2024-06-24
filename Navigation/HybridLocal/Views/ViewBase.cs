using HybridLocal.Services;
using System;
using Wisej.Services;
using Wisej.Web;

namespace HybridLocal.Views
{
	public partial class ViewBase : Wisej.Web.UserControl
	{

		#region Constructor

		public ViewBase()
		{
			InitializeComponent();

			Application.Services.Inject(this);
		}

		#endregion

		#region Properties

		/// <summary>
		/// DI user service.
		/// </summary>
		[Inject]
		internal UserService UserService { get; set; }

		/// <summary>
		/// The title of the view.
		/// </summary>
		public string Title
		{
			get => this.labelTitle.Text;
			set => this.labelTitle.Text = value;
		}

		#endregion

		#region Events

		public event EventHandler<Type> PushView;

		public event EventHandler<Type> PopToView;

		public event EventHandler PopView;

		#endregion

		#region Methods

		public void OnPushView(Type viewType)
		{
			this.PushView?.Invoke(this, viewType);
		}

		public void OnPopView()
		{
			this.PopView?.Invoke(this, EventArgs.Empty);
		}

		public void OnPopToView(Type viewType)
		{
			this.PopToView?.Invoke(this, viewType);
		}

		#endregion

		public void PushAppear()
		{
			this.BringToFront();
			this.animationPushAppear.Run(this);
		}

		public void PushDisappear()
		{
			this.animationPushDisappear.Run(this);
		}

		public void PopAppear()
		{
			this.Show();
			this.SendToBack();
			this.animationPopAppear.Run(this);
		}

		public void PopDisappear()
		{
			this.animationPopDisappear.Run(this);
		}

		private void animationPushDisappear_End(object sender, Wisej.Web.AnimationEventArgs e)
		{
			this.Hide();
		}

		private void animationPopDisappear_End(object sender, Wisej.Web.AnimationEventArgs e)
		{
			this.Dispose();
		}

		private void animationPopAppear_End(object sender, Wisej.Web.AnimationEventArgs e)
		{
			this.BringToFront();
		}
	}
}
