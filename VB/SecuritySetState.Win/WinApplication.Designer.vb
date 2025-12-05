Namespace SecuritySetState.Win

    Partial Class SecuritySetStateWindowsFormsApplication

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
            Me.module3 = New SecuritySetState.[Module].SecuritySetStateModule()
            Me.module4 = New SecuritySetState.[Module].Win.SecuritySetStateWindowsFormsModule()
            Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
            Me.securityStrategyComplex1 = New DevExpress.ExpressApp.Security.SecurityStrategyComplex()
            Me.securityStrategyComplex1.SupportNavigationPermissionsForTypes = False
            Me.validationModule = New DevExpress.ExpressApp.Validation.ValidationModule()
            Me.validationWindowsFormsModule = New DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule()
            Me.authenticationStandard1 = New DevExpress.ExpressApp.Security.AuthenticationStandard()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' securityStrategyComplex1
            ' 
            Me.securityStrategyComplex1.Authentication = Me.authenticationStandard1
            Me.securityStrategyComplex1.RoleType = GetType(DevExpress.Persistent.BaseImpl.PermissionPolicy.PermissionPolicyRole)
            Me.securityStrategyComplex1.UserType = GetType(DevExpress.Persistent.BaseImpl.PermissionPolicy.PermissionPolicyUser)
            ' 
            ' securityModule1
            ' 
            Me.securityModule1.UserType = GetType(DevExpress.Persistent.BaseImpl.PermissionPolicy.PermissionPolicyUser)
            ' 
            ' authenticationStandard1
            ' 
            Me.authenticationStandard1.LogonParametersType = GetType(DevExpress.ExpressApp.Security.AuthenticationStandardLogonParameters)
            ' 
            ' SecuritySetStateWindowsFormsApplication
            ' 
            Me.ApplicationName = "SecuritySetState"
            Me.CheckCompatibilityType = DevExpress.ExpressApp.CheckCompatibilityType.DatabaseSchema
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.module3)
            Me.Modules.Add(Me.module4)
            Me.Modules.Add(Me.securityModule1)
            Me.Security = Me.securityStrategyComplex1
            Me.Modules.Add(Me.validationModule)
            Me.Modules.Add(Me.validationWindowsFormsModule)
            Me.UseOldTemplates = False
            AddHandler Me.DatabaseVersionMismatch, New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(AddressOf Me.SecuritySetStateWindowsFormsApplication_DatabaseVersionMismatch)
            AddHandler Me.CustomizeLanguagesList, New System.EventHandler(Of DevExpress.ExpressApp.CustomizeLanguagesListEventArgs)(AddressOf Me.SecuritySetStateWindowsFormsApplication_CustomizeLanguagesList)
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule

        Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule

        Private module3 As SecuritySetState.[Module].SecuritySetStateModule

        Private module4 As SecuritySetState.[Module].Win.SecuritySetStateWindowsFormsModule

        Private securityModule1 As DevExpress.ExpressApp.Security.SecurityModule

        Private securityStrategyComplex1 As DevExpress.ExpressApp.Security.SecurityStrategyComplex

        Private authenticationStandard1 As DevExpress.ExpressApp.Security.AuthenticationStandard

        Private validationModule As DevExpress.ExpressApp.Validation.ValidationModule

        Private validationWindowsFormsModule As DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule
    End Class
End Namespace
