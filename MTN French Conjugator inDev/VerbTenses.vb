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

                    Case 17
                        strSTDNous = Irregular.strApprendre(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 18
                        strSTDNous = Irregular.strAtteindre(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 19
                        strSTDNous = Irregular.strAcquerir(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 20
                        strSTDNous = Irregular.strBoire(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 21
                        strSTDNous = Irregular.strBattre(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 22
                        strSTDNous = Irregular.strComprendre(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 23
                        strSTDNous = Irregular.strConnaitre(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 24
                        strSTDNous = Irregular.strConstruire(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 25
                        strSTDNous = Irregular.strCouvrir(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 26
                        strSTDNous = Irregular.strCraindre(3)
                        intVerbCut = ((strSTDNous.Length) - 3)
                        strSTDNousStem = strSTDNous.Substring(0, intVerbCut)
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj

                    Case 27
                        strSTDNous = Irregular.strCroire(3)
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
                intVerbCut = intVerbLength - 2
                Dim strVerbType As String = strCurrentVerb.Substring(intVerbCut, 2)
                ' Actually check this time
                Dim strCheck As String = strCurrentVerb.Substring(intCheck, 3)
                Dim strVerbStem As String = strCurrentVerb.Substring(0, intVerbCut)
                strNverbStem = strCurrentVerb.Substring(0, intVerbCut)



                strRegularVerbEnding = strVerbType
                If ((intSubject = 3) Or (intSubject = 4)) Then

                    If (strCheck.First <> "g") Then
                        strSTDNousStem = strNverbStem
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj
                    Else
                        strSTDNousStem = strNverbStem
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj
                    End If
                Else
                    If (strCheck.First <> "g") Then
                        strSTDNousStem = strNverbStem
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj
                    Else
                        strSTDNousStem = strNverbStem & "e"
                        strIPVerbConj = strSTDNousStem & IPVerbs.strIPVerb(intSubject)
                        strVerb = strIPVerbConj
                    End If
                End If
                
            End If

        End Sub

    End Structure

    Public Structure PCVerbs        'passé composé (I should probably clean up the code soon... I'm not even using structs correctly
        Public Shared strListOfIrregularPC() As String = {"acquérir", "apprendre", "atteindre", "attendre", "avoir", "battre", _
                                                          "boire", "comprendre", "conduire", "connaître", "construire", "courir", _
                                                          "couvrir", "craindre", "croire", "décevoir", "découvrir", "devoir", "dire", _
                                                          "écrire", "être", "faire", "fondre", "instruire", "joindre", "lire", "mettre", _
                                                          "offrir", "ouvrir", "paraître", "peindre", "pouvoir", "prendre", "produire", _
                                                          "recevoir", "savoir", "souffrir", "surprendre", "suivre", "tenir", _
                                                           "venir", "vivre", "voir", "vouloir"}

        Public Shared strListOfIrregularPCConj() As String = {"acquis", "appris", "atteint", "attendu", "eu", "battu", "bu", "compris", _
                                                              "conduit", "connu", "construit", "couru", "couvert", "craint", "cru", "déçu", _
                                                              "découvert", "dû", "dit", "écrit", "été", "fait", "fondu", "instruit", "joint", _
                                                              "lu", "mis", "offert", "ouvert", "paru", "peint", "pu", "pris", "produit", _
                                                              "reçu", "su", "souffert", "surpris", "suivi", "tenu", "venu", "vécu", "vu", _
                                                              "voulu"}


        Public Shared strEtreInPC() As String = {"devenir", "revenir", "monter", "rester", "sortir", "passer", "venir", _
                                                 "aller", "naître", "descendre", "entrer", "retourner", "tomber", "rentrer", _
                                                 "arriver", "mourir", "partir", "décéder"}
    End Structure

    Public Shared Sub PC_Conj()
        Dim strEtreConj As String = Irregular.strEtre(intSubject)
        Dim strAvoirConj As String = Irregular.strAvoir(intSubject)

        If (blnIsIrregularInPC = True) Then
            Select Case intPCIrregularVerb
                Case intPCIrregularVerb
                    strVerb = PCVerbs.strListOfIrregularPCConj(intPCIrregularVerb)
                Case Else
                    strVerb = "Error: No Verb Detected"
            End Select
        ElseIf (blnIsIrregularInPC = False) Then
            Dim intVerbLength As Integer = strCurrentVerb.Length
            intVerbCut = intVerbLength - 2
            Dim strVerbType As String = strCurrentVerb.Substring(intVerbCut, 2)
            Dim strVerbStem As String = strCurrentVerb.Substring(0, intVerbCut)
            Select Case strVerbType
                Case "er"
                    strVerb = strVerbStem & "é"
                Case "re"
                    strVerb = strVerbStem & "u"
                Case "ir"
                    strVerb = strVerbStem & "i"
                Case Else
                    strVerb = "Error: Unknown verb ending"
            End Select
        End If

        If (blnUseEtreInPC = True) Then
            strVerb = strEtreConj & " " & strVerb
            Select Case intSubject
                Case 2
                    strVerb = strVerb & "(e)"
                Case 3 To 5
                    strVerb = strVerb & "(e)(s)"
                Case Else
                    strVerb = strVerb
            End Select

        ElseIf (blnUseEtreInPC = False) Then
            strVerb = strAvoirConj & " " & strVerb
            Select Case intSubject
                Case 2
                    strVerb = strVerb & "(e)"
                Case 3 To 5
                    strVerb = strVerb & "(e)(s)"
                Case Else
                    strVerb = strVerb
            End Select
        End If
    End Sub

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

                Case 17
                    strVerb = Irregular.strApprendre(intSubject)

                Case 18
                    strVerb = Irregular.strAtteindre(intSubject)

                Case 19
                    strVerb = Irregular.strAcquerir(intSubject)

                Case 20
                    strVerb = Irregular.strBoire(intSubject)

                Case 21
                    strVerb = Irregular.strBattre(intSubject)

                Case 22
                    strVerb = Irregular.strComprendre(intSubject)

                Case 23
                    strVerb = Irregular.strConnaitre(intSubject)

                Case 24
                    strVerb = Irregular.strConstruire(intSubject)

                Case 25
                    strVerb = Irregular.strCouvrir(intSubject)

                Case 26
                    strVerb = Irregular.strCraindre(intSubject)

                Case 27
                    strVerb = Irregular.strCroire(intSubject)

                Case Else
                    strVerb = "Error: No Verb Detected"

            End Select




        Else
            Dim intVerbLength As Integer = strCurrentVerb.Length
            ' Check if verb has a 'g' before the verb ending
            Dim intCheck As Integer = intVerbLength - 3
            intVerbCut = intVerbLength - 2
            Dim strVerbType As String = strCurrentVerb.Substring(intVerbCut, 2)
            ' Actually check this time
            Dim strCheck As String = strCurrentVerb.Substring(intCheck, 3)
            Dim strVerbStem As String = strCurrentVerb.Substring(0, intVerbCut)
            strNverbStem = strCurrentVerb.Substring(0, intVerbCut)

            strRegularVerbEnding = strVerbType
            If (intSubject = 3) Then
                If (strCheck.First <> "g") Then
                    Select Case strVerbType
                        Case "er"
                            strVerb = strVerbStem & Regular.strErVerb(intSubject)
                            strNverbStem = strVerb.Substring(0, intCheck)
                        Case "re"
                            strVerb = strVerbStem & Regular.strReVerb(intSubject)
                            strNverbStem = strVerb.Substring(0, intCheck)
                        Case "ir"
                            strVerb = strVerbStem & Regular.strIrVerb(intSubject)
                            strNverbStem = strVerb.Substring(0, intCheck)
                        Case Else
                            strVerb = "Error: Unknown verb ending"
                    End Select
                Else
                    Select Case strVerbType
                        Case "er"
                            strVerb = strNverbStem & "e" & Regular.strErVerb(intSubject)
                            strNverbStem = strVerb.Substring(0, intCheck)
                        Case "re"
                            strVerb = strNverbStem & "e" & Regular.strReVerb(intSubject)
                            strNverbStem = strVerb.Substring(0, intCheck)
                        Case "ir"
                            strVerb = strNverbStem & "e" & Regular.strIrVerb(intSubject)
                            strNverbStem = strVerb.Substring(0, intCheck)
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
                    Case "ne"
                        strVerb = "No verb has been entered."
                    Case Else
                        strVerb = "Error: Unknown verb ending"
                End Select
            End If
        End If
    End Sub


End Class
