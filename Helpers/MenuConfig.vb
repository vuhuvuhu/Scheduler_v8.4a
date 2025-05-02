Option Explicit On
Option Strict On

Imports Scheduler.Models

''' <summary>
'''   აპლიკაციის მენიუს კონფიგურაციის მოდული:
'''   Definitions შეიცავს ყველა მთავარ ელემენტს და როლებზე დაშვებას.
''' </summary>
Public Module MenuConfig

    ''' <summary>
    '''   სტატიკური მენიუს ელემენტები დასახლებისთვის,
    '''   ინიციალიზებულია ფუნქციის მეშვეობით.
    ''' </summary>
    Public ReadOnly Definitions As List(Of AppMenuItem) = InitializeMenuDefinitions()

    ''' <summary>
    '''   ააწყობს და დაბრუნებს AppMenuItem-ის სიას
    '''   შესაბამისი როლების შესაბამისობით.
    ''' </summary>
    Private Function InitializeMenuDefinitions() As List(Of AppMenuItem)
        Dim items As New List(Of AppMenuItem)

        ' — საწყისი (ყველა როლისთვის)
        items.Add(New AppMenuItem() With {
            .Key = "Home",
            .Text = "საწყისი",
            .RolesAllowed = New List(Of Integer)(),
            .SubItems = New List(Of AppMenuItem)()
        })

        ' — კალენდარი (როლები 1–5)
        items.Add(New AppMenuItem() With {
            .Key = "Calendar",
            .Text = "კალენდარი",
            .RolesAllowed = New List(Of Integer)(New Integer() {1, 2, 3, 4, 5}),
            .SubItems = New List(Of AppMenuItem)()
        })

        ' — განრიგი (1–3)
        items.Add(New AppMenuItem() With {
            .Key = "Schedule",
            .Text = "განრიგი",
            .RolesAllowed = New List(Of Integer)(New Integer() {1, 2, 3}),
            .SubItems = New List(Of AppMenuItem)()
        })

        ' — გრაფიკები (1–2)
        items.Add(New AppMenuItem() With {
            .Key = "Charts",
            .Text = "გრაფიკები",
            .RolesAllowed = New List(Of Integer)(New Integer() {1, 2}),
            .SubItems = New List(Of AppMenuItem)()
        })

        ' — დოკუმენტები (1–3)
        items.Add(New AppMenuItem() With {
            .Key = "Documents",
            .Text = "დოკუმენტები",
            .RolesAllowed = New List(Of Integer)(New Integer() {1, 2, 3}),
            .SubItems = New List(Of AppMenuItem)()
        })

        ' — ფინანსები (1)
        items.Add(New AppMenuItem() With {
            .Key = "Finances",
            .Text = "ფინანსები",
            .RolesAllowed = New List(Of Integer)(New Integer() {1}),
            .SubItems = New List(Of AppMenuItem)()
        })

        ' — ადმინისტრირება (1)
        items.Add(New AppMenuItem() With {
            .Key = "Admin",
            .Text = "ადმინისტრირება",
            .RolesAllowed = New List(Of Integer)(New Integer() {1}),
            .SubItems = New List(Of AppMenuItem)()
        })

        Return items
    End Function

End Module
