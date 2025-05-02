'─── Models/AppMenuItem.vb ────────────────────────────────────────────────────
Option Explicit On
Option Strict On

''' <summary>
'''   ერთიანი მენიუს ელემენტის მოდელი:
'''   - Text: ლოკალიზებული ტექსტი
'''   - RolesAllowed: მხოლოდ ამ როლებს გამოჩნდება
'''   - SubItems: ქვე–პუნქტები
''' </summary>
Public Class AppMenuItem
    Public Property Key As String
    Public Property Text As String
    Public Property RolesAllowed As List(Of Integer)
    Public Property SubItems As List(Of AppMenuItem)
End Class
