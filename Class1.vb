Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.Runtime
Imports Autodesk.AutoCAD.Geometry
Imports Autodesk.AutoCAD.EditorInput
Imports System.ComponentModel
Imports Autodesk.AutoCAD.Internal
Imports AutoCAD = Autodesk.AutoCAD.Interop
Imports AcadLib = Autodesk.AutoCAD.Interop.Common
Imports Autodesk

Public Class comando

    <CommandMethod("ola")>
    Public Sub olaMundo()
        Dim doc As Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
        Dim db As Database = doc.Database
        Dim ed As Editor = doc.Editor

        MsgBox("Olá, Mundo! Testando Geração de Plugin com AutoCad")

    End Sub

End Class
