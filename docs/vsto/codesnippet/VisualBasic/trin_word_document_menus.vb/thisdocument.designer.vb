﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.17348
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



'''
<Microsoft.VisualStudio.Tools.Applications.Runtime.StartupObjectAttribute(0), _
 Global.System.Security.Permissions.PermissionSetAttribute(Global.System.Security.Permissions.SecurityAction.Demand, Name:="FullTrust")> _
Partial Public NotInheritable Class ThisDocument
    Inherits Microsoft.Office.Tools.Word.DocumentBase

    Friend WithEvents ActionsPane As Microsoft.Office.Tools.ActionsPane

    Friend WithEvents Bookmark1 As Microsoft.Office.Tools.Word.Bookmark

    Friend WithEvents Bookmark2 As Microsoft.Office.Tools.Word.Bookmark

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")> _
    Friend WithEvents ThisApplication As Microsoft.Office.Interop.Word.Application

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Public Sub New(ByVal factory As Global.Microsoft.Office.Tools.Word.Factory, ByVal serviceProvider As Global.System.IServiceProvider)
        MyBase.New(factory, serviceProvider, "ThisDocument", "ThisDocument")
        Globals.Factory = factory
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Protected Overrides Sub Initialize()
        MyBase.Initialize()
        Me.ThisApplication = Me.GetHostItem(Of Microsoft.Office.Interop.Word.Application)(GetType(Microsoft.Office.Interop.Word.Application), "Application")
        Globals.ThisDocument = Me
        Global.System.Windows.Forms.Application.EnableVisualStyles()
        Me.InitializeCachedData()
        Me.InitializeControls()
        Me.InitializeComponents()
        Me.InitializeData()
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Protected Overrides Sub FinishInitialization()
        Me.OnStartup()
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Protected Overrides Sub InitializeDataBindings()
        Me.BeginInitialization()
        Me.BindToData()
        Me.EndInitialization()
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Private Sub InitializeCachedData()
        If (Me.DataHost Is Nothing) Then
            Return
        End If
        If Me.DataHost.IsCacheInitialized Then
            Me.DataHost.FillCachedData(Me)
        End If
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Private Sub InitializeData()
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Private Sub BindToData()
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Sub StartCaching(ByVal MemberName As String)
        Me.DataHost.StartCaching(Me, MemberName)
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Sub StopCaching(ByVal MemberName As String)
        Me.DataHost.StopCaching(Me, MemberName)
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Function IsCached(ByVal MemberName As String) As Boolean
        Return Me.DataHost.IsCached(Me, MemberName)
    End Function

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Private Sub BeginInitialization()
        Me.BeginInit()
        Me.ActionsPane.BeginInit()
        Me.Bookmark1.BeginInit()
        Me.Bookmark2.BeginInit()
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Private Sub EndInitialization()
        Me.Bookmark2.EndInit()
        Me.Bookmark1.EndInit()
        Me.ActionsPane.EndInit()
        Me.EndInit()
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Private Sub InitializeControls()
        Me.ActionsPane = Globals.Factory.CreateActionsPane(Nothing, Nothing, "ActionsPane", "ActionsPane", Me)
        Me.Bookmark1 = Globals.Factory.CreateBookmark(Nothing, Nothing, "Bookmark1", "Bookmark1", Me)
        Me.Bookmark2 = Globals.Factory.CreateBookmark(Nothing, Nothing, "Bookmark2", "Bookmark2", Me)
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Private Sub InitializeComponents()
        '
        'ActionsPane
        '
        Me.ActionsPane.AutoSize = False
        Me.ActionsPane.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        '
        'Bookmark1
        '
        Me.Bookmark1.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never
        '
        'Bookmark2
        '
        Me.Bookmark2.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never
        '
        'ThisDocument
        '
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Function NeedsFill(ByVal MemberName As String) As Boolean
        Return Me.DataHost.NeedsFill(Me, MemberName)
    End Function

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Protected Overrides Sub OnShutdown()
        Me.Bookmark2.Dispose()
        Me.Bookmark1.Dispose()
        Me.ActionsPane.Dispose()
        MyBase.OnShutdown()
    End Sub
End Class

'''
<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
 Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")> _
Partial Friend NotInheritable Class Globals

    '''
    Private Sub New()
        MyBase.New()
    End Sub

    Private Shared _ThisDocument As ThisDocument

    Private Shared _factory As Global.Microsoft.Office.Tools.Word.Factory

    Private Shared _ThisRibbonCollection As ThisRibbonCollection

    Friend Shared Property ThisDocument() As ThisDocument
        Get
            Return _ThisDocument
        End Get
        Set(value As ThisDocument)
            If (_ThisDocument Is Nothing) Then
                _ThisDocument = value
            Else
                Throw New System.NotSupportedException()
            End If
        End Set
    End Property

    Friend Shared Property Factory() As Global.Microsoft.Office.Tools.Word.Factory
        Get
            Return _factory
        End Get
        Set(value As Global.Microsoft.Office.Tools.Word.Factory)
            If (_factory Is Nothing) Then
                _factory = value
            Else
                Throw New System.NotSupportedException()
            End If
        End Set
    End Property

    Friend Shared ReadOnly Property Ribbons() As ThisRibbonCollection
        Get
            If (_ThisRibbonCollection Is Nothing) Then
                _ThisRibbonCollection = New ThisRibbonCollection(_factory.GetRibbonFactory)
            End If
            Return _ThisRibbonCollection
        End Get
    End Property
End Class

'''
<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
 Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")> _
Partial Friend NotInheritable Class ThisRibbonCollection
    Inherits Microsoft.Office.Tools.Ribbon.RibbonCollectionBase

    '''
    Friend Sub New(ByVal factory As Global.Microsoft.Office.Tools.Ribbon.RibbonFactory)
        MyBase.New(factory)
    End Sub
End Class
