﻿#pragma checksum "..\..\..\AdminWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "647E4B14DE20307381D5AAC08E33811CEE031161"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BibliotekaFull;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace BibliotekaFull {
    
    
    /// <summary>
    /// AdminWindow
    /// </summary>
    public partial class AdminWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ItemProd;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditProdButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DelButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageProd;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameProd;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CostProd;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescripProd;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowOrderButton;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BibliotekaFull;component/adminwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AdminWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ItemProd = ((System.Windows.Controls.ListView)(target));
            
            #line 11 "..\..\..\AdminWindow.xaml"
            this.ItemProd.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\AdminWindow.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.EditProdButton = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\AdminWindow.xaml"
            this.EditProdButton.Click += new System.Windows.RoutedEventHandler(this.EditProdButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DelButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\AdminWindow.xaml"
            this.DelButton.Click += new System.Windows.RoutedEventHandler(this.DelButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ImageProd = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.EditButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\AdminWindow.xaml"
            this.EditButton.Click += new System.Windows.RoutedEventHandler(this.EditButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.NameProd = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.CostProd = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.DescripProd = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.ShowOrderButton = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\AdminWindow.xaml"
            this.ShowOrderButton.Click += new System.Windows.RoutedEventHandler(this.ShowOrderButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\AdminWindow.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

