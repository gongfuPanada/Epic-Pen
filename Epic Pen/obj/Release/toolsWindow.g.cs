﻿#pragma checksum "..\..\toolsWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9B3097759BFB3338F09AD5F5494476A3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace Epic_Pen {
    
    
    /// <summary>
    /// ToolsWindow
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class ToolsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 265 "..\..\toolsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox hideInkCheckBox;
        
        #line default
        #line hidden
        
        
        #line 271 "..\..\toolsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel toolsDockPanel;
        
        #line default
        #line hidden
        
        
        #line 272 "..\..\toolsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border selectedColourBorder;
        
        #line default
        #line hidden
        
        
        #line 292 "..\..\toolsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel brushSizeStackPanel;
        
        #line default
        #line hidden
        
        
        #line 306 "..\..\toolsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel toolStackPanel;
        
        #line default
        #line hidden
        
        
        #line 307 "..\..\toolsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cursorButton;
        
        #line default
        #line hidden
        
        
        #line 323 "..\..\toolsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button penButton;
        
        #line default
        #line hidden
        
        
        #line 337 "..\..\toolsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button highlighterButton;
        
        #line default
        #line hidden
        
        
        #line 348 "..\..\toolsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button eraserButton;
        
        #line default
        #line hidden
        
        
        #line 361 "..\..\toolsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button eraseAllButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/click through wpf;component/toolswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\toolsWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 4 "..\..\toolsWindow.xaml"
            ((Epic_Pen.ToolsWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 241 "..\..\toolsWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 245 "..\..\toolsWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.hideInkCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 265 "..\..\toolsWindow.xaml"
            this.hideInkCheckBox.Checked += new System.Windows.RoutedEventHandler(this.clickThroughCheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 265 "..\..\toolsWindow.xaml"
            this.hideInkCheckBox.Unchecked += new System.Windows.RoutedEventHandler(this.clickThroughCheckBox_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.toolsDockPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 6:
            this.selectedColourBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 7:
            
            #line 275 "..\..\toolsWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 276 "..\..\toolsWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 277 "..\..\toolsWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 278 "..\..\toolsWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 279 "..\..\toolsWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 280 "..\..\toolsWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 281 "..\..\toolsWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 282 "..\..\toolsWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 283 "..\..\toolsWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 284 "..\..\toolsWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 285 "..\..\toolsWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 286 "..\..\toolsWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 287 "..\..\toolsWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 288 "..\..\toolsWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 289 "..\..\toolsWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 22:
            this.brushSizeStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 23:
            
            #line 293 "..\..\toolsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.penSizeButton_MouseDown);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 296 "..\..\toolsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.penSizeButton_MouseDown);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 299 "..\..\toolsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.penSizeButton_MouseDown);
            
            #line default
            #line hidden
            return;
            case 26:
            
            #line 302 "..\..\toolsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.penSizeButton_MouseDown);
            
            #line default
            #line hidden
            return;
            case 27:
            this.toolStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 28:
            this.cursorButton = ((System.Windows.Controls.Button)(target));
            
            #line 307 "..\..\toolsWindow.xaml"
            this.cursorButton.Click += new System.Windows.RoutedEventHandler(this.cursorButton_Click);
            
            #line default
            #line hidden
            return;
            case 29:
            this.penButton = ((System.Windows.Controls.Button)(target));
            
            #line 323 "..\..\toolsWindow.xaml"
            this.penButton.Click += new System.Windows.RoutedEventHandler(this.penButton_Click);
            
            #line default
            #line hidden
            return;
            case 30:
            this.highlighterButton = ((System.Windows.Controls.Button)(target));
            
            #line 337 "..\..\toolsWindow.xaml"
            this.highlighterButton.Click += new System.Windows.RoutedEventHandler(this.highlighterButton_Click);
            
            #line default
            #line hidden
            return;
            case 31:
            this.eraserButton = ((System.Windows.Controls.Button)(target));
            
            #line 348 "..\..\toolsWindow.xaml"
            this.eraserButton.Click += new System.Windows.RoutedEventHandler(this.eraserButton_Click);
            
            #line default
            #line hidden
            return;
            case 32:
            this.eraseAllButton = ((System.Windows.Controls.Button)(target));
            
            #line 361 "..\..\toolsWindow.xaml"
            this.eraseAllButton.Click += new System.Windows.RoutedEventHandler(this.eraseAllButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

