using Modio.Core.Board;
using Modio.Core.Module;
using Modio.Xamarin.Board;
using Modio.Xamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Xamarin.Forms;

namespace Modio.Xamarin.Views
{
	public class BoardPage : ContentPage
	{

        Grid _contentRoot;
        ViewModelBoard _vm;

		public IList<UIModuleService> Modules
		{
			get { return (IList<UIModuleService>)GetValue(ModulesProperty); }
			set { SetValue(ModulesProperty, value); }
		}

		// Using a DependencyProperty as the backing store for Modules.  This enables animation, styling, binding, etc...
		public static readonly BindableProperty ModulesProperty =
            BindableProperty.Create("Modules", typeof(IList<UIModuleService>), typeof(BoardPage));

		public BoardPage ()
		{
            _contentRoot = new Grid
            {
                BackgroundColor = Color.BlanchedAlmond
            };
            Content = _contentRoot;
		}

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName.Equals(nameof(BindingContext)))
            {
                InitializeBindings();
            } else if(propertyName.Equals(nameof(Modules)))
            {
                InitializeModules(Modules);
            }
        }

        void InitializeBindings()
        {
            _vm = BindingContext as ViewModelBoard;

            BindingBase modulesBinding = new Binding("Modules");
            SetBinding(ModulesProperty, modulesBinding);

            Modules = _vm.Service.Modules;
        }

        void InitializeModules(IList<UIModuleService> modules)
        {
            int cIndex = 0;
            int rIndex = 0;
            const int MaxColumn = 2;
            foreach (var module in modules)
            {
                _contentRoot.Children.Add(new ModuleItemView
                {
                    BindingContext = module.MetaInfo,
                }, cIndex % MaxColumn, rIndex);
                cIndex += 1;
                rIndex = cIndex / MaxColumn;
            }
        }

    }
}