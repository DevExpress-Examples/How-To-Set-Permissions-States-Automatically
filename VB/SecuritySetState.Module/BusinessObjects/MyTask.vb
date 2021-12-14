Imports DevExpress.Xpo
Imports System.ComponentModel
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

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

        Private subjectField As String

        Public Property Subject As String
            Get
                Return subjectField
            End Get

            Set(ByVal value As String)
                SetPropertyValue(NameOf(MyTask.Subject), subjectField, value)
            End Set
        End Property

        Private assignedToField As Contact

        <Association("Contact-Tasks")>
        Public Property AssignedTo As Contact
            Get
                Return assignedToField
            End Get

            Set(ByVal value As Contact)
                SetPropertyValue(NameOf(MyTask.AssignedTo), assignedToField, value)
            End Set
        End Property

        Private isActiveField As Boolean

        Public Property IsActive As Boolean
            Get
                Return isActiveField
            End Get

            Set(ByVal value As Boolean)
                SetPropertyValue(NameOf(MyTask.IsActive), isActiveField, value)
            End Set
        End Property

        Private priorityField As Priority

        Public Property Priority As Priority
            Get
                Return priorityField
            End Get

            Set(ByVal value As Priority)
                SetPropertyValue(NameOf(MyTask.Priority), priorityField, value)
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
