Namespace BindWebReportToArrayList
    Public Class Record


        Private id_Renamed, age_Renamed As Integer

        Private name_Renamed As String
        Public Sub New(ByVal id As Integer, ByVal name As String, ByVal age As Integer)
            Me.id_Renamed = id
            Me.name_Renamed = name
            Me.age_Renamed = age
        End Sub
        Public Property ID() As Integer
            Get
                Return id_Renamed
            End Get
            Set(ByVal value As Integer)
                id_Renamed = value
            End Set
        End Property
        Public Property Name() As String
            Get
                Return name_Renamed
            End Get
            Set(ByVal value As String)
                name_Renamed = value
            End Set
        End Property
        Public Property Age() As Integer
            Get
                Return age_Renamed
            End Get
            Set(ByVal value As Integer)
                age_Renamed = value
            End Set
        End Property
    End Class
End Namespace