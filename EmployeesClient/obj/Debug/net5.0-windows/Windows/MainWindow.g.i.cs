#pragma checksum "..\..\..\..\Windows\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "220776B2C279ADC382CAF47169DEF2C1A198DE48"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using EmployeesClient.Windows;
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


namespace EmployeesClient.Windows {
    
    
    /// <summary>
    /// EmployeesWindow
    /// </summary>
    public partial class EmployeesWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 37 "..\..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView SubdivisionsListView;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid EmployeesDataGrid;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddSubdivision;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEditSubdivision;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDeleteSubdivision;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddEmployee;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEditEmployee;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDeleteEmployee;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EmployeesClient;V1.0.0.0;component/windows/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            this.SubdivisionsListView = ((System.Windows.Controls.ListView)(target));
            
            #line 41 "..\..\..\..\Windows\MainWindow.xaml"
            this.SubdivisionsListView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SubdivisionsListView_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 42 "..\..\..\..\Windows\MainWindow.xaml"
            this.SubdivisionsListView.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.SubdivisionsListView_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.EmployeesDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 50 "..\..\..\..\Windows\MainWindow.xaml"
            this.EmployeesDataGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.EmployeesListView_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnAddSubdivision = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\..\Windows\MainWindow.xaml"
            this.BtnAddSubdivision.Click += new System.Windows.RoutedEventHandler(this.BtnAddSubdivision_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnEditSubdivision = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\..\Windows\MainWindow.xaml"
            this.BtnEditSubdivision.Click += new System.Windows.RoutedEventHandler(this.BtnEditSubdivision_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnDeleteSubdivision = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\..\Windows\MainWindow.xaml"
            this.BtnDeleteSubdivision.Click += new System.Windows.RoutedEventHandler(this.BtnDeleteSubdivision_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnAddEmployee = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\..\Windows\MainWindow.xaml"
            this.BtnAddEmployee.Click += new System.Windows.RoutedEventHandler(this.BtnAddEmployee_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnEditEmployee = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\..\..\Windows\MainWindow.xaml"
            this.BtnEditEmployee.Click += new System.Windows.RoutedEventHandler(this.BtnEditEmployee_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnDeleteEmployee = ((System.Windows.Controls.Button)(target));
            
            #line 108 "..\..\..\..\Windows\MainWindow.xaml"
            this.BtnDeleteEmployee.Click += new System.Windows.RoutedEventHandler(this.BtnDeleteEmployee_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 19 "..\..\..\..\Windows\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnOpenChildren_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

