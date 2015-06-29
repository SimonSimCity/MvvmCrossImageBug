
using System;

using Foundation;
using UIKit;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using ImageTest.Core;

namespace ImageTest.iOS
{
    public partial class TableViewCell : MvxTableViewCell
    {
        public static readonly UINib Nib = UINib.FromName("TableViewCell", NSBundle.MainBundle);
        public static readonly NSString Key = new NSString("TableViewCell");

        private readonly MvxImageViewLoader typeImageViewLoader;

        public TableViewCell(IntPtr handle)
            : base(handle)
        {
            typeImageViewLoader = new MvxImageViewLoader(() => ImageView);

            this.DelayBind(() =>
                {

                    var set = this.CreateBindingSet<MvxTableViewCell, ListItem>();
                    set.Bind(TitleLabel).To(vm => vm.Title);
                    set.Bind(typeImageViewLoader).To(t => t.Type).WithConversion("TypeToImage");
                    set.Apply();
                });
        }

        public static TableViewCell Create()
        {
            return (TableViewCell)Nib.Instantiate(null, null)[0];
        }
    }
}
