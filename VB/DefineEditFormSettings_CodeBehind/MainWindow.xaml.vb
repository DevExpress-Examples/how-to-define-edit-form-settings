Imports DevExpress.Mvvm
Imports DevExpress.Xpf.Grid
Imports System.Collections.Generic
Imports System.Windows

Namespace DefineEditFormSettings_CodeBehind

    Public Class Employee
        Inherits BindableBase

        Public Property Id As Integer
            Get
                Return GetValue(Of Integer)()
            End Get

            Set(ByVal value As Integer)
                SetValue(value)
            End Set
        End Property

        Public Property ParentId As Integer
            Get
                Return GetValue(Of Integer)()
            End Get

            Set(ByVal value As Integer)
                SetValue(value)
            End Set
        End Property

        Public Property Name As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property

        Public Property Position As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property

        Public Property Department As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property
    End Class

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            grid.ItemsSource = New List(Of Employee)(GetEmployees())
        End Sub

        Private Iterator Function GetEmployees() As IEnumerable(Of Employee)
            Yield New Employee() With {.Id = 1, .ParentId = 0, .Name = "Gregory S. Price", .Department = "", .Position = "President"}
            Yield New Employee() With {.Id = 2, .ParentId = 1, .Name = "Irma R. Marshall", .Department = "Marketing", .Position = "Vice President"}
            Yield New Employee() With {.Id = 3, .ParentId = 1, .Name = "John C. Powell", .Department = "Operations", .Position = "Vice President"}
            Yield New Employee() With {.Id = 4, .ParentId = 1, .Name = "Christian P. Laclair", .Department = "Production", .Position = "Vice President"}
            Yield New Employee() With {.Id = 5, .ParentId = 1, .Name = "Karen J. Kelly", .Department = "Finance", .Position = "Vice President"}
            Yield New Employee() With {.Id = 6, .ParentId = 2, .Name = "Brian C. Cowling", .Department = "Marketing", .Position = "Manager"}
            Yield New Employee() With {.Id = 7, .ParentId = 2, .Name = "Thomas C. Dawson", .Department = "Marketing", .Position = "Manager"}
            Yield New Employee() With {.Id = 8, .ParentId = 2, .Name = "Angel M. Wilson", .Department = "Marketing", .Position = "Manager"}
            Yield New Employee() With {.Id = 9, .ParentId = 2, .Name = "Bryan R. Henderson", .Department = "Marketing", .Position = "Manager"}
            Yield New Employee() With {.Id = 10, .ParentId = 3, .Name = "Harold S. Brandes", .Department = "Operations", .Position = "Manager"}
            Yield New Employee() With {.Id = 11, .ParentId = 3, .Name = "Michael S. Blevins", .Department = "Operations", .Position = "Manager"}
            Yield New Employee() With {.Id = 12, .ParentId = 3, .Name = "Jan K. Sisk", .Department = "Operations", .Position = "Manager"}
            Yield New Employee() With {.Id = 13, .ParentId = 3, .Name = "Sidney L. Holder", .Department = "Operations", .Position = "Manager"}
            Yield New Employee() With {.Id = 14, .ParentId = 4, .Name = "James L. Kelsey", .Department = "Production", .Position = "Manager"}
            Yield New Employee() With {.Id = 15, .ParentId = 4, .Name = "Howard M. Carpenter", .Department = "Production", .Position = "Manager"}
            Yield New Employee() With {.Id = 16, .ParentId = 4, .Name = "Jennifer T. Tapia", .Department = "Production", .Position = "Manager"}
            Yield New Employee() With {.Id = 17, .ParentId = 5, .Name = "Judith P. Underhill", .Department = "Finance", .Position = "Manager"}
            Yield New Employee() With {.Id = 18, .ParentId = 5, .Name = "Russell E. Belton", .Department = "Finance", .Position = "Manager"}
        End Function

        Private Sub OnRowEditStarting(ByVal sender As Object, ByVal e As RowEditStartingEventArgs)
            If e.RowHandle Is DataControlBase.NewItemRowHandle Then
                e.CellEditors(0).Value = grid.VisibleRowCount + 1
                e.CellEditors(4).[ReadOnly] = True
            Else
                e.CellEditors(0).[ReadOnly] = True
                e.CellEditors(4).[ReadOnly] = False
            End If
        End Sub
    End Class
End Namespace
