﻿#pragma checksum "..\..\..\..\LabElements\Multimeter.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BEE404E47FB1F403EB34BA6AC339FE6B"
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
using TUI_v0._3;


namespace TUI_v0._3 {
    
    
    /// <summary>
    /// Multimeter
    /// </summary>
    public partial class Multimeter : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\LabElements\Multimeter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid element_grid;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\LabElements\Multimeter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ScaleTransform scale;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\LabElements\Multimeter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle _r;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\LabElements\Multimeter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle _l;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\LabElements\Multimeter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock result;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\LabElements\Multimeter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle _l_point;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\LabElements\Multimeter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle _r_point;
        
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
            System.Uri resourceLocater = new System.Uri("/TUI_v0.3;component/labelements/multimeter.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\LabElements\Multimeter.xaml"
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
            this.element_grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.scale = ((System.Windows.Media.ScaleTransform)(target));
            return;
            case 3:
            
            #line 18 "..\..\..\..\LabElements\Multimeter.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.RadioButton_Click_2);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 19 "..\..\..\..\LabElements\Multimeter.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.RadioButton_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 22 "..\..\..\..\LabElements\Multimeter.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.RadioButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this._r = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 7:
            this._l = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 8:
            this.result = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this._l_point = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 10:
            this._r_point = ((System.Windows.Shapes.Rectangle)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
