Public Class cls
    Public inInvert As String
    Dim character As Char
    Public outInvert As String
    Public inReplace As String
    Public outReplace As String
    Public Sub invert()
        outInvert = ""
        For a As Integer = inInvert.Length - 1 To 0 Step -1
            character = Convert.ToChar(inInvert(a))
            outInvert += character.ToString
        Next
    End Sub
    Public Sub replace()
        inReplace.Replace("a", "0")
        inReplace.Replace("z", "1")
        inReplace.Replace("e", "2")
        inReplace.Replace("r", "3")
        inReplace.Replace("t", "4")
        inReplace.Replace("y", "5")
        inReplace.Replace("u", "6")
        inReplace.Replace("i", "7")
        inReplace.Replace("o", "8")
        inReplace.Replace("p", "9")
        inReplace.Replace("q", "10")
        inReplace.Replace("s", "11")
        inReplace.Replace("d", "12")
        inReplace.Replace("f", "13")
        inReplace.Replace("g", "14")
        inReplace.Replace("h", "15")
        inReplace.Replace("j", "16")
        inReplace.Replace("k", "17")
        inReplace.Replace("l", "18")
        inReplace.Replace("m", "19")
        inReplace.Replace("w", "20")
        inReplace.Replace("x", "21")
        inReplace.Replace("c", "22")
        inReplace.Replace("v", "23")
        inReplace.Replace("b", "24")
        inReplace.Replace("n", "25")
        inReplace.Replace("A", "26")
        inReplace.Replace("B", "27")
        inReplace.Replace("C", "28")
        inReplace.Replace("D", "29")
        inReplace.Replace("g", "14")
        inReplace.Replace("h", "15")
    End Sub


End Class
