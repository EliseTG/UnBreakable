﻿#pragma checksum "..\..\FechaHora.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ED01824522B650F470F2C7D11A84A9E6AE2B581"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using WpfControlLibrary1;


namespace WpfControlLibrary1 {
    
    
    /// <summary>
    /// UserControl1
    /// </summary>
    public partial class UserControl1 : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\FechaHora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtfecha;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\FechaHora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txthora;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\FechaHora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnmashora;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\FechaHora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnmenoshora;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\FechaHora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtminutos;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\FechaHora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnmasminutos;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\FechaHora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnmenosminutos;
        
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
            System.Uri resourceLocater = new System.Uri("/Vista;component/fechahora.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FechaHora.xaml"
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
            this.dtfecha = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 2:
            this.txthora = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnmashora = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\FechaHora.xaml"
            this.btnmashora.Click += new System.Windows.RoutedEventHandler(this.btnmashora_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnmenoshora = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\FechaHora.xaml"
            this.btnmenoshora.Click += new System.Windows.RoutedEventHandler(this.btnmenoshora_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtminutos = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnmasminutos = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\FechaHora.xaml"
            this.btnmasminutos.Click += new System.Windows.RoutedEventHandler(this.btnmasminutos_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnmenosminutos = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\FechaHora.xaml"
            this.btnmenosminutos.Click += new System.Windows.RoutedEventHandler(this.btnmenosminutos_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
