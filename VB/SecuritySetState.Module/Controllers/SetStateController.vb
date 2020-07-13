Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.SystemModule
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl.PermissionPolicy

Namespace SecuritySetState.Module.Controllers
	Public Class SetStateController
		Inherits ViewController

		Public Sub New()
			TargetViewId = "PermissionPolicyRoleBase_TypePermissions_ListView;PermissionPolicyRoleBase_NavigationPermissions_ListView"
		End Sub
		Private controller As NewObjectViewController
		Protected Overrides Sub OnActivated()
			MyBase.OnActivated()
			controller = Frame.GetController(Of NewObjectViewController)()
			If controller IsNot Nothing Then
				AddHandler controller.ObjectCreated, AddressOf controller_ObjectCreated
			End If
		End Sub
		Private Sub controller_ObjectCreated(ByVal sender As Object, ByVal e As ObjectCreatedEventArgs)
			Dim typePermission As PermissionPolicyTypePermissionObject = TryCast(e.CreatedObject, PermissionPolicyTypePermissionObject)
			If typePermission IsNot Nothing Then
				Dim defaultState As SecurityPermissionState = SecurityPermissionState.Allow
				If typePermission.Role.PermissionPolicy = SecurityPermissionPolicy.AllowAllByDefault Then
					defaultState = SecurityPermissionState.Deny
				End If
				typePermission.ReadState = defaultState
				typePermission.WriteState = defaultState
				typePermission.CreateState = defaultState
				typePermission.DeleteState = defaultState
			End If
			Dim navigationPermission As PermissionPolicyNavigationPermissionObject = TryCast(e.CreatedObject, PermissionPolicyNavigationPermissionObject)
			If navigationPermission IsNot Nothing Then
				Dim defaultState As SecurityPermissionState = SecurityPermissionState.Allow
				If navigationPermission.Role.PermissionPolicy = SecurityPermissionPolicy.AllowAllByDefault Then
					defaultState = SecurityPermissionState.Deny
				End If
				navigationPermission.NavigateState = defaultState
			End If
		End Sub
		Protected Overrides Sub OnDeactivated()
			If controller IsNot Nothing Then
				RemoveHandler controller.ObjectCreated, AddressOf controller_ObjectCreated
			End If
			MyBase.OnDeactivated()
		End Sub
	End Class
End Namespace
