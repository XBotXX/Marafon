﻿#pragma checksum "..\..\RegOnMarathon.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FD664A3763954B11ABDB06424F855160F70CA0631EDA1A9BB78D68C23198BDF0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WSR2016_WPF;


namespace WSR2016_WPF {
    
    
    /// <summary>
    /// RegOnMarathon
    /// </summary>
    public partial class RegOnMarathon : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 67 "..\..\RegOnMarathon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton A;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\RegOnMarathon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton B;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\RegOnMarathon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton C;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\RegOnMarathon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Summa;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\RegOnMarathon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FM;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\RegOnMarathon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox HM;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\RegOnMarathon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FR;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\RegOnMarathon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CharityOrg;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\RegOnMarathon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonInfSponsor;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\RegOnMarathon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SummaAll;
        
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
            System.Uri resourceLocater = new System.Uri("/WSR2016_WPF;component/regonmarathon.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RegOnMarathon.xaml"
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
            
            #line 43 "..\..\RegOnMarathon.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Exit);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 45 "..\..\RegOnMarathon.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ExitOnMainWindow);
            
            #line default
            #line hidden
            return;
            case 3:
            this.A = ((System.Windows.Controls.RadioButton)(target));
            
            #line 67 "..\..\RegOnMarathon.xaml"
            this.A.Checked += new System.Windows.RoutedEventHandler(this.A_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.B = ((System.Windows.Controls.RadioButton)(target));
            
            #line 68 "..\..\RegOnMarathon.xaml"
            this.B.Checked += new System.Windows.RoutedEventHandler(this.B_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.C = ((System.Windows.Controls.RadioButton)(target));
            
            #line 69 "..\..\RegOnMarathon.xaml"
            this.C.Checked += new System.Windows.RoutedEventHandler(this.C_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Summa = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.FM = ((System.Windows.Controls.CheckBox)(target));
            
            #line 82 "..\..\RegOnMarathon.xaml"
            this.FM.Checked += new System.Windows.RoutedEventHandler(this.FM_Checked);
            
            #line default
            #line hidden
            
            #line 82 "..\..\RegOnMarathon.xaml"
            this.FM.Unchecked += new System.Windows.RoutedEventHandler(this.FM_Unchecked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.HM = ((System.Windows.Controls.CheckBox)(target));
            
            #line 83 "..\..\RegOnMarathon.xaml"
            this.HM.Checked += new System.Windows.RoutedEventHandler(this.HM_Checked);
            
            #line default
            #line hidden
            
            #line 83 "..\..\RegOnMarathon.xaml"
            this.HM.Unchecked += new System.Windows.RoutedEventHandler(this.HM_Unchecked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.FR = ((System.Windows.Controls.CheckBox)(target));
            
            #line 84 "..\..\RegOnMarathon.xaml"
            this.FR.Checked += new System.Windows.RoutedEventHandler(this.FR_Checked);
            
            #line default
            #line hidden
            
            #line 84 "..\..\RegOnMarathon.xaml"
            this.FR.Unchecked += new System.Windows.RoutedEventHandler(this.FR_Unchecked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.CharityOrg = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.ButtonInfSponsor = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\RegOnMarathon.xaml"
            this.ButtonInfSponsor.Click += new System.Windows.RoutedEventHandler(this.ButtonInfSponsor_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.SummaAll = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            
            #line 99 "..\..\RegOnMarathon.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RegistrationOnMarathon);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 100 "..\..\RegOnMarathon.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Exit);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

