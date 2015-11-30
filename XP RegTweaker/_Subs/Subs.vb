Module Subs

    Public Enum MainRegKey As Byte
        LocalMachine = 0
        CurrentUser = 1
        ClassesRoot = 2
        Users = 3
        CurrentConfig = 4
    End Enum


    Public Sub SetRegValue(ByVal MainKey As MainRegKey, ByVal Key As String, ByVal EntryName As String, ByVal EntryValue As Object, ByVal EntryType As Microsoft.Win32.RegistryValueKind)
        Dim RegKey As Microsoft.Win32.RegistryKey
        Select Case MainKey
            Case MainRegKey.LocalMachine
                RegKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(Key, True)
                If RegKey Is Nothing Then
                    RegKey = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(Key, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)
                End If
            Case MainRegKey.CurrentUser
                RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Key, True)
                If RegKey Is Nothing Then
                    RegKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(Key, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)
                End If
            Case MainRegKey.ClassesRoot
                RegKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(Key, True)
                If RegKey Is Nothing Then
                    RegKey = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(Key, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)
                End If
            Case MainRegKey.CurrentConfig
                RegKey = Microsoft.Win32.Registry.CurrentConfig.OpenSubKey(Key, True)
                If RegKey Is Nothing Then
                    RegKey = Microsoft.Win32.Registry.CurrentConfig.CreateSubKey(Key, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)
                End If
            Case MainRegKey.Users
                RegKey = Microsoft.Win32.Registry.Users.OpenSubKey(Key, True)
                If RegKey Is Nothing Then
                    RegKey = Microsoft.Win32.Registry.Users.CreateSubKey(Key, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)
                End If
        End Select
        RegKey.SetValue(EntryName, EntryValue, EntryType)
        RegKey.Close()
    End Sub

End Module
