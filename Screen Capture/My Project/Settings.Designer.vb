﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C:")>  _
        Public Property Default_Directory() As String
            Get
                Return CType(Me("Default_Directory"),String)
            End Get
            Set
                Me("Default_Directory") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property DefaultDir_Bool() As Boolean
            Get
                Return CType(Me("DefaultDir_Bool"),Boolean)
            End Get
            Set
                Me("DefaultDir_Bool") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property visibility() As Integer
            Get
                Return CType(Me("visibility"),Integer)
            End Get
            Set
                Me("visibility") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property notifySCap() As Boolean
            Get
                Return CType(Me("notifySCap"),Boolean)
            End Get
            Set
                Me("notifySCap") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property notifyTimer() As Boolean
            Get
                Return CType(Me("notifyTimer"),Boolean)
            End Get
            Set
                Me("notifyTimer") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Format32bppArgb")>  _
        Public Property PixelFormat() As Global.System.Drawing.Imaging.PixelFormat
            Get
                Return CType(Me("PixelFormat"),Global.System.Drawing.Imaging.PixelFormat)
            End Get
            Set
                Me("PixelFormat") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Jpeg")>  _
        Public Property FileFormat() As Global.System.Drawing.Imaging.ImageFormat
            Get
                Return CType(Me("FileFormat"),Global.System.Drawing.Imaging.ImageFormat)
            End Get
            Set
                Me("FileFormat") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("ScreenShot")>  _
        Public Property FileName() As String
            Get
                Return CType(Me("FileName"),String)
            End Get
            Set
                Me("FileName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("GeneralDate")>  _
        Public Property FileDate() As Global.Microsoft.VisualBasic.DateFormat
            Get
                Return CType(Me("FileDate"),Global.Microsoft.VisualBasic.DateFormat)
            End Get
            Set
                Me("FileDate") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("GeneralDate")>  _
        Public Property FileDateandTime() As Global.Microsoft.VisualBasic.DateFormat
            Get
                Return CType(Me("FileDateandTime"),Global.Microsoft.VisualBasic.DateFormat)
            End Get
            Set
                Me("FileDateandTime") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property DateBool() As Boolean
            Get
                Return CType(Me("DateBool"),Boolean)
            End Get
            Set
                Me("DateBool") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Prefix() As Boolean
            Get
                Return CType(Me("Prefix"),Boolean)
            End Get
            Set
                Me("Prefix") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Suffix() As Boolean
            Get
                Return CType(Me("Suffix"),Boolean)
            End Get
            Set
                Me("Suffix") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property ImageViewer() As Boolean
            Get
                Return CType(Me("ImageViewer"),Boolean)
            End Get
            Set
                Me("ImageViewer") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property NotificationShow() As Boolean
            Get
                Return CType(Me("NotificationShow"),Boolean)
            End Get
            Set
                Me("NotificationShow") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property NotificationDuration() As Integer
            Get
                Return CType(Me("NotificationDuration"),Integer)
            End Get
            Set
                Me("NotificationDuration") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property MessageShow() As Boolean
            Get
                Return CType(Me("MessageShow"),Boolean)
            End Get
            Set
                Me("MessageShow") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property ClipBoardCopy() As Boolean
            Get
                Return CType(Me("ClipBoardCopy"),Boolean)
            End Get
            Set
                Me("ClipBoardCopy") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property PlaySound() As Boolean
            Get
                Return CType(Me("PlaySound"),Boolean)
            End Get
            Set
                Me("PlaySound") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Trasparent() As Boolean
            Get
                Return CType(Me("Trasparent"),Boolean)
            End Get
            Set
                Me("Trasparent") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("100")>  _
        Public Property Transparency() As Decimal
            Get
                Return CType(Me("Transparency"),Decimal)
            End Get
            Set
                Me("Transparency") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property AutomaticNmber() As Integer
            Get
                Return CType(Me("AutomaticNmber"),Integer)
            End Get
            Set
                Me("AutomaticNmber") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property autonum() As Boolean
            Get
                Return CType(Me("autonum"),Boolean)
            End Get
            Set
                Me("autonum") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property taskbar() As Boolean
            Get
                Return CType(Me("taskbar"),Boolean)
            End Get
            Set
                Me("taskbar") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property FileTime() As Boolean
            Get
                Return CType(Me("FileTime"),Boolean)
            End Get
            Set
                Me("FileTime") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("F7")>  _
        Public Property CapScrKey() As Global.System.Windows.Forms.Keys
            Get
                Return CType(Me("CapScrKey"),Global.System.Windows.Forms.Keys)
            End Get
            Set
                Me("CapScrKey") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("F8")>  _
        Public Property CapArKey() As Global.System.Windows.Forms.Keys
            Get
                Return CType(Me("CapArKey"),Global.System.Windows.Forms.Keys)
            End Get
            Set
                Me("CapArKey") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Neutrino_Screen_Capture.My.MySettings
            Get
                Return Global.Neutrino_Screen_Capture.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
