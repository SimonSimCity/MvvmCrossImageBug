
using System;

using Foundation;
using UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using ImageTest.Core.ViewModels;

namespace ImageTest.iOS
{
    public partial class FirstViewController : MvxViewController
    {
        public FirstViewController()
            : base()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var source = new MvxSimpleTableViewSource(TableView, TableViewCell.Key);
            TableView.RowHeight = 55;
            TableView.Source = source;

            var set = this.CreateBindingSet<FirstViewController, FirstViewModel>();

            set.Bind(source).To(vm => vm.Data);
            set.Apply();

            TableView.ReloadData();

            set.Apply();
        }
    }
}
