﻿#pragma checksum "..\..\..\..\..\Page\Pay\PayInfoAddToEdit.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D4CA76E1E5DEC010055F6F432F328E4B"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using FinancialRegulation;
using FinancialRegulation.Page;
using FinancialRegulation.Tools;
using MahApps.Metro.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace FinancialRegulation.Page {
    
    
    /// <summary>
    /// PayInfoAddToEdit
    /// </summary>
    public partial class PayInfoAddToEdit : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\..\Page\Pay\PayInfoAddToEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainLayout;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\Page\Pay\PayInfoAddToEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_SerialNumber;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\Page\Pay\PayInfoAddToEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox1;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\..\Page\Pay\PayInfoAddToEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox2;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\Page\Pay\PayInfoAddToEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Instruction;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FinancialRegulation;component/page/pay/payinfoaddtoedit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Page\Pay\PayInfoAddToEdit.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MainLayout = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            
            #line 41 "..\..\..\..\..\Page\Pay\PayInfoAddToEdit.xaml"
            ((System.Windows.Controls.TextBlock)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.TextBoxOnlyNUM_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txt_SerialNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\..\..\..\Page\Pay\PayInfoAddToEdit.xaml"
            this.txt_SerialNumber.KeyDown += new System.Windows.Input.KeyEventHandler(this.TextBoxOnlyNUM_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textBox1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.textBox2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 48 "..\..\..\..\..\Page\Pay\PayInfoAddToEdit.xaml"
            this.textBox2.KeyDown += new System.Windows.Input.KeyEventHandler(this.TextBoxSFZ_KeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txt_Instruction = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

