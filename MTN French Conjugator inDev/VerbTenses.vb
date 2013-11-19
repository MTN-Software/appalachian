Imports French_Conjugator.MainPage
Imports French_Conjugator.VerbAndSubjectVals
Imports French_Conjugator.IrregularVerbsvb
Imports French_Conjugator.RegularVerbs




Public Class VerbTenses
    Public Structure IPVerbs
        Public Shared strIPVerb() As String = {"ais", "ais", _
                                                "ait", "ions", _
                                                "iez", "aient"}

        ' Stupid être has to ruin everything
        Public Shared strIPVerbsEtreException() As String = _
                                                {"étais", "étais", _
                                                 "était", "étions", _
                                                 "étiez", "étaient"}

        Public Shared Sub ImperfectPast_Conj(intVerbIn As Integer)
            Dim intVerbCut As Integer

            If (blnIsIrregular = True) Then
                Select Case intVerbIn
                    Case 1
                        strSTDNous = Irregular.strAller(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 2
                        strSTDNous = Irregular.strAppeler(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 3
                        strSTDNous = Irregular.strAvoir(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 4
                        strSTDNous = Irregular.strConduire(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 5
                        strSTDNous = Irregular.strCourir(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 6
                        strSTDNous = Irregular.strDire(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 7
                        strSTDNous = Irregular.strDormir(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 8

                        strVerb = strIPVerbsEtreException(intSubject)

                    Case 9
                        strSTDNous = Irregular.strFaire(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 10
                        strSTDNous = Irregular.strMettre(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 11
                        strSTDNous = Irregular.strPartir(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 12
                        strSTDNous = Irregular.strPrefere(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 13
                        strSTDNous = Irregular.strPrendre(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 14
                        strSTDNous = Irregular.strRire(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 15
                        strSTDNous = Irregular.strSortir(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 16
                        strSTDNous = Irregular.strTraduire(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case Else
                        strVerb = "Error: No Verb Selected"

                End Select
            Else
                Dim intVerbLength As Integer = strCurrentVerb.Length
                ' Check if verb has a 'g' before the verb ending
                Dim intCheck As Integer = intVerbLength - 3
                Dim strVerbType As String = strCurrentVerb.Substring(intVerbCut, 2)
                ' Actually check this time
                Dim strCheck As String = strCurrentVerb.Substring(intCheck, 3)
                Dim strVerbStem As String = strCurrentVerb.Substring(0, intVerbCut)

                strRegularVerbEnding = strVerbType
                If (intSubject = 3) Then
                    If (strCheck.First <> "g") Then
                        strSTDNous = strCurrentVerb
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj
                    Else
                        strSTDNous = strCurrentVerb
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & "ge" & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj
                    End If
                Else
                    strSTDNous = strCurrentVerb
                    intVerbCut = ((strSTDNous.Length) - 3)
                    strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                    strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                    strVerb = strIPVerbConj
                End If
                
            End If

        End Sub

    End Structure

    
    Public Shared Sub Present_Conj()
        If (blnIsIrregular = True) Then
            Select Case intVerb
                Case 1
                    strVerb = Irregular.strAller(intSubject)

                Case 2
                    strVerb = Irregular.strAppeler(intSubject)

                Case 3
                    strVerb = Irregular.strAvoir(intSubject)

                Case 4
                    strVerb = Irregular.strConduire(intSubject)

                Case 5
                    strVerb = Irregular.strCourir(intSubject)

                Case 6
                    strVerb = Irregular.strDire(intSubject)

                Case 7
                    strVerb = Irregular.strDormir(intSubject)

                Case 8
                    strVerb = Irregular.strEtre(intSubject)

                Case 9
                    strVerb = Irregular.strFaire(intSubject)

                Case 10
                    strVerb = Irregular.strMettre(intSubject)

                Case 11
                    strVerb = Irregular.strPartir(intSubject)

                Case 12
                    strVerb = Irregular.strPrefere(intSubject)

                Case 13
                    strVerb = Irregular.strPrendre(intSubject)

                Case 14
                    strVerb = Irregular.strRire(intSubject)

                Case 15
                    strVerb = Irregular.strSortir(intSubject)

                Case 16
                    strVerb = Irregular.strTraduire(intSubject)

                Case Else
                    strVerb = "Error: No Verb Selected"

            End Select




        Else
            Dim intVerbLength As Integer = strCurrentVerb.Length
            ' Check if verb has a 'g' before the verb ending
            Dim intCheck As Integer = intVerbLength - 3
            Dim intVerbCut As Integer = intVerbLength - 2
            Dim strVerbType As String = strCurrentVerb.Substring(intVerbCut, 2)
            ' Actually check this time
            Dim strCheck As String = strCurrentVerb.Substring(intCheck, 3)
            Dim strVerbStem As String = strCurrentVerb.Substring(0, intVerbCut)

            strRegularVerbEnding = strVerbType
            If (intSubject = 3) Then
                If (strCheck.First <> "g") Then
                    Select Case strVerbType
                        Case "er"
                            strVerb = strVerbStem & Regular.strErVerb(intSubject)
                        Case "re"
                            strVerb = strVerbStem & Regular.strReVerb(intSubject)
                        Case "ir"
                            strVerb = strVerbStem & Regular.strIrVerb(intSubject)
                        Case Else
                            strVerb = "Error: Unknown verb ending"
                    End Select
                Else
                    Select Case strVerbType
                        Case "er"
                            strVerb = strVerbStem & "e" & Regular.strErVerb(intSubject)
                        Case "re"
                            strVerb = strVerbStem & "e" & Regular.strReVerb(intSubject)
                        Case "ir"
                            strVerb = strVerbStem & "e" & Regular.strIrVerb(intSubject)
                        Case Else
                            strVerb = "Error: Unknown verb ending"
                    End Select
                End If
            Else
                Select Case strVerbType
                    Case "er"
                        strVerb = strVerbStem & Regular.strErVerb(intSubject)
                    Case "re"
                        strVerb = strVerbStem & Regular.strReVerb(intSubject)
                    Case "ir"
                        strVerb = strVerbStem & Regular.strIrVerb(intSubject)
                    Case Else
                        strVerb = "Error: Unknown verb ending"
                End Select
            End If
        End If
    End Sub


End Class
