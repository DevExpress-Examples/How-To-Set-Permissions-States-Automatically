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
Imports System.Diagnostics
Imports DevExpress.Persistent.Base.General
Imports DevExpress.ExpressApp.SystemModule
Imports DevExpress.ExpressApp.ConditionalAppearance

Namespace SecuritySetState.Module.BusinessObjects
	<DefaultClassOptions>
	<DebuggerDisplay("FirstName: {FirstName}")>
	<Appearance("RedPriceObject", AppearanceItemType := "ViewItem", TargetItems := "TestBool,LastName", Enabled := False)>
	Public Class Contact
		Inherits BaseObject

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
		End Sub
'INSTANT VB NOTE: The field firstName was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private firstName_Conflict As String
		Public Property FirstName() As String
			Get
				Return firstName_Conflict
			End Get
			Set(ByVal value As String)
				SetPropertyValue(NameOf(FirstName), firstName_Conflict, value)
			End Set
		End Property
'INSTANT VB NOTE: The field lastName was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private lastName_Conflict As String
		Public Property LastName() As String
			Get
				Return lastName_Conflict
			End Get
			Set(ByVal value As String)
				SetPropertyValue(NameOf(LastName), lastName_Conflict, value)
			End Set
		End Property
'INSTANT VB NOTE: The field age was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private age_Conflict As Integer
		Public Property Age() As Integer
			Get
				Return age_Conflict
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(NameOf(Age), age_Conflict, value)
			End Set
		End Property
'INSTANT VB NOTE: The field testBool was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private testBool_Conflict As Boolean
		Public Property TestBool() As Boolean
			Get
				Return testBool_Conflict
			End Get
			Set(ByVal value As Boolean)
				SetPropertyValue(NameOf(TestBool), testBool_Conflict, value)
			End Set
		End Property
		' DateTime _birthDate;
		' public DateTime BirthDate {
		' get {
		' return _birthDate;
		' }
		' set {
		' SetPropertyValue(nameof(BirthDate), ref _birthDate, value);
		' }
		' }	
		'office#3		
		<Association("Contact-Tasks")>
		Public ReadOnly Property Tasks() As XPCollection(Of MyTask)
			Get
				Return GetCollection(Of MyTask)(NameOf(Tasks))
			End Get
		End Property
	End Class
End Namespace