Imports DevExpress.Xpo
Imports System.ComponentModel
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports System.Diagnostics
Imports DevExpress.ExpressApp.ConditionalAppearance

Namespace SecuritySetState.Module.BusinessObjects

    <DefaultClassOptions>
    <DebuggerDisplay("FirstName: {FirstName}")>
    <Appearance("RedPriceObject", AppearanceItemType:="ViewItem", TargetItems:="TestBool,LastName", Enabled:=False)>
    Public Class Contact
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub

        Private firstNameField As String

        Public Property FirstName As String
            Get
                Return firstNameField
            End Get

            Set(ByVal value As String)
                SetPropertyValue(NameOf(Contact.FirstName), firstNameField, value)
            End Set
        End Property

        Private lastNameField As String

        Public Property LastName As String
            Get
                Return lastNameField
            End Get

            Set(ByVal value As String)
                SetPropertyValue(NameOf(Contact.LastName), lastNameField, value)
            End Set
        End Property

        Private ageField As Integer

        Public Property Age As Integer
            Get
                Return ageField
            End Get

            Set(ByVal value As Integer)
                SetPropertyValue(NameOf(Contact.Age), ageField, value)
            End Set
        End Property

        Private testBoolField As Boolean

        Public Property TestBool As Boolean
            Get
                Return testBoolField
            End Get

            Set(ByVal value As Boolean)
                SetPropertyValue(NameOf(Contact.TestBool), testBoolField, value)
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
        Public ReadOnly Property Tasks As XPCollection(Of MyTask)
            Get
                Return GetCollection(Of MyTask)(NameOf(Contact.Tasks))
            End Get
        End Property
    End Class
End Namespace
