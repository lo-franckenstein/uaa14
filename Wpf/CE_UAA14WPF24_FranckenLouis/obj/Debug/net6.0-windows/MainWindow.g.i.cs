// Updated by XamlIntelliSenseFileGenerator 23/02/2024 16:03:13
#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9AB42E55B2D15AC00B69C5BCB6E03DEF34277591"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using CE_UAA14WPF24_FranckenLouis;
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


namespace CE_UAA14WPF24_FranckenLouis
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 9 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdMain;

#line default
#line hidden


#line 16 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RowDefinition secondRowMain;

#line default
#line hidden


#line 22 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SecondeGrille;

#line default
#line hidden


#line 39 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton buttonSolitaire;

#line default
#line hidden


#line 40 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton buttonMarelle;

#line default
#line hidden


#line 41 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton buttonBandeLaterale;

#line default
#line hidden


#line 42 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonValidate;

#line default
#line hidden


#line 43 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textTaillePlateau;

#line default
#line hidden


#line 44 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputLignes;

#line default
#line hidden


#line 45 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputColonnes;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CE_UAA14WPF24_FranckenLouis;V1.0.0.0;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.grdMain = ((System.Windows.Controls.Grid)(target));
                    return;
                case 2:
                    this.secondRowMain = ((System.Windows.Controls.RowDefinition)(target));
                    return;
                case 3:
                    this.SecondeGrille = ((System.Windows.Controls.Grid)(target));
                    return;
                case 4:
                    this.buttonSolitaire = ((System.Windows.Controls.RadioButton)(target));

#line 39 "..\..\..\MainWindow.xaml"
                    this.buttonSolitaire.Checked += new System.Windows.RoutedEventHandler(this.buttonSolitaire_Checked);

#line default
#line hidden
                    return;
                case 5:
                    this.buttonMarelle = ((System.Windows.Controls.RadioButton)(target));

#line 40 "..\..\..\MainWindow.xaml"
                    this.buttonMarelle.Checked += new System.Windows.RoutedEventHandler(this.buttonMarelle_Checked);

#line default
#line hidden
                    return;
                case 6:
                    this.buttonBandeLaterale = ((System.Windows.Controls.RadioButton)(target));

#line 41 "..\..\..\MainWindow.xaml"
                    this.buttonBandeLaterale.Checked += new System.Windows.RoutedEventHandler(this.buttonBandeLaterale_Checked);

#line default
#line hidden
                    return;
                case 7:
                    this.buttonValidate = ((System.Windows.Controls.Button)(target));

#line 42 "..\..\..\MainWindow.xaml"
                    this.buttonValidate.Click += new System.Windows.RoutedEventHandler(this.buttonValidate_Click);

#line default
#line hidden
                    return;
                case 8:
                    this.textTaillePlateau = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 9:
                    this.inputLignes = ((System.Windows.Controls.TextBox)(target));

#line 44 "..\..\..\MainWindow.xaml"
                    this.inputLignes.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.inputLignes_TextChanged_1);

#line default
#line hidden
                    return;
                case 10:
                    this.inputColonnes = ((System.Windows.Controls.TextBox)(target));

#line 45 "..\..\..\MainWindow.xaml"
                    this.inputColonnes.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.inputColonnes_TextChanged_1);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBlock textUnderground;
    }
}

