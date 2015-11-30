Public Class MainFrm

#Region "Comman Actions..."

    Private Sub Exit_Program(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, Button5.Click, Button9.Click
        Me.Close()
    End Sub

    Private Sub Show_Help_Action(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click, Button6.Click, Button10.Click
        Help.ShowHelp(Me.Button3, My.Application.Info.DirectoryPath & "\Manual.CHM", HelpNavigator.TableOfContents)
    End Sub

    Private Sub About_Program(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button8.Click, Button12.Click
        My.Forms.AbouteGUARD.ShowDialog()
    End Sub

#End Region

    Private Sub General_Policies(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            'Disable CD / DVD Autorun feature..
            If CheckBox1.Checked Then
                SetRegValue(MainRegKey.LocalMachine, "SYSTEM\CurrentControlSet\Services\CDRom", "Autorun", 0, Microsoft.Win32.RegistryValueKind.DWord)
            Else
                SetRegValue(MainRegKey.LocalMachine, "SYSTEM\CurrentControlSet\Services\CDRom", "Autorun", 1, Microsoft.Win32.RegistryValueKind.DWord)
            End If
            '=================================================================================
            'Disable CD / DVD Burning..
            If CheckBox2.Checked Then
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoCDBurning", 1, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoCDBurning", 1, Microsoft.Win32.RegistryValueKind.DWord)
            Else
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoCDBurning", 0, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoCDBurning", 0, Microsoft.Win32.RegistryValueKind.DWord)
            End If
            '=================================================================================
            'Disable Registry Editing Tools..
            If CheckBox3.Checked Then
                SetRegValue(MainRegKey.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", 1, Microsoft.Win32.RegistryValueKind.DWord)
            Else
                SetRegValue(MainRegKey.CurrentUser, "SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", 0, Microsoft.Win32.RegistryValueKind.DWord)
            End If
            '=================================================================================
            'Disable Control Panel..
            If CheckBox4.Checked Then
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoControlPanel", 1, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoControlPanel", 1, Microsoft.Win32.RegistryValueKind.DWord)
            Else
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoControlPanel", 0, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoControlPanel", 0, Microsoft.Win32.RegistryValueKind.DWord)
            End If
            '=================================================================================
            'Disable the Ability to Customize Toolbars..
            If CheckBox5.Checked Then
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoToolbarCustomize", 1, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoToolbarCustomize", 1, Microsoft.Win32.RegistryValueKind.DWord)
            Else
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoToolbarCustomize", 0, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoToolbarCustomize", 0, Microsoft.Win32.RegistryValueKind.DWord)
            End If
            '=================================================================================
            'Disable System Restore Tools and Settings..
            If CheckBox9.Checked Then
                SetRegValue(MainRegKey.LocalMachine, "SOFTWARE\Policies\Microsoft\Windows NT\SystemRestore", "DisableConfig", 1, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.LocalMachine, "SOFTWARE\Policies\Microsoft\Windows NT\SystemRestore", "DisableSR", 1, Microsoft.Win32.RegistryValueKind.DWord)
            Else
                SetRegValue(MainRegKey.LocalMachine, "SOFTWARE\Policies\Microsoft\Windows NT\SystemRestore", "DisableConfig", 0, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.LocalMachine, "SOFTWARE\Policies\Microsoft\Windows NT\SystemRestore", "DisableSR", 0, Microsoft.Win32.RegistryValueKind.DWord)
            End If
            '=================================================================================
            'Disable the Taskbar Clock..
            If CheckBox8.Checked Then
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "HideClock", 1, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "HideClock", 1, Microsoft.Win32.RegistryValueKind.DWord)
            Else
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "HideClock", 0, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "HideClock", 0, Microsoft.Win32.RegistryValueKind.DWord)
            End If
            '=================================================================================            '=================================================================================
            'Disable Tray Items from Taskbar..
            If CheckBox7.Checked Then
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoTrayItemsDisplay", 1, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoTrayItemsDisplay", 1, Microsoft.Win32.RegistryValueKind.DWord)
            Else
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoTrayItemsDisplay", 0, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoTrayItemsDisplay", 0, Microsoft.Win32.RegistryValueKind.DWord)
            End If
            '================================================================================= 
            'Disable the Virtual Memory Button..
            If CheckBox6.Checked Then
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoVirtMemPage", 1, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoVirtMemPage", 1, Microsoft.Win32.RegistryValueKind.DWord)
            Else
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoVirtMemPage", 0, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoVirtMemPage", 0, Microsoft.Win32.RegistryValueKind.DWord)
            End If
            '================================================================================= 
            'Disable the Windows Hotkeys..
            If CheckBox10.Checked Then
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoWinKeys", 1, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoWinKeys", 1, Microsoft.Win32.RegistryValueKind.DWord)
            Else
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoWinKeys", 0, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoWinKeys", 0, Microsoft.Win32.RegistryValueKind.DWord)
            End If
            '================================================================================= 
        Catch ex As Exception
            MsgBox("Unexpected Error Occured, while accessing the registry..", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            'Disable Run Menu..
            If CheckBox11.Checked Then
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoRun", 1, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoRun", 1, Microsoft.Win32.RegistryValueKind.DWord)
            Else
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoRun", 0, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoRun", 0, Microsoft.Win32.RegistryValueKind.DWord)
            End If
            '=================================================================================
            'Disable Help Menu..
            If CheckBox12.Checked Then
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoSMHelp", 1, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoSMHelp", 1, Microsoft.Win32.RegistryValueKind.DWord)
            Else
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoSMHelp", 0, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoSMHelp", 0, Microsoft.Win32.RegistryValueKind.DWord)
            End If
            '=================================================================================
            'Disable Display - Settings Page..
            If CheckBox13.Checked Then
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispSettingsPage", 1, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispSettingsPage", 1, Microsoft.Win32.RegistryValueKind.DWord)
            Else
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispSettingsPage", 0, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispSettingsPage", 0, Microsoft.Win32.RegistryValueKind.DWord)
            End If
            '=================================================================================
            'Disable Display - Screen Saver Page..
            If CheckBox14.Checked Then
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispScrSavPage", 1, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispScrSavPage", 1, Microsoft.Win32.RegistryValueKind.DWord)
            Else
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispScrSavPage", 0, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispScrSavPage", 0, Microsoft.Win32.RegistryValueKind.DWord)
            End If
            '=================================================================================
            'Disable Display - Background Page..
            If CheckBox15.Checked Then
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispBackgroundPage", 1, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispBackgroundPage", 1, Microsoft.Win32.RegistryValueKind.DWord)
            Else
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispBackgroundPage", 0, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispBackgroundPage", 0, Microsoft.Win32.RegistryValueKind.DWord)
            End If
            '=================================================================================
            'Disable Display - Appearence Page..
            If CheckBox16.Checked Then
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispAppearancePage", 1, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispAppearancePage", 1, Microsoft.Win32.RegistryValueKind.DWord)
            Else
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispAppearancePage", 0, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "NoDispAppearancePage", 0, Microsoft.Win32.RegistryValueKind.DWord)
            End If
            '=================================================================================
            'Disable My Computer - Properties..
            If CheckBox17.Checked Then
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoPropertiesMyComputer", 1, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoPropertiesMyComputer", 1, Microsoft.Win32.RegistryValueKind.DWord)
            Else
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoPropertiesMyComputer", 0, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoPropertiesMyComputer", 0, Microsoft.Win32.RegistryValueKind.DWord)
            End If
            '=================================================================================
            'Disable Task Manager
            If CheckBox18.Checked Then
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", 1, Microsoft.Win32.RegistryValueKind.DWord)
            Else
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", 0, Microsoft.Win32.RegistryValueKind.DWord)
            End If
            '=================================================================================
            ' Disable Thumbnail Cache..
            If CheckBox19.Checked Then
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "DisableThumbnailCache", 1, Microsoft.Win32.RegistryValueKind.DWord)
            Else
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "DisableThumbnailCache", 0, Microsoft.Win32.RegistryValueKind.DWord)
            End If
            '=================================================================================
            'Clear Page File at shut down..
            If CheckBox20.Checked Then
                SetRegValue(MainRegKey.LocalMachine, "SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management", "ClearPageFileAtShutdown", 1, Microsoft.Win32.RegistryValueKind.DWord)
            Else
                SetRegValue(MainRegKey.LocalMachine, "SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management", "ClearPageFileAtShutdown", 0, Microsoft.Win32.RegistryValueKind.DWord)
            End If
            '=================================================================================
        Catch ex As Exception
            MsgBox("Unexpected Error Occured, while accessing the registry..", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CheckBox14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox14.CheckedChanged

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try
            If TextBox1.Enabled = True Then
                If TextBox1.Text = "" Then
                    MsgBox("You must enter a user name and password..")
                    Exit Sub
                End If
            End If
            'Disable IE Password Cahing
            If CheckBox21.Checked Then
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Internet Settings", "DisablePasswordCaching", 1, Microsoft.Win32.RegistryValueKind.DWord)
            Else
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Internet Settings", "DisablePasswordCaching", 0, Microsoft.Win32.RegistryValueKind.DWord)
            End If
            '=================================================================================
            'Empty Temp Internet Files
            If CheckBox22.Checked Then
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Internet Settings\Cache", "Persistent", 0, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Internet Settings\Cache", "Persistent", 0, Microsoft.Win32.RegistryValueKind.DWord)
            Else
                SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Internet Settings\Cache", "Persistent", 1, Microsoft.Win32.RegistryValueKind.DWord)
                SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Internet Settings\Cache", "Persistent", 1, Microsoft.Win32.RegistryValueKind.DWord)
            End If
            '=================================================================================
            'Auto Logon..
            If CheckBox23.Checked Then
                SetRegValue(MainRegKey.LocalMachine, "SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "AutoAdminLogon", "1", Microsoft.Win32.RegistryValueKind.String)
                SetRegValue(MainRegKey.LocalMachine, "SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "ForceAutoLogon", "1", Microsoft.Win32.RegistryValueKind.String)
                SetRegValue(MainRegKey.LocalMachine, "SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "DefaultUserName", TextBox1.Text, Microsoft.Win32.RegistryValueKind.String)
                SetRegValue(MainRegKey.LocalMachine, "SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "DefaultPassword", TextBox2.Text, Microsoft.Win32.RegistryValueKind.String)
            Else
                SetRegValue(MainRegKey.LocalMachine, "SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "AutoAdminLogon", "0", Microsoft.Win32.RegistryValueKind.String)
                SetRegValue(MainRegKey.LocalMachine, "SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "ForceAutoLogon", "0", Microsoft.Win32.RegistryValueKind.String)
                SetRegValue(MainRegKey.LocalMachine, "SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "DefaultUserName", "", Microsoft.Win32.RegistryValueKind.String)
                SetRegValue(MainRegKey.LocalMachine, "SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", "DefaultPassword", "", Microsoft.Win32.RegistryValueKind.String)
            End If
            '=================================================================================
            'Lock Drives..
            Dim i As Integer = 0
            If CheckBox24.Checked Then
                Dim s As String = TextBox3.Text.ToLower
                If s.Contains("a") Then i = i + 1
                If s.Contains("b") Then i = i + 2
                If s.Contains("c") Then i = i + 4
                If s.Contains("d") Then i = i + 8
                If s.Contains("e") Then i = i + 16
                If s.Contains("f") Then i = i + 32
                If s.Contains("g") Then i = i + 64
                If s.Contains("h") Then i = i + 128
                If s.Contains("i") Then i = i + 256
                If s.Contains("j") Then i = i + 512
                If s.Contains("k") Then i = i + 1024
                If s.Contains("l") Then i = i + 2048
                If s.Contains("m") Then i = i + 4096
                If s.Contains("n") Then i = i + 8192
                If s.Contains("o") Then i = i + 16384
                If s.Contains("p") Then i = i + 32768
                If s.Contains("q") Then i = i + 65536
                If s.Contains("r") Then i = i + 131072
                If s.Contains("s") Then i = i + 262144
                If s.Contains("t") Then i = i + 524288
                If s.Contains("u") Then i = i + 1048576
                If s.Contains("v") Then i = i + 2097152
                If s.Contains("w") Then i = i + 4194304
                If s.Contains("x") Then i = i + 8388608
                If s.Contains("y") Then i = i + 16777216
                If s.Contains("z") Then i = i + 33554432
            End If
            SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoViewOnDrive", i, Microsoft.Win32.RegistryValueKind.DWord)
            SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoViewOnDrive", i, Microsoft.Win32.RegistryValueKind.DWord)
            '=================================================================================
            'Lock Drives..
            i = 0
            If CheckBox24.Checked Then
                Dim s As String = TextBox4.Text.ToLower
                If s.Contains("a") Then i = i + 1
                If s.Contains("b") Then i = i + 2
                If s.Contains("c") Then i = i + 4
                If s.Contains("d") Then i = i + 8
                If s.Contains("e") Then i = i + 16
                If s.Contains("f") Then i = i + 32
                If s.Contains("g") Then i = i + 64
                If s.Contains("h") Then i = i + 128
                If s.Contains("i") Then i = i + 256
                If s.Contains("j") Then i = i + 512
                If s.Contains("k") Then i = i + 1024
                If s.Contains("l") Then i = i + 2048
                If s.Contains("m") Then i = i + 4096
                If s.Contains("n") Then i = i + 8192
                If s.Contains("o") Then i = i + 16384
                If s.Contains("p") Then i = i + 32768
                If s.Contains("q") Then i = i + 65536
                If s.Contains("r") Then i = i + 131072
                If s.Contains("s") Then i = i + 262144
                If s.Contains("t") Then i = i + 524288
                If s.Contains("u") Then i = i + 1048576
                If s.Contains("v") Then i = i + 2097152
                If s.Contains("w") Then i = i + 4194304
                If s.Contains("x") Then i = i + 8388608
                If s.Contains("y") Then i = i + 16777216
                If s.Contains("z") Then i = i + 33554432
            End If
            SetRegValue(MainRegKey.LocalMachine, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDrives", i, Microsoft.Win32.RegistryValueKind.DWord)
            SetRegValue(MainRegKey.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDrives", i, Microsoft.Win32.RegistryValueKind.DWord)
            '=================================================================================
        Catch ex As Exception
            MsgBox("Unexpected Error Occured, while accessing the registry..", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CheckBox23_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox23.CheckedChanged
        If CheckBox23.Checked Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox1.Select()
        Else
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Enabled = False
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub CheckBox24_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox24.CheckedChanged
        If CheckBox24.Checked Then
            TextBox3.Enabled = True
        Else
            TextBox3.Text = ""
            TextBox3.Enabled = False
        End If
    End Sub

    Private Sub CheckBox25_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox25.CheckedChanged
        If CheckBox25.Checked Then
            TextBox4.Enabled = True
        Else
            TextBox4.Text = ""
            TextBox4.Enabled = False
        End If
    End Sub
End Class
