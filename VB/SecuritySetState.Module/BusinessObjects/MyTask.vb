Imports System
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports System.ComponentModel
Imports DevExpress.ExpressApp.DC
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.Base
Imports System.Collections.Generic
Imports DevExpress.ExpressApp.Model
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.Persistent.Base.General
Imports DevExpress.ExpressApp.SystemModule

Namespace SecuritySetState.Module.BusinessObjects
	<DefaultClassOptions>
	Public Class MyTask
		Inherits BaseObject

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
		End Sub
'INSTANT VB NOTE: The field subject was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private subject_Conflict As String
		Public Property Subject() As String
			Get
				Return subject_Conflict
			End Get
			Set(ByVal value As String)
				SetPropertyValue(NameOf(Subject), subject_Conflict, value)
			End Set
		End Property
'INSTANT VB NOTE: The field assignedTo was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private assignedTo_Conflict As Contact
		<Association("Contact-Tasks")>
		Public Property AssignedTo() As Contact
			Get
				Return assignedTo_Conflict
			End Get
			Set(ByVal value As Contact)
				SetPropertyValue(NameOf(AssignedTo), assignedTo_Conflict, value)
			End Set
		End Property
'INSTANT VB NOTE: The field isActive was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private isActive_Conflict As Boolean
		Public Property IsActive() As Boolean
			Get
				Return isActive_Conflict
			End Get
			Set(ByVal value As Boolean)
				SetPropertyValue(NameOf(IsActive), isActive_Conflict, value)
			End Set
		End Property
'INSTANT VB NOTE: The field priority was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private priority_Conflict As Priority
		Public Property Priority() As Priority
			Get
				Return priority_Conflict
			End Get
			Set(ByVal value As Priority)
				SetPropertyValue(NameOf(Priority), priority_Conflict, value)
			End Set
		End Property
	End Class
	Public Enum Priority
		<ImageName("State_Priority_Low")>
		Low = 0
		<ImageName("State_Priority_Normal")>
		Normal = 1
		<ImageName("State_Priority_High")>
		High = 2
	End Enum
End Namespace