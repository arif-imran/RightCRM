using Foundation;
using System;
using UIKit;
using MvvmCross.Binding.iOS.Views;
using System.Diagnostics;

namespace RightCRM.iOS
{
    public partial class BusinessViewCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("BusinessViewCell");

        private const string BindingText = "Name CompanyName; Type BusinessType; Revenue AnnualRevenue; Size CompanySize";

        public BusinessViewCell (IntPtr handle)  : base (BindingText, handle)
        {
            Debug.WriteLine("BusinessViewCell ctor");

        }

        public string Name {get { return CompanyName.Text;}set { CompanyName.Text = value; }}
        public string Type {get { return CompanySize.Text;}set { CompanySize.Text = value; }}
        public string Revenue { get { return RevenueLabel.Text; } set { RevenueLabel.Text = value; } }
        public string Size { get { return SizeLabel.Text; } set { SizeLabel.Text = value; } }


    }
}