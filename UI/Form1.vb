Option Explicit On
Option Strict On

Imports System.Windows.Forms
Imports Scheduler.Models      ' AppMenuItem
Imports Scheduler.Helpers     ' MenuConfig

Public Class Form1

    ''' <summary>ავტორიზებული მომხმარებლის როლი</summary>
    Private Property UserRoleID As Integer

    ''' <summary>Form-ის ლოადზე მენიუს დაავიწყეთ და BtnLogin დააყენეთ ავტორიზაციისთვის</summary>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menuStripMain.Items.Clear()
        menuStripMain.Visible = False
        BtnLogin.Text = "ავტორიზაცია"
    End Sub

    ''' <summary>BtnLogin-ზე დააჭირეთ და გააკეთეთ თქვენი ავტორიზაციის ლოგიკა</summary>
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        ' TODO: აქ ჩართეთ თქვენი ავტორიზაცია და თუ წარმატებულია:
        Dim fetchedRoleId As Integer = 2  ' მაგალითად როლი 2
        OnLoginSuccess(fetchedRoleId)
    End Sub

    ''' <summary>
    '''   ავტორიზაციის შემდეგ იწოდება,
    '''   შეიცავს როლის ID-ს და ჩადგენს მენიუს.
    ''' </summary>
    Private Sub OnLoginSuccess(roleID As Integer)
        UserRoleID = roleID
        menuStripMain.Visible = True
        InitializeMenu()
    End Sub

    ''' <summary>
    '''   აამოქმედებს MenuConfig.Definitions–ს მომხმარებლის როლის მიხედვით
    '''   და დაამატებს ToolStripMenuItem-ებს menuStripMain-ში.
    ''' </summary>
    Private Sub InitializeMenu()
        menuStripMain.Items.Clear()

        For Each def In MenuConfig.Definitions
            If def.RolesAllowed.Count = 0 OrElse def.RolesAllowed.Contains(UserRoleID) Then
                menuStripMain.Items.Add(CreateMenuItem(def))
            End If
        Next
    End Sub

    ''' <summary>
    '''   რეკურსიული მეთოდი, რომელიც
    '''   AppMenuItem–ს აქცევს ToolStripMenuItem–ად.
    ''' </summary>
    Private Function CreateMenuItem(def As AppMenuItem) As ToolStripMenuItem
        Dim item As New ToolStripMenuItem With {
            .Text = def.Text,
            .Name = $"menu{def.Key}"
        }

        For Each subDef In def.SubItems
            If subDef.RolesAllowed.Count = 0 OrElse subDef.RolesAllowed.Contains(UserRoleID) Then
                item.DropDownItems.Add(CreateMenuItem(subDef))
            End If
        Next

        Return item
    End Function

End Class
