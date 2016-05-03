Imports System.Xml

Module ACPFunction
    Function XMLReader(ByVal XMLPath As String, ByVal Element_1 As String, ByVal Element_2 As String)
        Dim xml = XDocument.Load(XMLPath)
        Try
            Return xml.Element(Element_1).Element(Element_2).Value
        Catch ex As Exception
            Return "Error"
        End Try
    End Function
    Public Sub XMLWriter(ByVal XMLFile As String, ByVal Element_1 As String, ByVal Element_2 As String, ByVal Value As String)
        Dim xmle As XElement = XElement.Load(XMLFile)
        If xmle.Element(Element_2) Is Nothing Then
            xmle.Add(New XElement(Element_2, Value))
            xmle.Save(XMLFile)
        Else
            xmle.SetElementValue(Element_2, Value)
            xmle.Save(XMLFile)
        End If
    End Sub
    Public Sub CreatXmlDoc(ByVal DocName As String, ByVal DocLocation As String)
        Dim writer As New XmlTextWriter(DocLocation & "\" & DocName, System.Text.Encoding.UTF8)
        writer.WriteStartDocument()
        writer.WriteStartElement("System")
        writer.WriteEndElement()
        writer.WriteEndDocument()
        writer.Close()
    End Sub
    Function SettingChecker()
        Try
            Dim SkinUse As String = XMLReader(MainForm.ACDataFolder & "\Settings.xml", "System", "SkinUse")
            Dim SkinPath As String = XMLReader(MainForm.ACDataFolder & "\Settings.xml", "System", "SkinPath")
            Dim TrayOption As String = XMLReader(MainForm.ACDataFolder & "\Settings.xml", "System", "SystemTray")
            Dim CloseAlert As String = XMLReader(MainForm.ACDataFolder & "\Settings.xml", "System", "CloseAlert")
            Dim ImageFilterOption As String = XMLReader(MainForm.ACDataFolder & "\Settings.xml", "System", "ImageFilter")
            Dim AniFolder As String = XMLReader(MainForm.ACDataFolder & "\Settings.xml", "System", "AniFolder")
            Dim ActionType As String = XMLReader(MainForm.ACDataFolder & "\Settings.xml", "System", "ActionType")
            Dim NTCatOption As String = XMLReader(MainForm.ACDataFolder & "\Settings.xml", "System", "NTCat")
            Dim NTFilterOption As String = XMLReader(MainForm.ACDataFolder & "\Settings.xml", "System", "NTFilter")
            If SkinUse = "Error" Then
                XMLWriter(MainForm.ACDataFolder & "\Settings.xml", "System", "SkinUse", 0)
            End If
            If SkinPath = "Error" Then
                XMLWriter(MainForm.ACDataFolder & "\Settings.xml", "System", "SkinPath", 0)
            End If
            If TrayOption = "Error" Then
                XMLWriter(MainForm.ACDataFolder & "\Settings.xml", "System", "SystemTray", 0)
            End If
            If CloseAlert = "Error" Then
                XMLWriter(MainForm.ACDataFolder & "\Settings.xml", "System", "CloseAlert", 0)
            End If
            If ImageFilterOption = "Error" Then
                XMLWriter(MainForm.ACDataFolder & "\Settings.xml", "System", "ImageFilter", 0)
            End If
            If AniFolder = "Error" Then
                XMLWriter(MainForm.ACDataFolder & "\Settings.xml", "System", "AniFolder", "None")
            End If
            If ActionType = "Error" Then
                XMLWriter(MainForm.ACDataFolder & "\Settings.xml", "System", "ActionType", 0)
            End If
            If NTCatOption = "Error" Then
                XMLWriter(MainForm.ACDataFolder & "\Settings.xml", "System", "NTCat", "1_11")
            End If
            If NTFilterOption = "Error" Then
                XMLWriter(MainForm.ACDataFolder & "\Settings.xml", "System", "NTFilter", 0)
            End If
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function
End Module